//BUSCA POR NÚMEROS ÍMPARES
/*int numero;

System.Console.WriteLine("Lista dos 100 primeiros números ímpares");

for (numero = 1; numero <= 100; numero++)
{
    if (numero % 2 == 1)
    System.Console.WriteLine(numero);
}
Console.ReadKey();*/




//BUSCA POR NÚMEROS PRIMOS
/*int numero, divisor;
bool primo;
System.Console.WriteLine("Lista dos 100 primeiros números primos");
System.Console.WriteLine(2);

for (numero = 3; numero <= 100; numero++)
{
    primo = true;
    
    for (divisor = 2; divisor < numero; divisor++)
    {
        if (numero % divisor == 0)
        {
            primo=false;
            break;
        }
    }

    if (primo)
    {
        System.Console.WriteLine(numero);
    }
    
}
Console.ReadKey();*/





//FUNÇÕES DE CONVERSÃO
/*int numero;
float decimalNumber;
string literal;

numero = 100;
decimalNumber = 18.50f;

literal = "" + numero;
System.Console.WriteLine(numero + " => " + literal);

literal = "" + decimalNumber;
System.Console.WriteLine(decimalNumber + " => " + literal);

decimalNumber = float.Parse(literal);
System.Console.WriteLine(literal + " => " + decimalNumber);

Console.ReadKey();*/






//CONCATENAÇÃO
/*int numero;
char letra;
string frase;

frase = "INÍCIO: ";

for (numero = 0; numero <= 5; numero++)
{
    frase = frase + numero;
}
System.Console.WriteLine(frase);

for (letra = 'A'; letra <= 'E'; letra++)
{
    frase = frase + letra;
}
System.Console.WriteLine(frase);

Console.ReadKey();*/






//TRABALHANDO COM STRINGS

/*int index, qtdeCaracteres;
char letra;
string palavra;

palavra = "ALGORITMO";
qtdeCaracteres = palavra.Length;

for (index = 0; index < qtdeCaracteres; index++)
{ 
    letra = palavra[index];
    System.Console.WriteLine(letra);
}

Console.ReadKey();*/