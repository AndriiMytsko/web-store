import { Component, OnInit } from '@angular/core';
import { OrderService } from 'src/app/services/order.service';
import { OrderDetails } from 'src/app/models/orderdetails-model';
import { Order } from 'src/app/models/order-model';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {
  id: number;
  orderDetails: OrderDetails[];
  orders: Order[];
  constructor(private orderService: OrderService) { }

  ngOnInit() {
    this.orderService.getOrderDetails(24)
      .subscribe(orderDetails => this.orderDetails = orderDetails);
  }

  getOrders()
  {
    this.orderService.getOrders()
      .subscribe(orders => this.orders = orders);
  }
}
