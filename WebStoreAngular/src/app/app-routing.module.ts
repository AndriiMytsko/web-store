import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DetailsProductComponent } from 'src/app/product/details-product/details-product.component';
import {HomeComponent } from 'src/app/home/home.component'; 
import { NotFoundComponent } from 'src/app/not-found/not-found.component'; 
import { CategotyComponent } from './categoty/categoty.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'product/:id', component: DetailsProductComponent },
  { path: 'categories/:id/products', component: CategotyComponent },
  { path: '**', component: NotFoundComponent },
  { path: '**', redirectTo: '/' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
