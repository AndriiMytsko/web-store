import { Component, OnInit } from '@angular/core';
import { ProductService } from 'src/app/services/product.service';
import { CartService } from 'src/app/services/cart.service';
import { Product } from 'src/app/models/product-model';
import { OrderService } from 'src/app/services/order.service';

@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.css']
})
export class OrderComponent implements OnInit {
  ids: number[];
  products: Product[];

  constructor(
    private cartService: CartService,
    private service: ProductService,
    private orderService: OrderService
  ) { }

  ngOnInit() {
    this.ids = this.cartService.getProductIds();
    this.service.getProductsByIds(this.ids)
      .subscribe(products => { this.products = products; })
  }

  create() {
      debugger;
    this.orderService.create(this.ids);
  }
}
