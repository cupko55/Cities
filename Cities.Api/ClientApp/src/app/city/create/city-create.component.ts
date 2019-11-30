import { Component, OnInit, Inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import {Router} from "@angular/router"
import { Country } from "../country";
import { CountryService } from "../country.service";
import { CityService } from "../city.service";
import { CityDto } from "../cityDto";

@Component({
   selector: 'app-city-create',
   templateUrl: '../form/city-form.component.html'
})
export class CityCreateComponent implements OnInit {
  private cityForm: FormGroup;
  private submitted = false;
  private countries: Country[];
  private pageHeading = "Dodavanje grada";
  private mode = 1;

  constructor(private formBuilder: FormBuilder,
    private countryService: CountryService,
    private cityService: CityService,
    private router: Router) {
    this.countryService.getCountries().subscribe((result: Country[]) => {
      this.countries = result;
    }, error => console.error(error));
  }

  ngOnInit() {
    this.cityForm = this.formBuilder.group({
      name: ['', Validators.required],
      zip: ['', Validators.required],
      countryId: ['', Validators.required]
    });
  }
  
  get f() { return this.cityForm.controls; }

  get map() {
    var city = new CityDto();
    city.id = 0;
    city.name = this.f.name.value;
    city.zip = this.f.zip.value;
    city.countryId = this.f.countryId.value;
    
    return city;
  }

  onSubmit() {
    this.submitted = true;
    
    if (this.cityForm.invalid) {
      return;
    }
    
    console.log(this.map);
    this.cityService.createCity(this.map).subscribe(result => {
      this.router.navigate(['/city-index']);
    }, error => console.error(error));
  }
}
