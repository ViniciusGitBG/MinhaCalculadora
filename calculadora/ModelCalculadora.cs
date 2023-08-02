using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class ModelCalculadora
    {
        //Declarando variáveis
        private double num1;
        private double num2;
        private double num;

        public ModelCalculadora()
        {
            GetSetNum1 = 0;
            GetSetNum2 = 0;
            GetSetNum = 0;
        }//fim do construtor

        //Métodos Gets e Sets
        public double GetSetNum1
        {
            get { return this.num1; }
            set { this.num1 = value; }
        }//fim do GetSetNum1

        public double GetSetNum2
        {
            get { return this.num2; }
            set { this.num2 = value; }
        }//fim do GetSetNum2

        public double GetSetNum
        {
            get { return this.num; }
            set { this.num = value; }
        }

        //Métodos
        public double Somar()
        {
            return GetSetNum1 + GetSetNum2;
        }//fim do método somar

        public double Subtrair()
        {
            return GetSetNum1 - GetSetNum2;
        }//fim do método subtrair

        public double Dividir()
        {
            if (GetSetNum2 <= 0)
            {
                return -1;
            }
            else
            {
                return GetSetNum1 / GetSetNum2;
            }
        }//fim do método dividir

        public double Multiplicar()
        {
            return GetSetNum1 * GetSetNum2;
        }//fim do método multiplicar

        public double Potencia()
        {
            return Math.Pow(GetSetNum1, GetSetNum2);
        }//fim da potência

        public string Raiz()
        {
            string msg = "Raiz do primeiro número: " + Math.Sqrt(GetSetNum1) +
                         "\nRaiz do segundo número: " + Math.Sqrt(GetSetNum2);
            return msg;
        }//fim do método raiz

        public string TabuadaNum1()
        {
            string resultado = "";

            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n" + GetSetNum1 + " * " + i + " = " + (GetSetNum1 * i);
            }//fim do for

            return resultado;
        }//fim do método

        public string TabuadaNum2()
        {
            string resultado = "";

            //Início;Fim;Contagem
            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n" + GetSetNum2 + " * " + i + " = " + (GetSetNum2 * i);
            }//fim do for

            return resultado;
        }//fim do método

        public double ConverterDecimal(string binario)
        {
            double dec = 0;
            string caract = "";
            int tamanho = binario.Length;
            int pote = tamanho;
            for (int i = 0; i < tamanho; i++)
            {
                pote--;
                caract = binario.Substring(i, 1);
                if (caract == "1")
                {
                    dec += Math.Pow(2, pote);
                }
            }//fim do for
            return dec;
        }//fim do método converter decimal

        public string ConverterBinario(int dec)
        {
            string binario = "";
            int resto = 0;
            do
            {
                resto = dec % 2;
                binario += resto;
                dec = dec / 2;
            } while (dec != 0);
            return new String(binario.Reverse().ToArray());
        }//fim do método

        public double ConverterHexaDecimal(string hexadecimal)
        {
            double dec = 0;
            string caract = "";
            int num = 0;
            int tamanho = hexadecimal.Length;
            int pote = tamanho;
            for (int i = 0; i < tamanho; i++)
            {
                pote--;
                caract = hexadecimal.Substring(i, 1);
                switch (caract)
                {
                    case "A":
                        num = 10;
                        break;
                    case "B":
                        num = 11;
                        break;
                    case "C":
                        num = 12;
                        break;
                    case "D":
                        num = 13;
                        break;
                    case "E":
                        num = 14;
                        break;
                    case "F":
                        num = 15;
                        break;
                    default:
                        num = Convert.ToInt32(caract);
                        break;
                }//fim do switch
                dec += num * Math.Pow(16, pote);
            }//fim do for
            return dec;
        }//fim do método converter decimal

        public string ConverterDecimalHexa(int dec)
        {
            int resto = 0;
            string hexadecimal = "";

            do
            {
                resto = dec % 16;
                switch (resto)
                {
                    case 10:
                        hexadecimal += "A";
                        break;
                    case 11:
                        hexadecimal += "B";
                        break;
                    case 12:
                        hexadecimal += "C";
                        break;
                    case 13:
                        hexadecimal += "D";
                        break;
                    case 14:
                        hexadecimal += "E";
                        break;
                    case 15:
                        hexadecimal += "F";
                        break;
                    default:
                        hexadecimal += resto;
                        break;
                }//fim do switch
                dec = dec / 16;
            } while (dec != 0);
            return new string(hexadecimal.Reverse().ToArray());
        }//fim do converter

        public string bhaskara(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta <= 0)
            {
                return "Impossível calcular X1 e X2, Delta: " + delta;
            }
            else
            {
                double X1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double X2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return "Delta: " + delta + "\nX1: " + X1 + "\nX2: " + X2;
            }
        }//fim do bhaskara

        public double ExerUMParteUm()
        {
            return GetSetNum * 2;
        }//fim do método Resultado dobro

        public double ExerUmParteDois()
        {
            return GetSetNum * 3;
        }//fim do método Resultado triplo

        public double ExerDois(double salario)
        {
            double resultado = 0;
            resultado = salario * 30 / 100;
            return resultado + salario;
        }

        public string ExerTresParteUm()
        {
            string msg = "Seu número é impar";
            string msg2 = "Seu número é par";
            double result = GetSetNum % 2;

            if (result <= 0)
            {
                return msg2;
            }
            else
            {
                return msg;
            }

        }// fim do verificar negativo e positivo 

        public string ExerTresParteDois()
        {
            string msg = "Seu numero é negativo";
            string msg2 = "Seu numero é positivo";
            if (GetSetNum < 0)
            {
                return msg;
            }
            else
            {
                return msg2;
            }
        }// fim do verificar negativo e positivo 

        public double ExerQuatro()
        {
            double resul = 0;
            for (int i = 0; i <= 99; i++)
            {
                resul += +i + 1;

            }//fim do for

            return resul;
        }



        public string ExerCinco()
        {
            string resultado = "";
            for (int i = 1; i <= GetSetNum; i++)
            {
                Console.WriteLine("Tabuada do " + i + ":");

                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " x " + j + " = " + (i * j));
                }
            }

            return resultado;
        }
        public int ExerSeis(int inicio, int final)
        {
            int i = 0;
            for (i = inicio; i <= final - 1; i++)
            {
                Console.WriteLine(i);

            }
            return i;


        }

        public double ExerSete()
        {

            int i = 0;
            for (i = 100; i <= 200; i++)
            {

                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            }
            return i;
        }

        public double ExerOito()
        {
            int soma = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Digite o valor ");
                int valor = Convert.ToInt32(Console.ReadLine());

                soma += valor;
            }

            return soma;
        }

        public int ExerNove()
        {
            int soma = 0;
            int valor = 1;
            do
            {

                Console.WriteLine("Digite o valor ");
                valor = Convert.ToInt32(Console.ReadLine());

                soma += valor;



            } while (valor != 0);

            return soma;
        }

        public double ExerDez()
        {
            int soma = 0;
            int quantidade = 0;
            int valor = 1;
            double media = 0;

            while (valor != 0)
            {
                Console.WriteLine("Digite um valor (ou 0 para sair):");
                valor = Convert.ToInt32(Console.ReadLine());

                if (valor % 2 == 0)
                {
                    soma += valor;
                    quantidade++;
                }
            }

            if (quantidade > 0)
            {
                media = soma / quantidade;

            }

            return media;
        }

        public int ExerOnze()
        {
            int maior = 0;
            int valor = 1;


            while (valor != 0)
            {
                Console.WriteLine("Digite um valor (ou 0 para sair):");
                valor = Convert.ToInt32(Console.ReadLine());

                if (valor != 0)
                {
                    if (valor > maior)
                    {
                        maior = valor;

                    }

                }
            }
            return maior;


        }

        public int ExerOnzeParteDois()
        {

            int menor = 0;
            int valor = 1;


            while (valor != 0)
            {
                Console.WriteLine("Digite um valor 0 para sair:");
                valor = Convert.ToInt32(Console.ReadLine());

                if (valor != 0)
                {

                    if (valor < menor)
                    {
                        menor = valor;

                    }
                    return menor;

                }
            }
            return menor;

        }

        public double ExerDoze()
        {

            int somaPositivos = 0;
            int quantidadeNegativos = 0;

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Digite o valor ");
                int valor = Convert.ToInt32(Console.ReadLine());

                if (valor > 0)
                {
                    somaPositivos += valor;
                }
                else if (valor < 0)
                {
                    quantidadeNegativos++;
                }
            }

            Console.WriteLine("A soma dos valores positivos é: " + somaPositivos);
            Console.WriteLine("A quantidade de valores negativos é: " + quantidadeNegativos);
            return 0;



        }



    }//fim da classe
}//fim do projeto
