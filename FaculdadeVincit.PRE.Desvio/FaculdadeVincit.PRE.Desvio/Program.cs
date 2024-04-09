//ESTRUTURA DE DESVIO

//Tenho dinheiro para um sorvete?
float salario;

System.Console.WriteLine("Quanto você ganha?");
salario = float.Parse(Console.ReadLine());

//expressão verdade: booleana
if (salario < 14.90f) {
    System.Console.WriteLine("Você não tem dinheiro para o sorvete");
} else {
    System.Console.WriteLine("Baunilha, Chocolate ou Misto?");
}
Console.ReadKey();
