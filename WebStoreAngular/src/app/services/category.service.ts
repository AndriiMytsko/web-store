import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Category } from 'src/app/models/category-model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  constructor(private http: HttpClient) { }

  readonly apiUrl = "http://localhost:63624/api/categories";

  getCategories(): Observable<Category[]>{
    return this.http.get<Category[]>(this.apiUrl);
  }
}
