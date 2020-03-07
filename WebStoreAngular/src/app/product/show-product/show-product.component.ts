import { Component, OnInit } from '@angular/core';

import { Product } from 'src/app/models/product-model';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-show-product',
  templateUrl: './show-product.component.html',
  styleUrls: ['./show-product.component.css']
})
export class ShowProductComponent implements OnInit {

  constructor(private service: ProductService) { }

  products: Product[]

  ngOnInit() : void{
    this.refreshProducts();
  }

  refreshProducts(){
    this.service.getProducts().subscribe(products => this.products = products);
  }
}
