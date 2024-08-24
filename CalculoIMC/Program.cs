float peso, altura, imc, metaIMC, metaPeso;
metaIMC = metaPeso = 0;
string estado;

Console.Write("Insira o peso em kgs: ");
peso = float.Parse(Console.ReadLine());
Console.Write("Insira a altura em metros: ");
altura = float.Parse(Console.ReadLine());

imc = peso / (float)(Math.Pow(altura, 2));
Console.WriteLine("Seu IMC é: {0}", imc.ToString("F2"));

if (imc < 18.5)
{
    estado = "Magreza";
    metaIMC = (float)18.5 - imc;
    metaPeso = (imc * (float)Math.Pow(altura, 2)) - peso;
}
else
{
    if (imc < 24.91)
    {
        estado = "Normal";
    }
    else
    {
        if (imc < 29.91)
        {
            estado = "Sobrepeso";
            metaIMC = imc - (float)24.9;
            metaPeso = peso - (float)(24.9 * Math.Pow(altura, 2));
        }
        else
        {
            if (imc < 39.91)
            {
                estado = "Obesidade";
                metaIMC = imc - (float)24.9;
                metaPeso = peso - (float)(24.9 * Math.Pow(altura, 2));
            }
            else
            {
                estado = "Obesidade Grave";
                metaIMC = imc - (float)24.9;
                metaPeso = peso - (float)(24.9 * Math.Pow(altura, 2));
            }
        }
    }
}
Console.WriteLine("Seu estado é: " + estado);
if (metaIMC != 0)
{
    Console.WriteLine("Seu IMC precisa melhorar em {0} para a classificação Normal", metaIMC.ToString("F2"));
    Console.WriteLine("Seu Peso precisa melhorar em {0} para a classificação Normal", metaPeso.ToString("F2"));
}

