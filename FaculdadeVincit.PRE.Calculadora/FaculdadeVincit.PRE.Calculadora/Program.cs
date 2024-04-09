//CALCULADORA CSHARP
static double Somar(double v1, double v2) {
    return v1 + v2;
}
static double Subtrair(double v1, double v2) {
    return v1 - v2;
}
static double multiplicar(double v1, double v2) {
    return v1 * v2;
}
static double dividir(double v1, double v2) {
    double resultado = 0;
    if (v2 != 0) {
        resultado = v1 / v2;
    } else {
        System.Console.WriteLine("O segundo valor não deve ser zero");
    }
    return resultado;
}

int opcao = 0;
double valor1, valor2, resultado = 0;

do {
    System.Console.WriteLine("Calculadora!");
    System.Console.WriteLine("1 - Somar");
    System.Console.WriteLine("2 - Subtrair");
    System.Console.WriteLine("3 - Multiplicar");
    System.Console.WriteLine("4 - Dividir");
    System.Console.WriteLine("9 - Sair");

    System.Console.WriteLine("Informe uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    if (opcao == 9) {
        System.Console.WriteLine("Você está saindo da calculadora. Até a próxima!");
    } else if (opcao > 4){
        System.Console.WriteLine("Opção inválida");
    } else {
        System.Console.WriteLine("Informe o valor 1: ");
        valor1 = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Informe o valor 2: ");
        valor2 = double.Parse(Console.ReadLine());

        if (opcao == 1) {
            resultado = Somar(valor1, valor2);
        } else if (opcao == 2) {
            resultado = Subtrair(valor1, valor2);
        } else if (opcao == 3) {
            resultado = multiplicar(valor1, valor2);
        } else if (opcao == 4) {
            resultado = dividir(valor1, valor2);
        }

        System.Console.WriteLine("Resultado: " + resultado);
    }
     
} while(opcao != 9); 
Console.ReadKey();
