import { Component, OnInit, Inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router, ActivatedRoute} from "@angular/router"
import { Observable } from 'rxjs';
import { tap } from 'rxjs/operators';
import { Country } from "../country";
import { City } from "../city";
import { CityService } from "../city.service";
import { CountryService } from "../country.service";
import { CityDto } from "../cityDto";

@Component({
   selector: 'app-city-create',
   templateUrl: '../form/city-form.component.html'
})
export class CityEditComponent implements OnInit {
  private cityForm: FormGroup;
  private submitted = false;
  private countries: Country[];
  private pageHeading = "Izmjena grada";
  private mode = 2;
  private city: Observable<City>;
  private cityId: string;

  constructor(private formBuilder: FormBuilder,
    private cityService: CityService,
    private countryService: CountryService,
    private router: Router,
    private route: ActivatedRoute) {
    this.cityId = this.route.snapshot.paramMap.get('id');

    this.countryService.getCountries().subscribe((result: Country[]) => {
      this.countries = result;
    }, error => console.error(error));

    this.city = this.cityService.getCity(this.cityId).pipe(
      tap((city: City) => this.cityForm.patchValue(city)));
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

    this.cityService.updateCity(this.cityId, this.map).subscribe(result => {
      this.router.navigate(['/city-index']);
    }, error => console.error(error));
  }
}
