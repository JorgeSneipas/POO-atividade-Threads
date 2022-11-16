// See https://aka.ms/new-console-template for more information
using atividade.Models;

Console.WriteLine("Aluno: Jorge Luiz Dourado Dobkovski (SI)");
Console.WriteLine("Iniciando aplicação . . .");

Admin admin1 = new Admin("Manoel Gomes", "canetaazulofc", "ocanetaazul@gmail.com");
Usuario cli1 = new Cliente("Naruto da Silva Joestar", "narutopvh", "joestarna@gmail.com");
Usuario cli2 = new Cliente("Lucas Gonçalves", "proflucas", "lucasprof@gmail.com");

admin1.CriarThread();
cli1.CriarThread();
cli2.CriarThread();
cli1.EditarThread("narutobr");
cli1.EditarThread("narutopvh");
cli1.ExcluirThread("narutopvh");
admin1.FornecerAcesso(cli2);
cli2.ExcluirThread("joaozinho");

Console.ReadLine();

