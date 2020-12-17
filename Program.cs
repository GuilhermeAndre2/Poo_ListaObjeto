using System;
using System.Collections.Generic;
using POO_Objetos.classes;

namespace POO_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando a lista
            List<Produto> produtos = new List<Produto>();

            // Adicionando produtos atraves de instancias com construtores
            produtos.Add(new Produto(1, "Apple Watch", 3522.56f));
            produtos.Add(new Produto(2, "Xiaomi Watch", 1522.45f));
            produtos.Add(new Produto(3, "Zenfone ASUS", 2522.87f));
            produtos.Add(new Produto(4, "Samsung", 2522.87f));
            produtos.Add(new Produto(5, "Motorola G8", 2522.87f));

            // Outra forma de adicionar produtos a lista
            Produto iphone = new Produto();
            iphone.Codigo = 6;
            iphone.Nome = "Iphone XII";
            iphone.Preco = 8952.45f;

            produtos.Add(iphone);

            //Mostrar produtos com foreach
            foreach (Produto p1 in produtos)
            {
                Console.WriteLine($"{p1.Nome} - R${p1.Preco}");
            }

            //Para remover o produto é so fazer:
            produtos.RemoveAt(4);

            //Tambem é possivel fazer com RemoveAll:
            produtos.RemoveAll(x => x.Codigo == 5);

            Console.WriteLine("\nLista Alterada: ");
            //Pra ver o que foi removido

            foreach (Produto p1 in produtos)
            {
                Console.WriteLine($"{p1.Nome} - R${p1.Preco}");
            }

        }
    }
}
