Console.Clear();

string senhaDigitada;
string senhaEsperada = "123456";

Console.Write("Digite sua senha..:");
senhaDigitada = Console.ReadLine()!;

if(senhaDigitada == senhaEsperada)
{
    // Sucesso no login
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Olá, usuário. Logado com sucesso");
}
else
{
    // Fracasso no login
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Senha inválida");
}

Console.ResetColor();
