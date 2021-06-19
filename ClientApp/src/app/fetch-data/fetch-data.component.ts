import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public result: Number;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Number>(baseUrl + 'travel').subscribe(result => {
      this.result = result;
    }, error => console.error(error));
  }
}
