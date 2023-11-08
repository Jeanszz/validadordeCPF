
using System;

namespace Situação_de_Aprendizagem_Console
{
	class Program
	{
		public static void Main(string[] args)
		{
			string CPF = "";
		
          while (CPF.Length != 11) {
          	Console.WriteLine("Digite um CPF: ");
			CPF = Console.ReadLine();
			
			if (CPF.Length != 11) { 
				Console.WriteLine("O CPF Digitado não possui 11 digitos, digite novamente!");}
			}

			char[] vetor = new char[11];
			int[] valores = new int[9];
			int[] valoresmultiplicado = new int[9];
			
			for (int i = 0; i < CPF.Length; i++) {
				vetor[i] =	CPF[i];
			}
			
			for (int i = 0; i < 9; i++) {
			   
				valores[i] = Convert.ToInt32(vetor[i]);
				
				Console.WriteLine(vetor[i]);
				}
			valoresmultiplicado[0] = Convert.ToInt32(valores[0] - 48) * 10;
			valoresmultiplicado[1] = Convert.ToInt32(valores[1]- 48)  * 9;
			valoresmultiplicado[2] = Convert.ToInt32(valores[2] - 48) * 8;
			valoresmultiplicado[3] = Convert.ToInt32(valores[3] -48) * 7;
			valoresmultiplicado[4] = Convert.ToInt32(valores[4] -48) * 6;
			valoresmultiplicado[5] = Convert.ToInt32(valores[5] -48) * 5;
			valoresmultiplicado[6] = Convert.ToInt32(valores[6] -48) * 4;
			valoresmultiplicado[7] = Convert.ToInt32(valores[7] -48) * 3;
			valoresmultiplicado[8] = Convert.ToInt32(valores[8] -48) * 2;
			
			for (int i = 0; i < 9; i++) {
				Console.WriteLine(valoresmultiplicado[i]);
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}