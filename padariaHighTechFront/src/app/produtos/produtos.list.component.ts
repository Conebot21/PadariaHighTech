import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Produto } from '../models/produtos.models';

@Component({
    selector: 'app-produtos-list',
    templateUrl: './produtos.list.component.html',
    styleUrls: ['./produtos.list.component.css']
}) export class ProdutosListComponent implements OnInit {
    _http: HttpClient;
    listaProdutos: Produto[] = [];
    constructor(http: HttpClient) {
        this._http = http;
        this.atualizarListagem();

    }
    atualizarListagem(): void {
        this._http.get<Produto[]>('https://localhost:44377/produto').subscribe(result => {
            this.listaProdutos = result;
        }, error => console.error(error));

    }
    excluir(id: number): void {
        this._http.delete('https://localhost:44377/produto/' + id).subscribe(result => {
          alert("Produto apagado com sucesso!");
        }, error => console.error(error));
      }
      editarProduto(id: number): void {
        this._http.put<Produto>('https://localhost:44377/produto' + id, this.editarProduto).subscribe(result => {
          console.log(result);
          alert("Produto Inserido!")
        }, error => console.error(error));
      
      }


      ngOnInit(): void {
    }
  
  }