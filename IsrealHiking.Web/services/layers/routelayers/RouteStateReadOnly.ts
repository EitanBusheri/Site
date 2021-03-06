declare namespace L {
    interface AntPathOptions extends PolylineOptions {
        delay?: string;
        pulseColor?: string;
        paused?: boolean;
    }
    namespace polyline {
        function antPath(latlngs: LatLng[], options: AntPathOptions): L.Polyline;
    }
}

namespace IsraelHiking.Services.Layers.RouteLayers {
    export class RouteStateReadOnly extends RouteStateBase {
        private readOnlyLayers: L.LayerGroup<L.ILayer>;

        constructor(context: RouteLayer) {
            super(context);
            this.readOnlyLayers = L.layerGroup([]);
            this.initialize();
        }

        private addPolyline(latlngzs: L.LatLng[]): void {
            let routePathOptions = this.context.route.properties.pathOptions;
            let pathOptions = { delay: "2000", pulseColor: routePathOptions.color, dashArray: "30 10", opacity: routePathOptions.opacity, color: "transparent", weight: routePathOptions.weight } as L.AntPathOptions;
            let polyline = L.polyline.antPath(latlngzs, pathOptions);
            this.readOnlyLayers.addLayer(polyline);
        }

        private createStartAndEndMarkers() {
            let startLatLng = this.context.route.segments[0].latlngzs[0];
            let lastSegmentLatLngs = this.context.route.segments[this.context.route.segments.length - 1].latlngzs;
            let endLatLng = lastSegmentLatLngs[lastSegmentLatLngs.length - 1];
            let pathOptions = this.context.route.properties.pathOptions;
            this.readOnlyLayers.addLayer(L.marker(startLatLng,
                {
                    opacity: pathOptions.opacity,
                    draggable: false,
                    clickable: false,
                    icon: IconsService.createRoundIcon("green")
                }));
            this.readOnlyLayers.addLayer(L.marker(endLatLng,
                {
                    opacity: pathOptions.opacity,
                    draggable: false,
                    clickable: false,
                    icon: IconsService.createRoundIcon("red")
                }));
        }

        public initialize() {
            this.context.map.addLayer(this.readOnlyLayers);
            this.readOnlyLayers.clearLayers();
            if (this.context.route.segments.length <= 0) {
                return;
            }
            this.createStartAndEndMarkers();
            let groupedLatLngs = []; // gourp as many segment in order for the ant path to look smoother
            for (let segment of this.context.route.segments) {
                segment.routePointMarker = null;
                segment.polyline = null;
                if (groupedLatLngs.length === 0) {
                    groupedLatLngs = segment.latlngzs;
                    continue;
                }
                if (groupedLatLngs[groupedLatLngs.length - 1].equals(segment.latlngzs[0])) {
                    groupedLatLngs = groupedLatLngs.concat(segment.latlngzs);
                    continue;
                }
                this.addPolyline(groupedLatLngs);
                groupedLatLngs = segment.latlngzs;
            }
            this.addPolyline(groupedLatLngs);
        }

        public clear() {
            this.readOnlyLayers.clearLayers();
            this.context.map.removeLayer(this.readOnlyLayers);
        }

        public getEditMode(): EditMode {
            return EditModeString.none;
        }
    }
}