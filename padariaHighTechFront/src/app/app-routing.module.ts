import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CategoriaComponent } from './categorias/categoria.component';
import { ProdutosComponent } from './produtos/produtos.component';
import { ProdutosListComponent } from './produtos/produtos.list.component';

const routes: Routes = [
  { path: 'produtos', component: ProdutosComponent },
  { path: 'produtos/list', component: ProdutosListComponent },
  { path: 'categoria', component: CategoriaComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
