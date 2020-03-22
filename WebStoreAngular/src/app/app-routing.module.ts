import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DetailsProductComponent } from './components/product/details-product/details-product.component';
import {HomeComponent } from './components/home/home.component'; 
import { NotFoundComponent } from './components/not-found/not-found.component'; 
import { CategotyComponent } from './components/categoty/categoty.component';
import { CartComponent } from './components/cart/cart.component';
import { OrderComponent } from './components/order/order.component';


const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'product/:id', component: DetailsProductComponent },
  { path: 'categories/:id/products', component: CategotyComponent },
  { path: 'cart', component: CartComponent },
  { path: 'order', component: OrderComponent },
  { path: '**', component: NotFoundComponent },
  { path: '**', redirectTo: '/' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
