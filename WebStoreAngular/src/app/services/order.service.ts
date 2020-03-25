import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { OrderDetails } from '../models/orderdetails-model';

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  constructor(private http: HttpClient) { }
  readonly apiUrl = "http://localhost:63624/api/orders";

  create(details: OrderDetails[]){
    this.http.post(this.apiUrl, details);
  }

  getOrder(id: number): Observable<OrderDetails[]> {
    return this.http.get<OrderDetails[]>(this.apiUrl + '/' + id);
  }
}