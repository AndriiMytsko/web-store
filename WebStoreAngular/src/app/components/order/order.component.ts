import { Component, OnInit } from '@angular/core';
import { CartService } from 'src/app/services/cart.service';
import { Product } from 'src/app/models/product-model';
import { OrderService } from 'src/app/services/order.service';
import { OrderDetails } from 'src/app/models/orderdetails-model';

@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.css']
})
export class OrderComponent implements OnInit {
  details: OrderDetails[];
  products: Product[];

  constructor(
    private cartService: CartService,
    private orderService: OrderService) { }

  ngOnInit() {
    this.cartService.getProducts()
      .subscribe(products => { this.products = products;
                 this.createDetails()
      });
  }

  createDetails() {
    this.details = this.products.map(product => new OrderDetails(product));
  }

  create() {
    this.orderService.create(this.details);
  }
}
