import { Injectable } from '@angular/core';

import { HttpClient } from '@angular/common/http';
import { Product } from 'src/app/models/product-model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor(private http: HttpClient) { }

  readonly apiUrl = "http://localhost:63624/api/products";

  getTopProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(this.apiUrl + '/top-products');
  }

  getProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(this.apiUrl);
  }

  getProduct(id: number): Observable<Product> {
    return this.http.get<Product>(this.apiUrl + '/' + id);
  }

  getProductsByIds(ids: number[]): Observable<Product[]> {
    let idsQuery = ids.map(x => `ids=${x}`).join('&');

    return this.http.get<Product[]>(this.apiUrl + `?${idsQuery}`);
  }
}
