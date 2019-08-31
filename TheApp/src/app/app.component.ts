import { Component, Inject } from "@angular/core";
import { MyDataService } from "./my-data.service";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.scss"]
})
export class AppComponent {
  dataService: MyDataService;
  title = "TheApp";
  myValue: string;
  myData: string;

  constructor(dataService: MyDataService) {
    this.dataService = dataService;
  }

  FetchData() {
    this.myData =
      "[ " + (this.dataService.GetTheData() || []).join(", ") + " ]";
  }
}
