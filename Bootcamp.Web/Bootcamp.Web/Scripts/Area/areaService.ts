module Bootcamp {
	export class AreaService {
		private $http: ng.IHttpService;
		static $inject = ["$http"];

		constructor($http: ng.IHttpService) {
			this.$http = $http;
		}

		public getAreas(): ng.IHttpPromise<Array<Area>> {
			return this.$http.get("/api/AreaQuery/");
		} 
	}
}

angular.module("app").service("areaService", Bootcamp.AreaService);