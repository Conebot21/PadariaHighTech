import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Categoria } from '../models/categorias.models';

@Component({
  selector: 'app-categoria',
  templateUrl: './categoria.component.html',
  styleUrls: ['./categoria.component.css']
})
export class CategoriaComponent implements OnInit {
  _http: HttpClient;
  listaCategorias: Categoria[] = [];
  adicionarCategoria: Categoria = new Categoria;
  constructor(http: HttpClient) {
    this._http = http;
    this.atualizarListagem();

  }
  atualizarListagem(): void {
    this._http.get<Categoria[]>('https://localhost:44377/categoria').subscribe(result => {
      this.listaCategorias = result;
    }, error => console.error(error));

  }
  enviarCategoria(): void {
    this._http.post<Categoria>('https://localhost:44377/categoria', this.adicionarCategoria).subscribe(result => {
      console.log(result);
      alert("Categoria Inserido!")
    }, error => console.error(error));
    this.adicionarCategoria = new Categoria();
  }
  excluir(id: number): void {
    this._http.delete('https://localhost:44377/categoria/' + id).subscribe(result => {
      alert("Categoria apagado com sucesso!");
    }, error => console.error(error));
 }
 editar(id: number): void {
  
 }
  ngOnInit(): void {
  }
}
