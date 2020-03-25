import { Component, OnInit } from '@angular/core';

import { Category } from 'src/app/models/category-model';
import { CategoryService } from 'src/app/services/category.service';

import { Router } from '@angular/router';

@Component({
  selector: 'app-show-category',
  templateUrl: './show-category.component.html',
  styleUrls: ['./show-category.component.css']
})
export class ShowCategoryComponent implements OnInit {

  constructor(private service: CategoryService,
    private router: Router) { }

  categories: Category[];

  ngOnInit() : void{
    this.service.getCategories().subscribe(categories => this.categories = categories);  }    

    productsByCategory(id: number){
      this.router.navigate(['/categories/' + id + '/products']);
    }
}
