using Csharp.Models;

//cast - casting

int z = Convert.ToInt32("4"); //convertendo uma string para um int com Convert
Console.WriteLine(z);

int y = int.Parse("90"); //convertendo com Parse
Console.WriteLine(y);

//convert retorna zero quando o valor é nulo
//parse retorna erro quando o valor é nulo

//convertendo para string
int inteiro = 5;
string x = inteiro.ToString();//fazer o caminho de int para string não se pode usar Parse e o Convert é redundante 
Console.WriteLine(x);

//casting implicito 
int f = 5;
double i = f; //nesse caso o int cabe dentro do double
Console.WriteLine(f);

//convertendo de maneira segura
string h = "15-";
int.TryParse(h, out int j);

Console.WriteLine(j);


//atribuição de valor

int a = 10;
int b = 20;
int c = a + b;

c = c + 5;

//vai pegar a propria variavel e somar com o valor passado apos a igualdade
c += 5; 

Console.WriteLine(c);


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


