// Convert
int numero01 = Convert.ToInt32("1");
Console.WriteLine(numero01);

numero01 = Convert.ToInt32(null); // Neste caso converte o null para 0, o que não é ideal para alguns casos
Console.WriteLine(numero01);

// Parse (Mais usual por ser mais otimizado)
int numero02 = int.Parse("2"); 
Console.WriteLine(numero02);

//numero02 = int.Parse(null); // Neste caso gera uma exception
//Console.WriteLine(numero02);

bool verdadeiro = bool.Parse("true");
Console.WriteLine(verdadeiro);

// Try Parse
string numero03 = "123456";
int numeroConvertido;

if (int.TryParse(numero03, out numeroConvertido)) // Caso o Try Parse não consiga converter, seu retorno será 0 e não uma exception
{
  Console.WriteLine("Número convertido com sucesso!");
}

Console.WriteLine(numeroConvertido);
