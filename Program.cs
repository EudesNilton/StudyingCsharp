using Csharp.Models;

//DateTime

DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));


//variaveis

string apresentacao = "Olá, seja bem vindo";
int quantidade = 1;
double altura = 1.70;
decimal preco = 1.99M;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("valor da variável quantidade: " + quantidade);
Console.WriteLine("valor da variável altura: " + altura.ToString("0.00"));
Console.WriteLine("valor da variável preco: " + preco);
Console.WriteLine("valor da variável condicao: " + condicao);


//sintaxe
// criando dados e utilizando os dados
Pessoa p = new Pessoa();

p.Nome = "Eudes";
p.Age = 27;
p.Presentation();

Pessoa p2 = new Pessoa();
p2.Nome = "Gal";
p2.Age = 12;
p2.Presentation();


