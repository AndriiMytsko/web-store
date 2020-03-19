import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute, Params } from '@angular/router';
import { Product } from 'src/app/models/product-model';
import { CategoryService } from 'src/app/services/category.service';

@Component({
  selector: 'app-categoty',
  templateUrl: './categoty.component.html',
  styleUrls: ['./categoty.component.css']
})
export class CategotyComponent implements OnInit {

  products: Product[];

  constructor(private route: ActivatedRoute,private router: Router,
    private categoryService: CategoryService) { }

    ngOnInit() {
      this.route.params.subscribe((params: Params) => {
        this.categoryService.getProductsByCategory(params.id)
          .subscribe(products => this.products = products);
      });      
    }

    prodDetails(id: number){
      this.router.navigate(['/product', id]);
   }
}
