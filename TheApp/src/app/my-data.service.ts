import { Injectable } from "@angular/core";

@Injectable({
  providedIn: "root"
})
export class MyDataService {
  constructor() {}

  GetTheData(): string[] {
    return ["This", "Is", "Some", "Data"];
  }
}
