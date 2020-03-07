import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/models/product-model';
import { ProductService } from 'src/app/services/product.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-products-list',
  templateUrl: './products-list.component.html',
  styleUrls: ['./products-list.component.css']
})
export class ProductsListComponent implements OnInit {
  products: Product[]

  constructor(private service: ProductService,
    private router: Router) { }


  ngOnInit() : void{
    this.service.getProducts().subscribe(products => this.products = products);
  }

  onEdit(product: Product){
    console.log(product)
  }

  product: Product;
  
  prodDetails(id: number){
    window.location.href = '/details/3';
    //this.router.navigate(['/details', id]);
  }
}
