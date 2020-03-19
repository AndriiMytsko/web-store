import * as platformBrowser from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { MatMenuModule } from '@angular/material/menu';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';

import {MatTableModule} from '@angular/material/table';
import {MatButtonModule} from '@angular/material/button';
import {MatIconModule} from '@angular/material/icon';
import {MatCardModule} from '@angular/material/card';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatInputModule} from '@angular/material/input';
import { MatSliderModule } from '@angular/material/slider';
import { CategotyComponent } from './components/categoty/categoty.component';
import { ShowCategoryComponent } from './components/categoty/show-category/show-category.component';
import { EditCategoryComponent } from './components/categoty/edit-category/edit-category.component';
import { AddCategoryComponent } from './components/categoty/add-category/add-category.component';
import { ProductComponent } from './components/product/product.component';
import { EditProductComponent } from './components/product/edit-product/edit-product.component';
import { AddProductComponent } from './components/product/add-product/add-product.component';
import { MainNavComponent } from './components/main-nav/main-nav.component';
import { LayoutModule } from '@angular/cdk/layout';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatListModule } from '@angular/material/list';
import {CategoryService} from 'src/app/services/category.service';
import {ProductService} from 'src/app/services/product.service';
import { FlexLayoutModule } from '@angular/flex-layout';
import { ImagesHomeComponent } from './components/images-home/images-home.component';
import { DetailsProductComponent } from './components/product/details-product/details-product.component';
import { HomeComponent } from './components/home/home.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { ProductListComponent } from './components/product/product-list/product-list.component';
import { TopProductsComponent } from './components/top-products/top-products.component';
import { FooterComponent } from './components/footer/footer.component';

@NgModule({
  declarations: [
    AppComponent,
    CategotyComponent,
    ShowCategoryComponent,
    EditCategoryComponent,
    AddCategoryComponent,
    ProductComponent,
    EditProductComponent,
    AddProductComponent,
    MainNavComponent,
    ImagesHomeComponent,
    DetailsProductComponent,
    HomeComponent,
    NotFoundComponent,
    ProductListComponent,
    TopProductsComponent,
    FooterComponent
  ],
  imports: [
    platformBrowser.BrowserModule,
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
