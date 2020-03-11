import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Product } from 'src/app/models/product-model';
import { ProductService } from 'src/app/services/product.service';
import {Subscription} from 'rxjs';

@Component({
  selector: 'app-details-product',
  templateUrl: './details-product.component.html',
  styleUrls: ['./details-product.component.css']
})
export class DetailsProductComponent implements OnInit {

  id: number;
  private subscription: Subscription;
  constructor(private activateRoute: ActivatedRoute){
       
      this.subscription = activateRoute.params.subscribe(params=>this.id=params['id']);
  }

    ngOnInit() {
    }
}
