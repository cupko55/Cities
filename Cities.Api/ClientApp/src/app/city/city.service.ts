import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { CityDto } from "./cityDto";

@Injectable({
  providedIn: 'root'
})
export class CityService {
  API_URL: string = "api/City";

  constructor(private httpClient: HttpClient) { }

  getCities() {
    return this.httpClient.get(this.API_URL);
  }

  getCity(cityId) {
    return this.httpClient.get(`${this.API_URL}/${cityId}`);
  }

  createCity(city: CityDto) {
    return this.httpClient.post(this.API_URL, city);
  }

  updateCity(cityId: string, city: CityDto) {
    return this.httpClient.put(`${this.API_URL}/${cityId}`, city);
  }

  deleteCity(cityId) {
    return this.httpClient.delete(`${this.API_URL}/${cityId}`);
  }
}
