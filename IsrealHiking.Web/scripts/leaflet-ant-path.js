!function(t,e){"object"==typeof exports&&"object"==typeof module?module.exports=e(require("leaflet")):"function"==typeof define&&define.amd?define(["leaflet"],e):"object"==typeof exports?exports["leaflet-ant-path"]=e(require("leaflet")):t["leaflet-ant-path"]=e(t.L)}(this,function(t){return function(t){function e(a){if(n[a])return n[a].exports;var i=n[a]={exports:{},id:a,loaded:!1};return t[a].call(i.exports,i,i.exports,e),i.loaded=!0,i.exports}var n={};return e.m=t,e.c=n,e.p="",e(0)}([function(t,e,n){"use strict";function a(t){return t&&t.__esModule?t:{"default":t}}Object.defineProperty(e,"__esModule",{value:!0}),e.multiAntPath=e.MultiAntPath=e.antPath=e.AntPath=void 0;var i=n(1),o=n(2),r=a(o),s=n(3),u=a(s),l=n(4),f=a(l),d=n(5),p=a(d);n(6),i.Polyline.AntPath=r["default"],i.polyline.antPath=u["default"],i.MultiPolyline.MultiAntPath=f["default"],i.multiPolyline.multiAntPat=p["default"],e.AntPath=r["default"],e.antPath=u["default"],e.MultiAntPath=f["default"],e.multiAntPath=p["default"]},function(e,n){e.exports=t},function(t,e,n){"use strict";Object.defineProperty(e,"__esModule",{value:!0});var a=n(1),i=a.FeatureGroup.extend({_path:null,_animatedPathId:null,_animatedPathClass:"leaflet-ant-path",options:{paused:!1,delay:400,dashArray:[10,20],pulseColor:"#FFFFFF"},initialize:function(t,e){a.LayerGroup.prototype.initialize.call(this),a.Util.setOptions(this,e),this._map=null,this._path=t,this._animatedPathId="ant-path-"+(new Date).getTime(),this._draw()},onAdd:function(t){this._map=t,this._map.on("zoomend",this._calculateAnimationSpeed,this),this._draw(),this._calculateAnimationSpeed()},onRemove:function(t){this._map.off("zoomend",this._calculateAnimationSpeed,this),this._map=null,a.LayerGroup.prototype.onRemove.call(this,t)},pause:function(){if(this.options.paused)return!1;for(var t=document.getElementsByClassName(this._animatedPathId),e=0;e<t.length;e++)t[e].removeAttribute("style");return this.options.paused=!0},resume:function(){this._calculateAnimationSpeed()},_draw:function(){var t={},e={};(0,a.extend)(e,this.options),(0,a.extend)(t,this.options),e.color=e.pulseColor||this.options.pulseColor,e.className=this._animatedPathClass+" "+this._animatedPathId,delete t.dashArray,this.addLayer(new a.Polyline(this._path,t)),this.addLayer(new a.Polyline(this._path,e))},_calculateAnimationSpeed:function(){if(!this.options.paused&&this._map){var t=this._map.getZoom(),e=document.getElementsByClassName(this._animatedPathId),n=1+this.options.delay/3/t+"s",a=["-webkit-","-moz-","-ms-",""];Array.prototype.map.call(e,function(t){a.map(function(e){t.setAttribute("style",e+"animation-duration: "+n)})})}}});e["default"]=i,t.exports=e["default"]},function(t,e,n){"use strict";function a(t){return t&&t.__esModule?t:{"default":t}}function i(t,e){return new r["default"](t,e)}Object.defineProperty(e,"__esModule",{value:!0});var o=n(2),r=a(o);e["default"]=i,t.exports=e["default"]},function(t,e,n){"use strict";function a(t){return t&&t.__esModule?t:{"default":t}}Object.defineProperty(e,"__esModule",{value:!0});var i=n(1),o=n(2),r=a(o),s=i.FeatureGroup.extend({initialize:function(t,e){this._layers={},this._options=e,this.setLatLngs(t)},setLatLngs:function(t){var e=0,n=t.length;for(this.eachLayer(function(a){e<n?a.setLatLngs(t[e++]):this.removeLayer(a)},this);e<n;)this.addLayer(new r["default"](t[e++],this._options));return this},getLatLngs:function(){var t=[];return this.eachLayer(function(e){t.push(e.getLatLngs())}),t},pause:function(){this.eachLayer(function(t){t.pause()})},resume:function(){this.eachLayer(function(t){t.resume()})}});e["default"]=s,t.exports=e["default"]},function(t,e,n){"use strict";function a(t,e){return new i.MultiAntPath(t,e)}Object.defineProperty(e,"__esModule",{value:!0});var i=n(4);e["default"]=a,t.exports=e["default"]},function(t,e,n){var a=n(7);"string"==typeof a&&(a=[[t.id,a,""]]);n(9)(a,{});a.locals&&(t.exports=a.locals)},function(t,e,n){e=t.exports=n(8)(),e.push([t.id,"@-webkit-keyframes leaflet-ant-path-animation{0%{stroke-dashoffset:100%}to{stroke-dashoffset:0%}}@keyframes leaflet-ant-path-animation{0%{stroke-dashoffset:100%}to{stroke-dashoffset:0%}}path.leaflet-ant-path{fill:none;-webkit-animation:linear infinite leaflet-ant-path-animation;animation:linear infinite leaflet-ant-path-animation}",""])},function(t,e){"use strict";t.exports=function(){var t=[];return t.toString=function(){for(var t=[],e=0;e<this.length;e++){var n=this[e];n[2]?t.push("@media "+n[2]+"{"+n[1]+"}"):t.push(n[1])}return t.join("")},t.i=function(e,n){"string"==typeof e&&(e=[[null,e,""]]);for(var a={},i=0;i<this.length;i++){var o=this[i][0];"number"==typeof o&&(a[o]=!0)}for(i=0;i<e.length;i++){var r=e[i];"number"==typeof r[0]&&a[r[0]]||(n&&!r[2]?r[2]=n:n&&(r[2]="("+r[2]+") and ("+n+")"),t.push(r))}},t}},function(t,e,n){function a(t,e){for(var n=0;n<t.length;n++){var a=t[n],i=h[a.id];if(i){i.refs++;for(var o=0;o<i.parts.length;o++)i.parts[o](a.parts[o]);for(;o<a.parts.length;o++)i.parts.push(l(a.parts[o],e))}else{for(var r=[],o=0;o<a.parts.length;o++)r.push(l(a.parts[o],e));h[a.id]={id:a.id,refs:1,parts:r}}}}function i(t){for(var e=[],n={},a=0;a<t.length;a++){var i=t[a],o=i[0],r=i[1],s=i[2],u=i[3],l={css:r,media:s,sourceMap:u};n[o]?n[o].parts.push(l):e.push(n[o]={id:o,parts:[l]})}return e}function o(t,e){var n=v(),a=g[g.length-1];if("top"===t.insertAt)a?a.nextSibling?n.insertBefore(e,a.nextSibling):n.appendChild(e):n.insertBefore(e,n.firstChild),g.push(e);else{if("bottom"!==t.insertAt)throw new Error("Invalid value for parameter 'insertAt'. Must be 'top' or 'bottom'.");n.appendChild(e)}}function r(t){t.parentNode.removeChild(t);var e=g.indexOf(t);e>=0&&g.splice(e,1)}function s(t){var e=document.createElement("style");return e.type="text/css",o(t,e),e}function u(t){var e=document.createElement("link");return e.rel="stylesheet",o(t,e),e}function l(t,e){var n,a,i;if(e.singleton){var o=_++;n=y||(y=s(e)),a=f.bind(null,n,o,!1),i=f.bind(null,n,o,!0)}else t.sourceMap&&"function"==typeof URL&&"function"==typeof URL.createObjectURL&&"function"==typeof URL.revokeObjectURL&&"function"==typeof Blob&&"function"==typeof btoa?(n=u(e),a=p.bind(null,n),i=function(){r(n),n.href&&URL.revokeObjectURL(n.href)}):(n=s(e),a=d.bind(null,n),i=function(){r(n)});return a(t),function(e){if(e){if(e.css===t.css&&e.media===t.media&&e.sourceMap===t.sourceMap)return;a(t=e)}else i()}}function f(t,e,n,a){var i=n?"":a.css;if(t.styleSheet)t.styleSheet.cssText=b(e,i);else{var o=document.createTextNode(i),r=t.childNodes;r[e]&&t.removeChild(r[e]),r.length?t.insertBefore(o,r[e]):t.appendChild(o)}}function d(t,e){var n=e.css,a=e.media;if(a&&t.setAttribute("media",a),t.styleSheet)t.styleSheet.cssText=n;else{for(;t.firstChild;)t.removeChild(t.firstChild);t.appendChild(document.createTextNode(n))}}function p(t,e){var n=e.css,a=e.sourceMap;a&&(n+="\n/*# sourceMappingURL=data:application/json;base64,"+btoa(unescape(encodeURIComponent(JSON.stringify(a))))+" */");var i=new Blob([n],{type:"text/css"}),o=t.href;t.href=URL.createObjectURL(i),o&&URL.revokeObjectURL(o)}var h={},c=function(t){var e;return function(){return"undefined"==typeof e&&(e=t.apply(this,arguments)),e}},m=c(function(){return/msie [6-9]\b/.test(window.navigator.userAgent.toLowerCase())}),v=c(function(){return document.head||document.getElementsByTagName("head")[0]}),y=null,_=0,g=[];t.exports=function(t,e){e=e||{},"undefined"==typeof e.singleton&&(e.singleton=m()),"undefined"==typeof e.insertAt&&(e.insertAt="bottom");var n=i(t);return a(n,e),function(t){for(var o=[],r=0;r<n.length;r++){var s=n[r],u=h[s.id];u.refs--,o.push(u)}if(t){var l=i(t);a(l,e)}for(var r=0;r<o.length;r++){var u=o[r];if(0===u.refs){for(var f=0;f<u.parts.length;f++)u.parts[f]();delete h[u.id]}}}};var b=function(){var t=[];return function(e,n){return t[e]=n,t.filter(Boolean).join("\n")}}()}])});
//# sourceMappingURL=leaflet-ant-path.js.map