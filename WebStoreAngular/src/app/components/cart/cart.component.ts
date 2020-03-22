import { Component, OnInit } from '@angular/core';
import { CartService } from 'src/app/services/cart.service';
import { ProductService } from 'src/app/services/product.service';
import { Product } from 'src/app/models/product-model';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit {

  ids: number[];
  products: Product[];

  constructor(
    private cartService: CartService,
    private service: ProductService,
    private route: ActivatedRoute,
  ) {
  }

  ngOnInit() {
    this.ids = this.cartService.getProductIds();
    this.service.getProductsByIds(this.ids)
      .subscribe(products => { this.products = products; })
  }


  deleteProduct(id: number) {
    this.cartService.removeProductId(id);
  }

  // rows = [];
  // columns = [
  //   { prop: 'id' },
  //   { name: 'name' },
  //   { name: 'price' }
  // ];
}
