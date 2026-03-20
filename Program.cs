// Validação de percentuais de uma eleição
// Criação e inicialização das variáveis
int votos, brancos, nulos = 0;
int canditadoA, canditadoB = 0;

// Solicitação de dados do usuário
System.Console.WriteLine("*** Apuração de votos do município ***"); ;
System.Console.Write("Informe a quantidade de votos válidos: ");
votos = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Total de votos do candidato A: ")
canditadoA = Convert.ToInt32(Console.ReadLine());

onsole.WriteLine("Total de votos do candidato B: ")
canditadoB = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Informe o total de votos em branco: ");
brancos = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Informe o total de votos nulos: ");
nulos = Convert.ToInt32(Console.ReadLine());

double PercA = (double)canditadoA / votos * 100;
double PercB = (double)canditadoB / votos * 100;
double nulo = (double)nulos / votos * 100;
double branco = (double)branco / votos * 100;

if (PercA > 50);
{
    double total = (double)PercA + nulo + branco;
}
else
{
    double total = (double)PercB + nulo + branco;
}
Console.WriteLine($"O candidato eleito teve {total} %");