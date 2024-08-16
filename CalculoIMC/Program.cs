int peso;
float altura, resultado, meta = 0;
string estado;

Console.Write("Insira o peso em kgs: ");
peso = int.Parse(Console.ReadLine());
Console.Write("Insira a altura em metros: ");
altura = float.Parse(Console.ReadLine());

resultado = peso / (float)(Math.Pow(altura, 2));
Console.WriteLine("Seu IMC é: {0}", resultado.ToString("F2"));

if (resultado < 18.5)
{
    estado = "Magreza";
    meta = (float)18.5 - resultado;
}
else
{
    if (resultado < 24.9)
    {
        estado = "Normal";
    }
    else
    {
        if (resultado < 29.9)
        {
            estado = "Sobrepeso";
            meta = resultado - (float)24.9;
        }
        else
        {
            if (resultado < 39.9)
            {
                estado = "Obesidade";
                meta = resultado - (float)24.9;
            }
            else
            {
                estado = "Obesidade Grave";
                meta = resultado - (float)24.9;
            }
        }
    }
}
Console.WriteLine("Seu estado é: " + estado);
if (meta != 0)
{
    Console.WriteLine("Seu IMC precisa melhorar em {0} para a classificação Normal", meta.ToString("F2"));
}

