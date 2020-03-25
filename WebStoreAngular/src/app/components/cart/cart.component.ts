import { Component, OnInit } from '@angular/core';
import { CartService } from 'src/app/services/cart.service';
import { Product } from 'src/app/models/product-model';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit {
  products: Product[];

  constructor(
    private cartService: CartService) {
  }

  ngOnInit() {
    this.cartService.getProducts()
      .subscribe(products => { this.products = products });
  }

  deleteProduct(id: number) {
    this.cartService.removeProductId(id);
  }
}
