using System.Runtime.CompilerServices;
/*
// Usando "caracteres" nas variável
Console.Write("Olá, qual o seu nome? ");
string nome = Console.ReadLine();
Console.WriteLine("Prazer " +  nome + " tudo bem? Me informe seu CPF pra mim testar um negócio: ");

string cpf = Console.ReadLine();

Console.Write("Hmmm, me informe seu número do telefone pra eu ver aqui no meu sistema umas coisas: ");
string numero = Console.ReadLine();

// Usando "números" nas variável
Console.Write("Massa demais, qual curso que você está fazendo atualmente em? ");
string curso  = Console.ReadLine();

Console.Write("Certo " + nome + " Me informe também quantas horas por dia será o seu curso: ");
double cursoHoras = Convert.ToDouble(Console.ReadLine());

Console.Write("Também me informe quantos dias serão o seu curso: ");
int diasCurso = Convert.ToInt32(Console.ReadLine());

Console.Write("Certo. " + nome +  " O seu curso será no total: " + cursoHoras * diasCurso + " Horas");
*/


//Console.ReadLine - Ler o valor digitado pelo o usuário
//Console.ToDouble - Converter um valor para tipo double

Console.WriteLine("Digite o comprimento do terreno: ");
double comprimento = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a largura do terreno: ");
double largura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Largura: " + largura);
Console.WriteLine("Comprimento " + comprimento);

double area = comprimento * largura;
Console.WriteLine("Área: " + area);

//Calcule o perímetro
double perimetro = 2 * (comprimento + largura);
Console.WriteLine("perímetro: " + perimetro);

//Calcular o preço do terreno
//Considere que cada m vale R$100
double preco_metros_quadrado = 100;
double valor = area * preco_metros_quadrado;
Console.WriteLine("Valor do terreno: " + valor);