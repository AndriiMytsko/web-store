import { Component, OnInit } from '@angular/core';

import { Product } from 'src/app/models/product-model';
import { ProductService } from 'src/app/services/product.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-top-products',
  templateUrl: './top-products.component.html',
  styleUrls: ['./top-products.component.css']
})
export class TopProductsComponent implements OnInit {
  products: Product[]

  constructor(private service: ProductService,
    private router: Router) { }


  ngOnInit() : void{
    this.service.getTopProducts().subscribe(products => this.products = products);
  }

  onEdit(product: Product){
    console.log(product)
  }

  product: Product;
  
  prodDetails(id: number){
     this.router.navigate(['/product', id]);
  }
}
