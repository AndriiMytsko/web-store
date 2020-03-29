import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { OrderDetails } from "../models/orderdetails-model";
import { Order } from '../models/order-model';

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  constructor(private http: HttpClient) { }
  readonly apiUrl = "http://localhost:63624/api/orders";

  create(details: OrderDetails[]): Observable<OrderDetails[]> {
    debugger;
    return this.http.post<OrderDetails[]>(this.apiUrl, details);
  }

  getOrderDetails(id: number): Observable<OrderDetails[]> {
    return this.http.get<OrderDetails[]>(this.apiUrl + '/' + id + '/details');
  }

  getOrders(): Observable<Order[]> {
    return this.http.get<Order[]>(this.apiUrl);
  }
}