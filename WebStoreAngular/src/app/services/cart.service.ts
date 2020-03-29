import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { Product } from '../models/product-model';
import { ProductService } from './product.service';

@Injectable({
  providedIn: 'root'
})
export class CartService {
  private ids = [];

  constructor(private productService: ProductService) { }

   private productsSource = new BehaviorSubject<Observable<Product[]>>(this.getProducts());
   public currentProductList = this.productsSource;

  public addToCart(id: number) {
    this.ids.push(id);
    let strIds = this.ids.join();
    localStorage.setItem('productIds', strIds);
    window.alert('Your product has been added to the cart!');
  }

  public removeProductId(id: number) {
    let productsIds = localStorage.getItem('productIds');
    let strIds = productsIds.replace(id.toString(), '');
    localStorage.setItem('productIds', strIds);
  }

  public getProducts(): Observable<Product[]> {
    let productsIds = localStorage.getItem('productIds');
    if(productsIds != null)
    {
      let ids = productsIds.split(',').map(id => Number(id));
      return this.productService.getProductsByIds(ids);
    }
  }
}
