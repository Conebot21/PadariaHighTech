using Negocio.Entidades;
using Negocio.Infra;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PadariaHighTechDbContext meuBanco = new PadariaHighTechDbContext();

            /*Produto novoProduto = new Produto();
            novoProduto.Nome = "Cuca";
            novoProduto.Descricao = "Feita de trigo e especiarias tradicionais do Alto Vale";

            Produto novoProduto2 = new Produto();
            novoProduto2.Nome = "Pão Francês";
            novoProduto2.Descricao = "Mais conhecido como pãozinho ou cacetinho (no RS)";

            Produto novoProduto3 = new Produto();
            novoProduto3.Nome = "Leite Integral";
            novoProduto3.Descricao = "Vem da vaca";

            meuBanco.Produtos.Add(novoProduto);
            meuBanco.Produtos.Add(novoProduto2);
            meuBanco.Produtos.Add(novoProduto3);
            meuBanco.SaveChanges();

            Categoria novaCategoria = new Categoria();
            novaCategoria.Nome = "Panificacao";

            Categoria novaCategoria2 = new Categoria();
            novaCategoria2.Nome = "Mercearia";

            
            meuBanco.Categorias.Add(novaCategoria);
            meuBanco.Categorias.Add(novaCategoria2);
            meuBanco.SaveChanges();*/


            //Produto produtoSelecionado = meuBanco.Produtos.Find(2);
            //List<Produto> lista = meuBanco.Produtos.Where(wh => wh.Nome.Contains("a")).ToList();
            //foreach (var produto in lista)
            //{

            //}

            //Console.WriteLine(produtoSelecionado.Nome);
            //Console.WriteLine(produtoSelecionado.Descricao);

            //foreach (var produto in meuBanco.Produtos)
            //{
            //    Console.WriteLine(produto.Nome);
            //    Console.WriteLine(produto.Descricao);
            //}

        }
    }
}
