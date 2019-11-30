import { Component } from '@angular/core';
import { CityList } from "../city-list";
import { CityService } from "../city.service";

@Component({
  selector: 'app-city-index',
  templateUrl: './city-index.component.html'
})
export class CityIndexComponent {
  public cityList: CityList;

  constructor(private cityService: CityService) {
    this.getData();
  }

  getData() {
    this.cityService.getCities().subscribe((cities: CityList) => {
        this.cityList = cities;
      },
      error => console.error(error));
  }

  deleteCity(id:number) {
    this.cityService.deleteCity(id).subscribe(result => {
        this.getData();
      },
      error => console.error(error));
  }
}
