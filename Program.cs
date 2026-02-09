// /////////////1. Entrada, Processamento e Saída

// //Calculadora

// Console.WriteLine("Digite 1 Numero: ");
// double NumeroUm = double.Parse(Console.ReadLine()!);

// Console.WriteLine("Digite 1 Numero: ");
// double NumeroDois = double.Parse(Console.ReadLine()!);

// double Soma = NumeroUm + NumeroDois;
// double Subtracao = NumeroUm - NumeroDois;
// double Multiplicacao = NumeroUm * NumeroDois;
// double Divisao = NumeroUm / NumeroDois;

// Console.WriteLine("Resultadodos!");
// Console.WriteLine($"Soma: {Soma}");
// Console.WriteLine($"Soma: {Subtracao}");
// Console.WriteLine($"Soma: {Multiplicacao}");
// Console.WriteLine($"Soma: {Divisao}");

// //Dobrar, Triplicar

// Console.WriteLine("Digite Um Numero");
// int Num = int.Parse(Console.ReadLine()!);

// int Dobrar = Num * 2;
// int Triplicar = Num * 3;

// Console.WriteLine($"Numero Escolhido: {Num}");
// Console.WriteLine($"Dobro {Dobrar}");
// Console.WriteLine($"Triplo {Triplicar}");

// //Nome Pessoa

// Console.WriteLine("Digite Seu Nome: ");
// string Nome = Console.ReadLine()!;

// Console.WriteLine($"Bom Dia {Nome}");

// //Idade daqui 10 Anos

// Console.WriteLine("Digite Sua IDade: ");
// int Idade = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Sua Idade daqui 10 anos vai ser: {Idade+10}");

///////////////2. Estruturas Condicionais (if / else)

// //Leia um número e informe se ele é par ou ímpar.

// Console.WriteLine("Digite Um Numero");
// int Numero = int.Parse(Console.ReadLine()!);

// if(Numero % 2 == 0)
// {
//     Console.WriteLine($"{Numero} é Par");
// }
// else
// {
//     Console.WriteLine($"{Numero} é Ímpar");
// }

// //Leia dois números e mostre qual é o maior ou informe se são iguais.

// Console.WriteLine("Digite Um Numero");
// int Num1 = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Digite outro Numero");
// int Num2 = int.Parse(Console.ReadLine()!);

// if(Num1 > Num2)
// {
//     Console.WriteLine($"O {Num1} é Maior que {Num2}");
// }
// else if(Num1 < Num2)
// {
//     Console.WriteLine($"O {Num2} é Maior que {Num1}");
// }
// else
// {
//     Console.WriteLine("Eles São Iguais");
// }

//Leia a nota de um aluno e informe se ele está aprovado, em recuperação ou reprovado.

// Console.WriteLine("Digite Uma Nota: ");
// double Nota = double.Parse(Console.ReadLine()!);

// if(Nota >= 7)
// {
//     Console.WriteLine("Voce está Aprovado!");
// }
// else if(Nota > 5 && Nota < 7)
// {
//     Console.WriteLine("Voce está de Recuperação!");
// }
// else
// {
//     Console.WriteLine("Voce Está Reprovado!");
// }

// //Leia a idade de uma pessoa e informe se ela é menor de idade, adulta ou idosa.

// Console.WriteLine("Digite Sua Idade: ");
// int Idade = int.Parse(Console.ReadLine()!);

// if(Idade <= 0)
// {
//     Console.WriteLine("Idade Ivalida!");
// }
// else if(Idade < 18)
// {
//     Console.WriteLine("Voce é menor de idade!");
// }
// else if(Idade >= 18 && Idade < 60)
// {
//     Console.WriteLine("Voce é Adulto!");
// }
// else
// {
//     Console.WriteLine("Voce é Idoso!");
// }

// //Leia um número e informe se ele é positivo, negativo ou zero.

// Console.WriteLine("Digite Um numero: ");
// int numero = int.Parse(Console.ReadLine()!);

