//LAÇOS DE REPETIÇÃO
//Uso do for

/*int valor;
for (int valor = 1; valor <= 10; valor++) {
    Console.WriteLine(valor);
}*/




//Tabuada do 7
/*int valor;

for (valor = 1; valor <= 10; valor ++) {
    System.Console.WriteLine(valor * 7);
}
Console.ReadKey();*/




//Tabuada definida pelo usuário
/*int valor;
int valor_informado;

System.Console.WriteLine("Informe o múltiplo: ");
valor_informado = int.Parse(Console.ReadLine());

for (valor = 1; valor <=  10; valor++) {
    System.Console.WriteLine(valor * valor_informado);
}
Console.ReadKey();*/




//Todas as tabuadas
int valor1;
int valor2;

for (valor1 = 1; valor1 <= 10; valor1++) {
    for (valor2 = 1; valor2 <= 10; valor2++) {
        System.Console.WriteLine(valor1 * valor2 + " ");
    }

    System.Console.WriteLine();
}
Console.ReadKey();
