using Csharp.Models;

//OPERADORES ARITMÉTICOS E A CLASSE MATH
Calculadora calc = new Calculadora();

calc.Somar(10, 26);
calc.Subtrair(20, 12);
calc.Multiplicar(3, 20);
calc.Dividir(24, 2);
calc.Potencia(3, 3);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);

//incrementando

int numero = 10;
Console.WriteLine(numero);
numero = numero + 1;
Console.WriteLine(numero);
numero++;
Console.WriteLine(numero);

//decremento
numero--;
Console.WriteLine(numero);

//raiz quadrada

calc.RaizQuadrada(9);

//OPERADORES

int quantidadeEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEstoque >+ quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");


if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda invalida");
}
//IF ANINHADO adicionar uma condição de verificação a mais
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade em estoque.");
}

//SWITCH CASE

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    
    default:
        Console.WriteLine("Não é uma vogal");
        break;
}

//CAST - CASTING 

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


//ATRIBUIÇÃO DE VALOR

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


//VARIAVEIS

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


//SINTAXE
//CRIANDO E UTILIZANDO DADOS
Pessoa p = new Pessoa();

p.Nome = "Eudes";
p.Age = 27;
p.Presentation();

Pessoa p2 = new Pessoa();
p2.Nome = "Gal";
p2.Age = 12;
p2.Presentation();


