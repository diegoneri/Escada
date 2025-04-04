double comprimentoEscada, altura;
double anguloEmGraus, anguloEmRadianos;

Console.Clear();

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.BackgroundColor = ConsoleColor.Gray;

Console.WriteLine("--- Escada ---\n\n");

Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.BackgroundColor = ConsoleColor.Gray;

Console.Write("Informe o comprimento da escada: ");
comprimentoEscada = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Informe o ângulo (em graus) da posição da escada: ");
anguloEmGraus = Convert.ToDouble(Console.ReadLine()!);

Console.ResetColor();

anguloEmRadianos = Math.PI * anguloEmGraus / 180;
altura = comprimentoEscada * Math.Sin(anguloEmRadianos);

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.BackgroundColor = ConsoleColor.Gray;

Console.WriteLine($"Uma escada de {comprimentoEscada}m a {anguloEmGraus}° alcança {altura:N2}m");

Console.ResetColor();