
using System.Threading;
using System;

namespace Situação_de_Aprendizagem_Console
{
	class Program
	{
		public static void Main(string[] args)
		{   // Declaração de varíaveis
			string iguais = "true";
			int op = 0;
			int resto,resto2,primeiro_digito,segundo_digito = 0;
			int soma = 0;
			int soma2 = 0;
			string CPF = "".Replace("/","").Replace(".","").Replace("a","").Replace("b","").Replace("d","").Replace("e","").Replace("f","").Replace("g","").Replace("h","").Replace("i","").Replace("j","").Replace("k","").Replace("l","").Replace("m","").Replace("n","").Replace("o","").Replace("p","").Replace("q","").Replace("r","").Replace("s","").Replace("t","").Replace("u","").Replace("v","").Replace("w","").Replace("x","").Replace("y","").Replace("z","");
			char[] vetor = new char[11];
			int[] valores = new int[9];
			int[] valoresmultiplicado = new int[9];
			int[] valoresmultiplicado2 = new int[10];
			int primeiroeminteiro = 0,segundoeminteiro = 0;
			Console.ForegroundColor = ConsoleColor.Blue;
			// enquanto para loop do menu 
			while (op != 3) {
				Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("===============================");
			Console.WriteLine("Programa verificador de CPF!");
			Console.WriteLine("Escolha uma opção: ");
			Console.WriteLine("1. Cadastrar CPF");
			Console.WriteLine("2. Verificar se o CPF é válido.");
			Console.WriteLine("3. Sair do programa.");
			Console.WriteLine("===============================");
			int.TryParse(Console.ReadLine(),out op);
			Console.Clear();
			
			// switch para opções do menu
			switch (op) { case 1:
					{ 
						// do while para loop caso o CPF digitado não possua 11 digitos
						do{
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("===============");
			Console.WriteLine("Digite um CPF: ");
			Console.WriteLine("===============");
	 		CPF = Console.ReadLine();
	 		Console.Clear();
			// if para caso o cpf não possua 11 digitos
	 		if (CPF.Length != 11) {
	 			Console.Clear();
	 			Console.ForegroundColor = ConsoleColor.Red;
	 			Console.WriteLine("O CPF Digitado não possui 11 digitos, digite novamente!");}
						} while (CPF.Length != 11);}break;
			case 2:
			{
			// for para armazernar o CPF em char
			for (int i = 0; i < CPF.Length; i++)
			{
				vetor[i] =	CPF[i];
			}
			// for para armazenar o CPF em int
			for (int i = 0; i < 9; i++) {
			   
				valores[i] = Convert.ToInt32(vetor[i]);
				}
			// armazenando valores do CPF em int multiplicados para calculo do primeiro digito
			valoresmultiplicado[0] = Convert.ToInt32(valores[0] - 48) * 10;
			valoresmultiplicado[1] = Convert.ToInt32(valores[1]- 48)  * 9;
			valoresmultiplicado[2] = Convert.ToInt32(valores[2] - 48) * 8;
			valoresmultiplicado[3] = Convert.ToInt32(valores[3] -48) * 7;
			valoresmultiplicado[4] = Convert.ToInt32(valores[4] -48) * 6;
			valoresmultiplicado[5] = Convert.ToInt32(valores[5] -48) * 5;
			valoresmultiplicado[6] = Convert.ToInt32(valores[6] -48) * 4;
			valoresmultiplicado[7] = Convert.ToInt32(valores[7] -48) * 3;
			valoresmultiplicado[8] = Convert.ToInt32(valores[8] -48) * 2;
			// armazenando a soma dos valores para calculo do primeiro digito
			for (int i = 0; i < 9; i++) {
			soma = soma + valoresmultiplicado[i];
	            		
			}
			// calculando primeiro digito
			resto =	soma % 11;
			if (resto < 2) {primeiro_digito = 0;
				}
			else { primeiro_digito = 11 - resto;}
			
			
			// armazenando valores do CPF em int multiplicados para calculo do segundo digito
			
			valoresmultiplicado2[0] = Convert.ToInt32(valores[0] - 48) * 11;
			valoresmultiplicado2[1] = Convert.ToInt32(valores[1]- 48)  * 10;
			valoresmultiplicado2[2] = Convert.ToInt32(valores[2] - 48) * 9;
			valoresmultiplicado2[3] = Convert.ToInt32(valores[3] -48) * 8;
			valoresmultiplicado2[4] = Convert.ToInt32(valores[4] -48) * 7;
			valoresmultiplicado2[5] = Convert.ToInt32(valores[5] -48) * 6;
			valoresmultiplicado2[6] = Convert.ToInt32(valores[6] -48) * 5;
			valoresmultiplicado2[7] = Convert.ToInt32(valores[7] -48) * 4;
			valoresmultiplicado2[8] = Convert.ToInt32(valores[8] -48) * 3;
			valoresmultiplicado2[9] = primeiro_digito * 2;
			
			// calculando segundo digito
			for (int i = 0; i < valoresmultiplicado2.Length; i++) {
			soma2 = soma2 + valoresmultiplicado2[i];    		
			}
			resto2 = soma2 % 11;
			if (resto2 < 2) { segundo_digito = 0;
				}
			else{ segundo_digito = 11 - resto2;}
			// armazenando os digitos verificadores digitados no CPF, em inteiro.
			primeiroeminteiro = vetor[9] - 48;
			segundoeminteiro = vetor[10] - 48;
			Console.WriteLine("Verificando Digitos...");
			Thread.Sleep(1000);
			// comparando se os digitos do CPF são vários do mesmo número
            if (CPF == "11111111111" || CPF == "22222222222" || CPF == "33333333333" || CPF == "44444444444" || CPF == "55555555555" || CPF == "66666666666" || CPF == "77777777777" || CPF == "88888888888" || CPF == "99999999999") {
				iguais = "false";	Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("O CPF são 11 digitos do mesmo número!");} 		


			// comparando os digitos calculados com os digitado no CPF para ver se o CPF é valido ou não
			
			if (primeiroeminteiro == primeiro_digito && segundoeminteiro == segundo_digito && iguais == "true") {	Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("O CPF é válido!");}
				else{	Console.ForegroundColor = ConsoleColor.Red;Console.WriteLine("O CPF não é válido!");}
         
					}break;
	                 // caso a escolha seja a saída do programa		 
					case 3: {Console.ForegroundColor = ConsoleColor.Magenta;Console.WriteLine("Obrigado por ultilizar o meu programa :) Creditos By FILIPIN");}break;
					default : Console.Clear(); Console.ForegroundColor = ConsoleColor.Red; {Console.WriteLine("Opção inválida!"); Console.ResetColor();} break;
			
			}
			
			}
			
			Console.ReadKey(true);
		}
	}
}