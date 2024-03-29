//Desvio condicional

/*float valor1, valor2;

System.Console.WriteLine("Informe o primeiro valor:");
valor1 = float.Parse(Console.ReadLine());

System.Console.WriteLine("Informe o segundo valor");
valor2 = float.Parse(Console.ReadLine());

if (valor1 <= valor2){
    System.Console.WriteLine("O primeiro valor é menor/igual ao segundo valor");
}
else {
    System.Console.WriteLine("O primeiro valor é maior que o segundo valor");
}
Console.ReadKey();*/




//Desvio condicional exemplo 2

/*float valor3, valor4;
bool diferenteZero;

System.Console.WriteLine("Informe o primeiro valor");
valor3 = float.Parse(Console.ReadLine());

System.Console.WriteLine("Informe o segundo valor");
valor4 = float.Parse(Console.ReadLine());

System.Console.WriteLine("O segundo valor é zero? (true/false)");
diferenteZero = bool.Parse(Console.ReadLine());

if (valor3 != valor4 && !diferenteZero) {
    System.Console.WriteLine("Os valores não são os mesmos, e diferentes de zero");
}
System.Console.WriteLine("O programa será encerrado");
Console.ReadKey();*/




//Desvio condicional SELECIONA

/*int numero;
char letra;
string respostaNumero, respostaLetra ="";

System.Console.WriteLine("Informe um número entre 1 e 5");
numero = int.Parse(Console.ReadLine());

System.Console.WriteLine("Informe uma letra entre A e D");
letra = char.Parse(Console.ReadLine());

switch (numero)
{
    case 1:
    respostaNumero = "Um";
    break;
    case 2:
    respostaNumero = "Dois";
    break;
    case 3:
    respostaNumero = "Três";
    break;
    case 4:
    respostaNumero = "Quatro";
    break;
    case 5:
    respostaNumero = "Cinco";
    break;
    default: 
    respostaNumero = "Inválido";
    break;
}

switch (letra)
{
    case 'A':
    respostaLetra = "A";
    break;
    case 'B':
    respostaLetra = "B";
    break;
    case 'C':
    respostaLetra = "C";
    break;
    case 'D':
    respostaLetra = "D";
    break;
}

System.Console.WriteLine("Número: "+ respostaNumero);
System.Console.WriteLine("Letra: "+ respostaLetra);

Console.ReadKey();*/





//Estruturas condicionais: Operador ternário
/*int numero;
string parImpar;

System.Console.WriteLine("Informe um número qualquer");
numero =  int.Parse(Console.ReadLine());
parImpar = (numero % 2==0) ? "Par!" : "Ímpar!";

System.Console.WriteLine("O número " + "é " + parImpar);
Console.ReadKey();*/