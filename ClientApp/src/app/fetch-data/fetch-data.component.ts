import { Component, Inject, Input } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public result: Number;

  @Input()
    unitOfTime: string;
  http: HttpClient;
  baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;
  }

  ngOnInit(): void {
    debugger;
    let params = new HttpParams().set('unitOfTime', this.unitOfTime);
    this.http.get<Number>(this.baseUrl + 'travel', { params: params }).subscribe(result => {
      this.result = result;
    }, error => console.error(error));
  }

}