// if(numero < 0)
// {
//     Console.WriteLine($"{numero} é Negativo!");
// }
// else if(numero == 0)
// {
//     Console.WriteLine($"{numero} é Zero!");
// }
// else
// {
//     Console.WriteLine($"{numero} é Positivo!");
// }

///////////////3. Estruturas de Repetição (for / while)

// //Mostre os números de 1 a 10 usando um laço.

// for(int i = 1 ; i <= 10; i++)
// {
//     Console.WriteLine(i);
// }

// //Mostre os números pares de 1 a 50.

// for(int i = 1; i <= 50; i++)
// {
//     if(i % 2 == 0)
//     {
//         Console.WriteLine(i);
//     }
// }

// //Leia um número e mostre a tabuada dele.

// Console.WriteLine("Digite Um Numero: ");
// int Numero = int.Parse(Console.ReadLine()!);

// for(int i = 1 ; i <= 10; i++)
// {
//     int Multiplicacao = Numero * i;
//     Console.WriteLine($"{Numero} X {i} = {Multiplicacao}");
// }

// //Leia vários números até que o usuário digite 0 e mostre a soma de todos.

// int Soma = 0;
// bool Continuar = true;
// while (Continuar)
// {
//     Console.WriteLine("digite Um Numero: ");
//     int num = int.Parse(Console.ReadLine()!);

//     Soma = Soma + num;

//     if(num == 0)
//     {
//         Continuar = false;
//     }
// }
// Console.WriteLine($"O Resultado da Soma Final é : {Soma}");

// //Leia 5 números e informe quantos são positivos.

// int Positivos = 0;
// for(int i = 1; i <= 5 ; i++)
// {
//     Console.WriteLine("Digite Um Numero: ");
//     int num = int.Parse(Console.ReadLine()!);

//     if(num > 0)
//     {
//         Positivos++;
//     }
// }
// Console.Write($"Desses 5 Numeros {Positivos} São Positivos!");

///////////////4. Estrutura de Decisão Múltipla (switch / case)

// //Crie um menu com as opções:
// Console.WriteLine("Digite Um Numero: ");
// int Num1 = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Digite Um Numero: ");
// int Num2 = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Escolha Uma das Opções!");
// Console.WriteLine("1 - Soma");
// Console.WriteLine("2 - Subtração");
// Console.WriteLine("3 - Multiplicação");
// Console.WriteLine("4 - Divisao");
// int Resposta = int.Parse(Console.ReadLine()!);

// switch (Resposta)
// {
//     case 1:
//         int Soma = Num1 + Num2;
//         Console.WriteLine($"Soma: {Soma}");
//     break;
//     case 2:
//         int Subtracao = Num1 - Num2;
//         Console.WriteLine($"Subtracao: {Subtracao}");
//     break;
//     case 3:
//         int Multiplicacao = Num1 * Num2;
//         Console.WriteLine($"Multiplicacao: {Multiplicacao}");
//     break;
//     case 4:
//         int Divisao = Num1 / Num2;
//         Console.WriteLine($"Divisao: {Divisao}");
//     break;
//     default:
//         Console.WriteLine("Opção Invalida!");
//     break;
// }

// //Leia um número de 1 a 7 e informe o dia da semana correspondente.

// Console.WriteLine("Digite Um Numero de 1 a 7: ");
// int Num = int.Parse(Console.ReadLine()!);

// switch (Num)
// {
//     case 1:
//         Console.WriteLine("Hoje é Segunda-Feira!");
//     break;
//     case 2:
//         Console.WriteLine("Hoje é Terça-Feira!");
//     break;
//     case 3:
//         Console.WriteLine("Hoje é Quarta-Feira!");
//     break;
//     case 4:
//         Console.WriteLine("Hoje é Quinta-Feira!");
//     break;
//     case 5:
//         Console.WriteLine("Hoje é Sexta-Feira!");
//     break;
//     case 6:
//         Console.WriteLine("Hoje é Sabado!");
//     break;
//     case 7:
//         Console.WriteLine("Hoje é Domingo!");
//     break;
//     default:
//         Console.WriteLine("Opção Invalida!");
//     break;
// }

