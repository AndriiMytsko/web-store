import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  constructor(private http: HttpClient) { }

  readonly apiUrl = "http://localhost:63624/api/orders";

  create(ids: number[]){
    let idsQuery = ids.map(x => `ids=${x}`).join('&');
    this.http.post(this.apiUrl, `?${idsQuery}`)
      .subscribe();
  }

}
