import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Produto } from '../models/produtos.models';

@Component({
  selector: 'app-produtos',
  templateUrl: './produtos.component.html',
  styleUrls: ['./produtos.component.css']
})
export class ProdutosComponent implements OnInit {
  _http: HttpClient;
  listaProdutos: Produto[] = [];
  adicionarProduto: Produto = new Produto;
  constructor(http: HttpClient) {
    this._http = http;
    this.atualizarListagem();

  }
  atualizarListagem(): void {
    this._http.get<Produto[]>('https://localhost:44377/produto').subscribe(result => {
      this.listaProdutos = result;
    }, error => console.error(error));

  }
  enviarProduto(): void {
    this._http.post<Produto>('https://localhost:44377/produto', this.adicionarProduto).subscribe(result => {
      console.log(result);
      alert("Produto Inserido!")
    }, error => console.error(error));
    this.adicionarProduto = new Produto();
  }
  

  ngOnInit(): void {
  }

}
