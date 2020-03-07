import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import {MatMenuModule} from '@angular/material/menu';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http'

import {MatTableModule} from '@angular/material/table';
import {MatButtonModule} from '@angular/material/button';
import {MatIconModule} from '@angular/material/icon';
import {MatCardModule} from '@angular/material/card';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatInputModule} from '@angular/material/input';
import { MatSliderModule } from '@angular/material/slider';
import { CategotyComponent } from './categoty/categoty.component';
import { ShowCategoryComponent } from './categoty/show-category/show-category.component';
import { EditCategoryComponent } from './categoty/edit-category/edit-category.component';
import { AddCategoryComponent } from './categoty/add-category/add-category.component';
import { ProductComponent } from './product/product.component';
import { ShowProductComponent } from './product/show-product/show-product.component';
import { EditProductComponent } from './product/edit-product/edit-product.component';
import { AddProductComponent } from './product/add-product/add-product.component';
import { MainNavComponent } from './main-nav/main-nav.component';
import { LayoutModule } from '@angular/cdk/layout';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatListModule } from '@angular/material/list';
import { ProductsListComponent } from './products-list/products-list.component';
import {CategoryService} from 'src/app/services/category.service';
import {ProductService} from 'src/app/services/product.service';
import { FlexLayoutModule } from '@angular/flex-layout';
import { ImagesHomeComponent } from './images-home/images-home.component';
import { DetailsProductComponent } from './product/details-product/details-product.component';

@NgModule({
  declarations: [
    AppComponent,
    CategotyComponent,
    ShowCategoryComponent,
    EditCategoryComponent,
    AddCategoryComponent,
    ProductComponent,
    ShowProductComponent,
    EditProductComponent,
    AddProductComponent,
    MainNavComponent,
    ProductsListComponent,
    ImagesHomeComponent,
    DetailsProductComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatInputModule,
    MatSliderModule,
    MatMenuModule,
    MatButtonModule,
    LayoutModule,
    MatToolbarModule,
    MatSidenavModule,
    MatIconModule,
    MatListModule,
    MatTableModule,
    MatCardModule,
    FlexLayoutModule,
    HttpClientModule
  ],
  providers: [CategoryService, ProductService],
  bootstrap: [AppComponent]
})
export class AppModule { }
