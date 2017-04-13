module Bootcamp {
	export class Area {
		private id: number;
		private name: string;

		public get Id(): number {
			return this.id;
		}

		public set Id(id: number){
			this.id = id;
		}

		public get Name(): string {
			return this.name;
		}

		public set Name(name: string) {
			this.name = name;
		}
	}
}