import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CartService {
  private ids = [];

  public addToCart(id: number) {
    this.ids.push(id);

    let strIds = this.ids.join();
    localStorage.setItem('productIds', strIds);
    window.alert('Your product has been added to the cart!');
  }

  public getProductIds() {
    let productsIds = localStorage.getItem('productIds');

    let ids = productsIds.split(',').map(id => Number(id));
    return ids;
  }

  public removeProductId(id: number) {
    let productsIds = localStorage.getItem('productIds');
    let strIds = productsIds.replace(id.toString(), '');
    localStorage.setItem('productIds', strIds);
  }
}
