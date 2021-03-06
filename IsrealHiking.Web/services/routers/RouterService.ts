﻿namespace IsraelHiking.Services.Routers {
    export class RouterService {
        private $http: angular.IHttpService;
        private $q: angular.IQService;
        private resourcesService: ResourcesService;
        private toastr: Toastr;
        private geojsonParser: Parsers.IParser;

        constructor($http: angular.IHttpService,
            $q: angular.IQService,
            resourcesService: ResourcesService,
            toastr: Toastr,
            parserFactory: Parsers.ParserFactory) {
            this.$http = $http;
            this.$q = $q;
            this.resourcesService = resourcesService;
            this.toastr = toastr;
            this.geojsonParser = parserFactory.create(Parsers.ParserType.geojson);
        }

        public getRoute(latlngStart: L.LatLng, latlngEnd: L.LatLng, routinType: Common.RoutingType): angular.IPromise<Common.RouteSegmentData[]> {
            var address = Common.Urls.routing + "?from=" + latlngStart.lat + "," + latlngStart.lng + "&to=" + latlngEnd.lat + "," + latlngEnd.lng + "&type=" + routinType;
            var deferred = this.$q.defer();
            var noneRouter = new NoneRouter(this.$q);
            this.$http.get(address, { timeout: 4500 } as angular.IRequestShortcutConfig)
                .success((geojson: GeoJSON.FeatureCollection<GeoJSON.GeometryObject>) => {
                    var failed = false;
                    let data = null;
                    try {
                        data = this.geojsonParser.parse(JSON.stringify(geojson));
                    } catch (err) {
                        failed = true;
                    }
                    if (failed || !data || data.routes.length === 0 || data.routes[0].segments.length < 2) {
                        this.toastr.error(this.resourcesService.routingFailed + ` ${latlngStart} => ${latlngEnd}`);
                        noneRouter.getRoute(latlngStart, latlngEnd).then((noneRouterData) => {
                            deferred.resolve(noneRouterData);
                        });
                    } else {
                        deferred.resolve(data.routes[0].segments);
                    }
                }).error(() => {
                    this.toastr.error(this.resourcesService.routingFailed + ` ${latlngStart} => ${latlngEnd}`);
                    noneRouter.getRoute(latlngStart, latlngEnd).then((data) => {
                        deferred.resolve(data);
                    });

                });
            return deferred.promise;
        }
    }
}  