//CÁLCULO DE FATORIAL EM CÓDIGO

/*static void fatorial(int valor) {
    if (valor == 1) {
        return 1;
    }
    return valor * fatorial(valor-1);
}
System.Console.WriteLine("Fatorial de 5 = " + fatorial(5));
Console.ReadKey();*/



//CALCULADORA  ESPECIAL:

static void fatorial(int valor, out int resultado, int aux = 1) {
    if (valor >= 1) {
        aux = aux * valor;
        fatorial(valor-1, out resultado, aux);
    } else {
        resultado = aux;
    }
}
static string DectoBin(int valor) {
    int div, mod;
    string bit;

    mod = valor % 2;
    div = (valor - mod) / 2;
    bit = mod.ToString();

    if (div > 1) {
        return DectoBin(div) + bit;
    } else if (div > 0) {
        return div + bit;
    } else {
        return bit;
    }
}

int opcao = 0;
int valor, fat = 0;
string binario;
do {
    Console.Clear();
    System.Console.WriteLine("Calculadora Especial!");
    System.Console.WriteLine("1: Fatorial");
    System.Console.WriteLine("2: DextoBin");
    System.Console.WriteLine("9: Sair da calculadora");
    System.Console.WriteLine("Informe a opção desejada");
    opcao = int.Parse(Console.ReadLine());

    if (opcao == 9) {
        System.Console.WriteLine("Até a próxima!");
    } else if ((opcao < 1) || (opcao > 2)) {
        System.Console.WriteLine("Opção inválida");
    } else {
        if (opcao == 1){
            System.Console.WriteLine("Informe um número para Fatorial");
            valor = int.Parse(Console.ReadLine());
            fatorial(valor, out fat);

            System.Console.WriteLine("O resultado é: " + fat);
        } else if (opcao == 2) {
            System.Console.WriteLine("Informa um número para conersão");
            valor = int.Parse(Console.ReadLine());
            binario = DectoBin(valor);

            System.Console.WriteLine("O resultado da conversão é: " + binario);
        }
    }
    Console.ReadKey();
} while (opcao != 9);