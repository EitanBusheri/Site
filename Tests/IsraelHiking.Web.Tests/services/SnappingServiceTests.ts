﻿/// <reference path="mapservicemockcreator.ts" />
/// <reference path="../../../isrealhiking.web/services/mapservice.ts" />
/// <reference path="../../../IsrealHiking.Web/scripts/typings/angularjs/angular-mocks.d.ts" />
/// <reference path="../../../isrealhiking.web/scripts/typings/lodash/lodash.d.ts" />
/// <reference path="../../../isrealhiking.web/services/snappingservice.ts" />
/// <reference path="../../../IsrealHiking.Web/services/parsers/BaseParser.ts" />
/// <reference path="../../../isrealhiking.web/services/objectwithmap.ts" />
/// <reference path="../../../isrealhiking.web/services/parsers/parserfactory.ts" />
/// <reference path="../../../IsrealHiking.Web/scripts/typings/toastr/toastr.d.ts" />

namespace IsraelHiking.Tests.Services {
    describe("Snapping Service", () => {
        var $http: angular.IHttpService;
        var $httpBackend: angular.IHttpBackendService;
        var mapService: IsraelHiking.Services.MapService;
        var parserFactory: IsraelHiking.Services.Parsers.ParserFactory;
        //var toastr: Toastr;
        var snappingService: IsraelHiking.Services.SnappingService;
        var mapDiv: JQuery;

        var osmWay = "<?xml version='1.0' encoding='UTF-8'?>\
                        <osm version='0.6' generator='JOSM'>\
                          <node id='1' lat='34.0666735' lon='-118.734254'>\
                            <tag k='name' v='Santa Monica Mountains National Recreation Area' />\
                            <tag k='leisure' v='park' />\
                            <tag k='ele' v='243' />\
                          </node>\
                          <node id='2' lat='34.0723400' lon='-118.7343501' />\
                          <node id='3' lat='34.0670965' lon='-118.7322253' />\
                          <node id='4' lat='34.0724577' lon='-118.7364799' />\
                          <node id='5' lat='34.0671122' lon='-118.7364725' />\
                          <node id='6' lat='34.0722227' lon='-118.7322321' />\
                          <way id='7'>\
                            <nd ref='1' />\
                            <nd ref='2' />\
                            <nd ref='3' />\
                            <nd ref='4' />\
                            <nd ref='5' />\
                            <nd ref='6' />\
                            <tag k='park:type' v='state_park' />\
                            <tag k='name' v='Malibu Creek State Park' />\
                            <tag k='leisure' v='park' />\
                          </way>\
                        </osm>";

        beforeEach(() => {
            angular.mock.module("toastr");
            angular.mock.module("LocalStorageModule");
            angular.mock.module("gettext");
            angular.mock.inject((_$http_: angular.IHttpService, _$httpBackend_: angular.IHttpBackendService, _$document_: angular.IDocumentService, _localStorageService_: angular.local.storage.ILocalStorageService, _gettextCatalog_: angular.gettext.gettextCatalog, _toastr_:  Toastr) => {
                // The injector unwraps the underscores (_) from around the parameter names when matching
                $http = _$http_;
                $httpBackend = _$httpBackend_;
                mapDiv = MapServiceMockCreator.createMapDiv(_$document_);
                _toastr_.error = (): any => { };
                mapService = new IsraelHiking.Services.MapService();
                parserFactory = new IsraelHiking.Services.Parsers.ParserFactory();
                $httpBackend.whenGET(url => url.indexOf(Common.Urls.translations) !== -1).respond(404, {}); // ignore resources get request
                snappingService = new IsraelHiking.Services.SnappingService($http, new IsraelHiking.Services.ResourcesService(null, _localStorageService_, _gettextCatalog_), mapService, parserFactory, _toastr_);
                snappingService.enable(true);
            });
        });

        afterEach(() => {
            mapDiv.remove();
            mapDiv = null;
        });

        it("Should clear snappings layer when disabled", () => {
            snappingService.enable(false);
            mapService.map.setZoom(14); // this fires moveend

            expect(snappingService.snappings.getLayers().length).toBe(0);
            expect(snappingService.isEnabled()).toBe(false);
        });

        it("Should clear snappings layer when zoom is less than 14", () => {
            mapService.map.setZoom(12); // this fires moveend

            expect(snappingService.snappings.getLayers().length).toBe(0);
        });



        it("Should add one snappings layer when zoom is 14", () => {
            $httpBackend.whenGET(() => true).respond(osmWay);

            mapService.map.setZoom(14);
            $httpBackend.flush();

            expect(snappingService.snappings.getLayers().length).toBe(1);
        });

        it("Should clear layer upon http error", () => {
            snappingService.snappings.addLayer(L.polyline([L.latLng(1, 1), L.latLng(2, 2)]));
            expect(snappingService.snappings.getLayers().length).toBe(1);
            $httpBackend.whenGET(() => true).respond(500, {});

            mapService.map.setZoom(14);
            $httpBackend.flush();

            expect(snappingService.snappings.getLayers().length).toBe(0);
        });


        it("Should snap to its own layers", () => {
            snappingService.snappings.addLayer(L.polyline([L.latLng(1, 1), L.latLng(1, 2)]));

            let snap = snappingService.snapTo(L.latLng(1.00001, 1));

            expect(snap.latlng.lat).toBe(1.0);
            expect(snap.latlng.lng).toBe(1.0); 
        });

        it("Should snap to closest point", () => {
            snappingService.snappings.addLayer(L.polyline([L.latLng(1, 1), L.latLng(1, 1.00001), L.latLng(1, 2)]));

            let snap = snappingService.snapTo(L.latLng(1, 1.0001));

            expect(snap.latlng.lat).toBeGreaterThan(1.0);
            expect(snap.latlng.lng).toBeGreaterThan(1.0);
        });

        it("Should snap to its own layers but ignore a line with single point", () => {
            snappingService.snappings.addLayer(L.polyline([L.latLng(1, 1)]));
            snappingService.snappings.addLayer(L.polyline([L.latLng(1, 1), L.latLng(1, 2)]));

            let snap = snappingService.snapTo(L.latLng(1.00001, 1));

            expect(snap.latlng.lat).toBe(1.0);
            expect(snap.latlng.lng).toBe(1.0); 
        });
        it("Should snap to a given layer", () => {
            let layers = L.layerGroup([]); 
            layers.addLayer(L.polyline([L.latLng(1, 1), L.latLng(1, 2)]));

            let snap = snappingService.snapTo(L.latLng(1.01, 1), { layers: layers, sensitivity: 1000 } as IsraelHiking.Services.ISnappingOptions);

            expect(snap.latlng.lat).toBe(1.0);
            expect(snap.latlng.lng).toBe(1.0); 
        });
        it("Should not snap when there are no layers", () => {
            let snap = snappingService.snapTo(L.latLng(10, 10));

            expect(snap.polyline).toBeNull();
        });
        it("Should not snap when point is too far", () => {
            snappingService.snappings.addLayer(L.polyline([L.latLng(1, 1), L.latLng(2, 2)]));

            let snap = snappingService.snapTo(L.latLng(10, 10));

            expect(snap.polyline).toBeNull();
        });
    });
}