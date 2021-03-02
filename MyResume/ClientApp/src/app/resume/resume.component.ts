import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-resume',
  templateUrl: './resume.component.html'
})
export class ResumeComponent {
  public person: Person;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Person>(baseUrl + 'api' + '/' + 'person').subscribe(result => {
      this.person = result;
    }, error => console.error(error));
  }
}

//interface WeatherForecast {
//  date: string;
//  temperatureC: number;
//  temperatureF: number;
//  summary: string;
//}

interface Person {
  name: string;
  title: string;
  phoneNumber: string;
  address: string;
}
