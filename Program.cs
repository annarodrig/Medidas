//Cria variaveis em ponto flutuante
double cm, m ,km;
Console.Write("Entre com a medida (em metros):");
m = Convert.ToDouble (Console.ReadLine());

//Calcula equivalência de metros para quilômetros e centímetros
cm = m * 100;
km = m / 1000;

Console.WriteLine("\n ---Equivalência---");
Console.WriteLine($"{cm}");
Console.WriteLine($"{m}");
Console.WriteLine($"{km}");
