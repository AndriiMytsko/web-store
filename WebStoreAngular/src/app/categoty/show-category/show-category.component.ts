import { Component, OnInit } from '@angular/core';

import { Category } from 'src/app/models/category-model';
import { CategoryService } from 'src/app/services/category.service';

@Component({
  selector: 'app-show-category',
  templateUrl: './show-category.component.html',
  styleUrls: ['./show-category.component.css']
})
export class ShowCategoryComponent implements OnInit {

  constructor(private service: CategoryService) { }


  categories: Category[]

  ngOnInit() : void{
    this.service.getCategories().subscribe(categories => this.categories = categories);  }    
}
