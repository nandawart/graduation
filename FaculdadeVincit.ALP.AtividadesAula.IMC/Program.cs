float altura, peso, imc;
int idade;
string seuNome;
string sobrenome;

System.Console.WriteLine("Digite sua altura");
altura = float.Parse(Console.ReadLine());

System.Console.WriteLine("Digite seu peso");
peso = float.Parse(Console.ReadLine());

System.Console.WriteLine("Digite sua idade");
idade = int.Parse(Console.ReadLine());

System.Console.WriteLine("Digite seu nome");
seuNome = Console.ReadLine();

System.Console.WriteLine("Digite seu sobrenome");
sobrenome = Console.ReadLine();

imc = peso / (altura * altura);

System.Console.WriteLine(seuNome + ", seu IMC é: " + imc);

if (imc<25) {
    System.Console.WriteLine("Eutrofia");
    System.Console.WriteLine("Risco: nenhum");
} 
else if (imc<30) {
    System.Console.WriteLine("Sobrepeso");
    System.Console.WriteLine("Risco: aumentado");
}
else if (imc<35) {
    System.Console.WriteLine("Obesidade I");
    System.Console.WriteLine("Risco: moderado");
}
else if (imc<40) {
    System.Console.WriteLine("Obesidade II");
    System.Console.WriteLine("Risco: grave");
}
else {
    System.Console.WriteLine("Obesidade III");
    System.Console.WriteLine("Risco: muito grave");
} 
Console.ReadLine();