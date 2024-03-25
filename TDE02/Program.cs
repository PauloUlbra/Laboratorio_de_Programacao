// // Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato : Aluno tem anos e nota usando a concatenação e a interpolação de strings.
//  ----
string nome = "Paulo";
int idade = 17;
double nota = 7.5;


System.Console.WriteLine($"{nome} tem {idade} anos e nota de {nota}");
// ----------
// // Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de
// // escapes.

// // Para qual tipo de dados você pode converter um float implicitamente ?
// // ( ) int
// // (X) double
// // ( ) long
// // (X) decimal 
 

// // Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
// // ( ) int para long
// // (X) double para long
// // (X) double para float
// // (X) decimal para float
// // (X) long para int
// // (X) double para decimal
 
// ----------
// Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando
// a concatenação e também a interpolação de strings
System.Console.WriteLine("Digite a primeira letra:");
char letraUm = Console.ReadLine();
System.Console.WriteLine("Digite a segunda letra:");
char letraDois = Console.ReadLine();
System.Console.WriteLine("Digite a terceira letra:");
char letraTres = Console.ReadLine();

System.Console.WriteLine($"Em ordem inversa, as letras digitadas foram: {letraTres}, {letraDois}, {letraUm}");
// ----------

// Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
// (F) long resultado = 1.32;
// (V) var nome = “Maria”;
// (V) string resultado = 100.ToString();
// (V) A sequência de escape \n inclui uma nova linha
// (F) float f = 5.45;
// (V) decimal valor = (decimal) 10.99f;
// (F) var status = null;
// (V) object o = 12.45m;
// (V) string titulo = true.ToString();
// (F) A sequencia \t inclui uma tabulação vertical

// ----------
// Escreva um programa para receber dois valores via teclado do tipo double e a seguir
// realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo
// exibindo o resultado:
System.Console.WriteLine("Digite o primeiro número: ");
double inputUm = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Digite o segundo número: ");
double inputDois = Convert.ToDouble(Console.ReadLine());

double soma = inputUm + inputDois;
double subtracao = inputUm - inputDois;
double multiplicacao = inputUm * inputDois;
double divisao = inputUm / inputDois;
double modulo = inputUm % inputDois;
System.Console.WriteLine($"Os valores são os seguintes:\nSoma: {soma}\nSubtração: {subtracao}\nMultiplicação: {multiplicacao}\nDivisão: {divisao}\nMódulo: {modulo}\nPotencia: {Math.Pow(inputUm, inputDois)}");

// ----------
// Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
// Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
// então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
// inválido’: (use o operador condicional ternário)
 System.Console.WriteLine("Escreva o seu usuário:");
 string user = Console.ReadLine();
 System.Console.WriteLine("Digite sua senha: ");
 int password = Convert.ToInt32(Console.ReadLine());
 
var condicao = user == "admin" || user == "maria" && password == 123 ? "Login feito com sucesso" : "Login inválido";

System.Console.WriteLine(condicao);

// ----------
// Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
// console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)

System.Console.WriteLine("Digite o primeiro número: ");
int numeroUm = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Digite o segundo número:");
int numeroDois = Convert.ToInt32(Console.ReadLine());

var parOuImpar = numeroUm % 2 == 0 ? $"{numeroUm} é par" : $"{numeroUm} é ímpar";
var parOuImparDois = numeroDois % 2 == 0 ? $"{numeroDois} é par" : $"{numeroDois} é ímpar";

System.Console.WriteLine(parOuImpar + " e " + parOuImparDois);
//----------
