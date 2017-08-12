using System;

namespace Exercicio1AreaRetangulo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int baseR, alturaR, areaR;
			Console.WriteLine("Digite o tamanho da base em metros: ");
			baseR = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Digite o tamanho da altura em metros: ");
			alturaR = Convert.ToInt32(Console.ReadLine());
			areaR = baseR * alturaR;
			Console.WriteLine("A área do retânagulo é de {0} metros.", areaR);
			Console.ReadLine();
        }
    }
}
