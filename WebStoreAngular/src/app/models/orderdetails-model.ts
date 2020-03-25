import { Product } from './product-model';

export class OrderDetails {
    public product: Product;
    public quantity: number;

    constructor(product: Product) {
        this.product = product;
    }
}