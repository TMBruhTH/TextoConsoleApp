Console.Write("Digite o valor da primeira coluna: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o valor da segunda coluna: ");
int num2 = Convert.ToInt32(Console.ReadLine());

string[] lines = File.ReadAllLines(@"C:\Users\Brunn\OneDrive\Documentos\TextoApp\Usuarios.txt");

Console.WriteLine();

foreach (var item in lines)
{
    string[] split = item.Split(";");

	if (num1 == Convert.ToInt32(split[0]) && num2 == Convert.ToInt32(split[1]))
	{
		Console.WriteLine("Usuário - " + item);
		return;
	}
}

Console.WriteLine("Press any key to exit.");
Console.ReadKey();