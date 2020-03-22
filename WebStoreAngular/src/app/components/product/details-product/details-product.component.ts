import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Product } from 'src/app/models/product-model';
import { ProductService } from 'src/app/services/product.service';

@Component({
  selector: 'app-details-product',
  templateUrl: './details-product.component.html',
  styleUrls: ['./details-product.component.css']
})

export class DetailsProductComponent implements OnInit {
  id: number;
  prod: Product;

  constructor(private route: ActivatedRoute,
    private productservice: ProductService) { }

  ngOnInit() {
    this.prod = new Product();

    this.id = this.route.snapshot.params['id'];
    this.productservice.getProduct(this.id)
      .subscribe(prod => this.prod = prod);
  }
}
