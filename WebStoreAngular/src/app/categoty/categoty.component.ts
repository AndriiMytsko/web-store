import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Product } from 'src/app/models/product-model';
import { CategoryService } from 'src/app/services/category.service';

@Component({
  selector: 'app-categoty',
  templateUrl: './categoty.component.html',
  styleUrls: ['./categoty.component.css']
})
export class CategotyComponent implements OnInit {

  id: number;
  products: Product[];

  constructor(private route: ActivatedRoute,private router: Router,
    private categoryService: CategoryService) { }

    ngOnInit() {
      this.id = this.route.snapshot.params['id'];
      this.categoryService.getProductsByCategory(this.id)
        .subscribe(products => this.products = products);
    }
}
