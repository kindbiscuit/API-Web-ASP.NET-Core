using LivrariaDoPepeu.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaDoPepeu.Data
{
    public static class SeedDatabase
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LDPContext(
                serviceProvider.GetRequiredService<DbContextOptions<LDPContext>>()))
            {
                if (context.Product.Any())
                {
                    return;
                }
                //context.Product.Add(new Product { Name = "Duna", Synopse = "Uma estonteante mistura de aventura e misticismo, ecologia e política", Autor = "Frank Herbert", Price = 50 });
                //context.Product.Add(new Product { Name = "O Senhor dos Anéis", Synopse = "O volume inicial de O Senhor dos Anéis, lançado originalmente em julho de 1954, foi o primeiro grande épico de fantasia moderno, conquistando milhões de leitores e se tornando o padrão de referência para todas as outras obras do gênero até hoje.", Autor = "J.R.R. Tolkien", Price = 15 });
                //context.Product.Add(new Product { Name = "O Fim da Eternidade", Synopse = "De forma leve e bem-humorada, Asimov realiza questionamentos ainda bastante contemporâneos, como o comodismo do ser humano, sua evolução perante as outras espécies e a busca incessante do controle sobre a vida dos outros. ", Autor = "Isaac Asimov", Price = 40 });
                //context.Product.Add(new Product { Name = "O Fim da Infância", Synopse = "Nos primeiros anos da Guerra Fria, uma raça tecnologicamente superior ao homem desce dos céus para governar a Terra.", Autor = "Arthur C. Clarke", Price = 30 });
                //context.Product.Add(new Product { Name = "Laranja Mecânica", Synopse = "Uma das mais brilhantes sátiras distópicas já escritas, Laranja Mecânica ganhou fama ao ser adaptado em uma obra magistral do cinema pelas mãos de Stanley Kubrick. ", Autor = "Anthony Burgess", Price = 25 });
                //context.Product.Add(new Product { Name = "Admirável mundo novo", Synopse = "Um clássico moderno, o romance distópico de Aldous Huxley é incontornável para quem procura um dos exemplos mais marcantes da tematização de estados autoritários, ao lado de 1984, de George Orwell. ", Autor = " Aldous Leonard Huxley ", Price = 40 });
                //context.Product.Add(new Product { Name = "A revolução dos bichos", Synopse = "Verdadeiro clássico moderno, concebido por um dos mais influentes escritores do século XX, A revolução dos bichos é uma fábula sobre o poder.", Autor = " George Orwell", Price = 39 });
                //context.Product.Add(new Product { Name = "1984", Synopse = "Publicada originalmente em 1949, a distopia futurista 1984 é um dos romances mais influentes do século XX, um inquestionável clássico moderno.", Autor = "George Orwell", Price = 66 });
                //context.Product.Add(new Product { Name = "O conto da aia", Synopse = "O romance distópico O conto da aia, de Margaret Atwood, se passa num futuro muito próximo e tem como cenário uma república onde não existem mais jornais, revistas, livros nem filmes. ", Price = 16 });
                //context.Product.Add(new Product { Name = "Eu, Robô", Synopse = "Um dos maiores clássicos da literatura de ficção científica, Eu, Robô, escrito pelo Bom Doutor, Isaac Asimov foi publicado originalmente em 1950.", Autor = "Isaac Asimov", Price = 54 });


                context.SaveChanges();
            }
        }
    }
}
