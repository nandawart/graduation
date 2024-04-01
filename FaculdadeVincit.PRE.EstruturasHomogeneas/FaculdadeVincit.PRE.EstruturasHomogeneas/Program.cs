//USO DE VETORES
/*string[] palavras = new string[5];

palavras[0] = "ALGORITMOS";
palavras[1] = "LÓGICA";
palavras[2] = "COMPUTAÇÃO";
palavras[3] = "ANÁLISE";
palavras[4] = "ESTRUTURADA";

System.Console.WriteLine(palavras[0]);
System.Console.WriteLine(palavras[1]);
System.Console.WriteLine(palavras[2]);
System.Console.WriteLine(palavras[3]);
System.Console.WriteLine(palavras[4]);

Console.ReadKey();*/





//VETORES E LAÇOS
/*int i;
int[] numeros = new int[5];

System.Console.WriteLine("Informe 5 números:");
for (i = 0; i<=4; i++)
{
    System.Console.WriteLine("");
    System.Console.WriteLine(i + " número:");
    numeros[i] = int.Parse(Console.ReadLine());
    numeros[i] = numeros[i] * 10;
}

System.Console.WriteLine("");
System.Console.WriteLine("Multiplicação por 10:");

for (i = 0; i<=4; i++)
{
    System.Console.WriteLine(numeros[i]);
}
Console.ReadKey();*/





//USO DE MATRIZES
/*int[,] matr = new int[3,2];

matr[0,0] = 10;
matr[0,1] = 18;
matr[1,0] = 60;
matr[1,1] = 90;
matr[2,0] = 40;
matr[2,1] = 12;

System.Console.WriteLine("Matriz 3x2:");
System.Console.WriteLine(matr[0,0] + "|" + matr[0,1]);
System.Console.WriteLine(matr[1,0] + "|" + matr[1,1]);
System.Console.WriteLine(matr[2,0] + "|" + matr[2,1]);

Console.ReadKey();*/






//CUBOS E LAÇOS
int produto, regiao, semestre;
int[,,] cubo_dados = new int[2,2,2];

cubo_dados[0,0,0] = 100;
cubo_dados[0,0,1] = 500;
cubo_dados[0,1,0] = 700;
cubo_dados[0,1,1] = 1100;
cubo_dados[1,1,1] = 300;
cubo_dados[1,1,0] = 800;
cubo_dados[1,0,1] = 900;
cubo_dados[1,0,0] = 700;

System.Console.WriteLine("Análise de Vendas:");
System.Console.WriteLine("");

for (produto = 0; produto<=1; produto++)
{
    System.Console.WriteLine("");
    System.Console.WriteLine("[" + produto + "º Produto]");

    for (regiao = 0; regiao<=1; regiao++)
    {
        System.Console.WriteLine("Região " + regiao + ":");

        for (semestre = 0; semestre<=1; semestre++)
        System.Console.WriteLine("sem." + semestre + ":" + cubo_dados[produto,regiao,semestre]);

        System.Console.WriteLine("");
    }
    
}
Console.ReadKey();

