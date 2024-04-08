//ESTRUTURAS HETEROGÊNEAS
//Leitura de dados para  registro

public record tipo_paciente 
{
    public int codigo {get;init;}
    public string nome {get;init;}
    public string data_nasc {get;init;}
    public string data_entrada {get;init;}
    public string prontuario {get;init;}
}

class Program
{
    static void Main(string[] args)
    { 
        System.Console.WriteLine("Prontuário eletrônico");
        System.Console.WriteLine("");

        System.Console.WriteLine("Código:");
        int codigo = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Nome completo:");
        string nome = Console.ReadLine();
        System.Console.WriteLine("Data de nascimento (DD/MM/AAAA):");
        string data_nasc = Console.ReadLine();
        System.Console.WriteLine("Data de entrada (DD/MM/AAAA):");
        string data_entrada = Console.ReadLine();
        System.Console.WriteLine("Prontuário:");
        string prontuario = Console.ReadLine();

        tipo_paciente paciente = new tipo_paciente
        {
            codigo = codigo,
            nome = nome,
            data_nasc = data_nasc,
            data_entrada = data_entrada,
            prontuario = prontuario
        };

        System.Console.WriteLine("");
        System.Console.WriteLine("Dados do paciente:");
        System.Console.WriteLine($"Código: {paciente.codigo}");
        System.Console.WriteLine($"Nome: {paciente.nome}");
        System.Console.WriteLine($"Data de nascimento: {paciente.data_nasc}");
        System.Console.WriteLine($"Data de entrada: {paciente.data_entrada}");
        System.Console.WriteLine($"Prontuário: {paciente.prontuario}");
    }
}

