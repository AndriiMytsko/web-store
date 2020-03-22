import { Component, OnInit } from '@angular/core';

import { Product } from 'src/app/models/product-model';
import { ProductService } from 'src/app/services/product.service';
import { Router } from '@angular/router';
import { CartService } from 'src/app/services/cart.service';

@Component({
  selector: 'app-top-products',
  templateUrl: './top-products.component.html',
  styleUrls: ['./top-products.component.css']
})
export class TopProductsComponent implements OnInit {
  products: Product[]

  constructor(
    private service: ProductService,
    public cartService: CartService,
    private router: Router) { }


  ngOnInit() : void{
    this.service.getTopProducts().subscribe(products => {
      this.products = products;
    });
  }

  product: Product;
  
  prodDetails(id: number){
     this.router.navigate(['/product', id]);
  }

  addToCart(id: number) {
    this.cartService.addToCart(id);
  }
}