// //Leia um código de produto e informe a categoria (ex: 1–Alimento, 2–Bebida, 3–Limpeza).

// Console.WriteLine("Digite Um Codigo \n1-Alimento \n2-Bebida\n3-Limpeza");
// int categoria = int.Parse(Console.ReadLine()!);

// switch (categoria)
// {
//     case 1:
//         Console.WriteLine("Opções de Alimento");
//         Console.WriteLine("Arroz");
//         Console.WriteLine("Feijão");
//     break;
//     case 2:
//         Console.WriteLine("Opções de Bebidas");
//         Console.WriteLine("Agua");
//         Console.WriteLine("Refri");
//     break;
//     case 3:
//         Console.WriteLine("Opções de Limpeza");
//         Console.WriteLine("Detergente");
//         Console.WriteLine("Sabão");
//     break;
//     default:
//         Console.WriteLine("Opção Invalida!");
//     break;
// }

// //5. Lógica com Acumuladores e Contadores

// int soma = 0;
// int maiorN = 0;
// double media = 0;

// for(int i = 0 ; i < 10; i++)
// {
//     Console.WriteLine("Digite Um Numero: ");
//     int num = int.Parse(Console.ReadLine()!);

//     soma = soma + num;

//     media = soma/10;

//     if(i == 0)
//     {
//         maiorN = num;
//     }
//     if(num > maiorN)
//     {
//         maiorN = num;
//     }
// }
// Console.WriteLine($"A Soma dos numero é {soma}");
// Console.WriteLine($"A Media dos numero é {media}");
// Console.WriteLine($"O Maior Numero é {maiorN}");

// //Leia idades até que seja digitado um valor negativo e informe a média das idades.
// bool continuar = true;
// int soma = 0;
// double media = 0;
// int contador = 0;

// while (continuar)
// {
//     Console.WriteLine("Digite Uma Idade: ");
//     int idade = int.Parse(Console.ReadLine()!);
//     soma = soma + idade;
//     contador++;
// }
// media = soma / contador;

// Console.WriteLine($"A Media de idades é : {media}");

// //Leia vários números e informe quantos são pares e quantos são ímpares.

// bool continuar = true;
// int contaPar = 0;
// int contaImpar = 0;
// while (continuar)
// {
//     Console.WriteLine("Digite Um Numero");
//     int Numero = int.Parse(Console.ReadLine()!);

//     if (Numero % 2 == 0)
//     {
//         Console.WriteLine($"{Numero} é Par");
//         contaPar++;
//     }
//     else
//     {
//         Console.WriteLine($"{Numero} é Ímpar");
//         contaImpar++;
//     }
    
// }
// Console.WriteLine($"A Quantidade de Numeros Pares é {contaPar} e Impares {contaImpar}");

//6. Desafios de Lógica

//Leia um número e informe se ele é primo.

// Console.Write("Digite um número: ");
// int numero = int.Parse(Console.ReadLine());

// bool primo = true;

// if (numero <= 1)
// {
//     primo = false;
// }
// else
// {
//     for (int i = 2; i <= Math.Sqrt(numero); i++)
//     {
//         if (numero % i == 0)
//         {
//             primo = false;
//             break;
//         }
//     }
// }

// if (primo)
//     Console.WriteLine($"{numero} é um número primo.");
// else
//     Console.WriteLine($"{numero} não é um número primo.");

// //Leia um número e calcule o fatorial.

// int fatorial = 1;
// Console.WriteLine("Digite Um Numero: ");
// int numero = int.Parse(Console.ReadLine()!);

// for(int i = numero; i > 0 ; i--)
// {
//     fatorial = fatorial * i;
// }
// Console.WriteLine($"O fatorial do numero é {fatorial}");

