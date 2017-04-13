module Bootcamp {
	export class AreaController {
		private areas: Array<Area>;
		private areaSvc: AreaService;

		static $inject = ["areaService"];
		constructor(areaService: AreaService) {
			this.areaSvc = areaService;
		}

		public get Areas(): Array<Area> {

			if (this.areas === undefined) {
				this.areaSvc.getAreas().then((result: ng.IHttpPromiseCallbackArg<Array<Area>>) => {
					this.areas = result.data;
				});
			}
			return this.areas;
		}
	}
}

angular.module("app").controller("areaController", Bootcamp.AreaController);