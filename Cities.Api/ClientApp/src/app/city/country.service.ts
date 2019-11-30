import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class CountryService {
  API_URL: string = "api/Country";

  constructor(private httpClient: HttpClient) { }

  getCountries() {
    return this.httpClient.get(this.API_URL);
  }
}
