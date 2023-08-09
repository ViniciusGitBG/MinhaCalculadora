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

        public string ExerOnze()
        {
            int maior = 1;
            int numero = 1;
            int menor = 1;
            Boolean flag = false;

            do
            {
                Console.WriteLine("Digite um valor ou 0 para sair:");
                numero = Convert.ToInt32(Console.ReadLine());


                if(flag == false)
                {
                    maior = numero;
                    menor = numero;
                    flag = true;
                }

                if (numero > maior && numero !=0)
                {
                    maior = numero;
                }
                else if (numero < menor && numero !=0)
                {
                    menor = numero;
                }



            } while (numero != 0);
                return ("O maior número é " + maior + " O menor número é " + menor);


        }

        
        public void ExerDoze()
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

        }

        public double ExerTreze(int numero)
        {
            int resultado = 1;
            
                for (int i = 1; i <= numero; i++)
                {
                    resultado *= i;
                    Console.WriteLine(numero + "*"+ i + "=" + resultado);
                    
                }
            
            return resultado;
        }

        public void ExerQuator(double jogadores)
        {
            double acumula = 0;
            double altura = 0;


            for (int i = 1; i <= jogadores; i++)
            {
               
                Console.WriteLine("informe a altura do " + i + "°" + "jogador");
                altura = Convert.ToDouble(Console.ReadLine());
                
                acumula += altura;
                


            }
            Console.WriteLine("A média da altura dos jogadores é de " + acumula / jogadores);
            
            
        }//fim do exercicio 14

        public void ExerQuinze()
        {
            
            string vencedora = "";
            
            string[] candidatas = new string[17];
            int[] notas = new int[17];
            double maiorNota = notas[0];
            for (int i = 1;  i < candidatas.Length; i++)
            {
                    Console.WriteLine("Informe o nome da " + i + " candidata:");

                    candidatas[i] = (Console.ReadLine());
             
                    
                do {
                    Console.WriteLine("Informe a nota da " + i + " candidata:");
                    notas[i] = Convert.ToInt32(Console.ReadLine());
                    if (notas[i] >= 11)
                    {
                        Console.WriteLine("Informe uma nota entre 0 e 10");
                        Console.WriteLine("Informe a nota da " + i + " candidata:");
                        notas[i] = Convert.ToInt32(Console.ReadLine());
                        
                    }
                    else if (notas[i] <= -1)
                    {
                        Console.WriteLine("Informe uma nota entre 0 e 10");
                        Console.WriteLine("Informe a nota da " + i + " candidata:");
                        notas[i] = Convert.ToInt32(Console.ReadLine());
                        
                    }
                    

                    if (notas[i] > maiorNota)
                    {
                        maiorNota = notas[i];
                        vencedora = candidatas[i];
                    }



                } while (notas[i] < 0 && notas[i] > 10);
                

                    
               
            }// vetor candidatas

            Console.WriteLine("A candidata " + vencedora + " foi a vencedora com nota : " + maiorNota);


        }//fim da atividade 15

        public void ExerDezesseis(double eleitores,double nulos,double validos, double brancos)
        {
            double vtBranco = 0;
            double vtNulos = 0;
            double vtValidos = 0;
            if (eleitores <= 0)
            {
                Console.WriteLine("Informe um número válido de eleitores");
            }

            if (nulos <= 0)
            {
                Console.WriteLine("Informe um número válido de votos");
            }

            if (validos <= 0)
            {
                Console.WriteLine("Informe um número válido de votos");
            }

            if (brancos <= 0)
            {
                Console.WriteLine("Informe um número válido de votos");
            }

            

                vtBranco = (brancos / eleitores) * 100;
                vtNulos = (nulos / eleitores) * 100;
                vtValidos = (validos / eleitores) * 100;
            
            
            Console.WriteLine($"O porcentual de votos brancos é de {vtBranco} " +
                $"\n O porcentual de votos nulos é de {vtNulos} \n O porcentual de votos validos é de " +
                $"{vtValidos} ");
        }// fim da atividade 16

        public void ExerDezessete(double custoFabrica)
        {
           
            double valorImporsto = (custoFabrica * 45) / 100;
            double valorDistribuidor = (custoFabrica * 28) / 100;
            double valorTot = custoFabrica + valorDistribuidor + valorImporsto;

            Console.WriteLine("O valor do imposto é " + valorImporsto + "\n " +
                "O valor da porcentagem do distribuidor é de " + valorDistribuidor +
                "\n O valor total do veiculo então é de " + valorTot);
        }// fim da atividade 17

        public void ExerDezoito()
        {
            int anos = 0;
            int dias = 0;
            int meses = 0;
            do
            {
                Console.WriteLine("Informe sua idade");
                anos = Convert.ToInt32(Console.ReadLine());
                if (anos < 0)
                {
                    Console.WriteLine("informe uma idade válida");
                }
            }while(anos <= 0);

            do
            {
                Console.WriteLine("Informe quantos meses você tem");
                meses = Convert.ToInt32(Console.ReadLine());
                if (meses < 0 || meses > 12)
                {
                    Console.WriteLine("informe um número válido de meses");
                }
            } while (meses <= 0);

            do
            {
                Console.WriteLine("Informe quantos dias você tem");
                dias = Convert.ToInt32(Console.ReadLine());
                if (dias < 0 || dias > 31)
                {
                    Console.WriteLine("informe um valor de dias válido");
                }
            } while (dias <= 0);

            double convertAnosDias = anos * 365;
            double convertDiasMeses = meses * 30;
            double tot = convertAnosDias + convertDiasMeses;

            Console.WriteLine("Sua idade em dias é de " + tot);

        }// fim da atividade 18

        public void ExerDezenove()
        {
            int[] elementos = new int[5];
            
            int maiorElemento = 0;
            for(int i = 0; i < elementos.Length; i++)
            {
                Console.WriteLine("Informe os números: ");
                elementos[i] = Convert.ToInt32(Console.ReadLine());

                
                
                    if (elementos[i] > maiorElemento)
                    maiorElemento = elementos[i];
                    
                
            }

            Console.WriteLine("O maior elemento do vetor de 5 posições é de: " + maiorElemento);
        }//fim da atividade 19

        public void ExerVinte()
        {
            int[] par = new int[5];
            int[] impar = new int[5];
            int[] aux1 = new int[5];
            int[] aux2 = new int[5];
           

            for (int i =0; i < par.Length; i++)
            {
                Console.WriteLine("Informe os números");
                par[i] = Convert.ToInt32(Console.ReadLine());
                if (par[i] % 2 == 0)
                {
                    aux1[i] = par[i];
                }
                
                
            }

            for (int j = 0; j < impar.Length; j++)
            {
                Console.WriteLine("Informe os números");
                impar[j] = Convert.ToInt32(Console.ReadLine());
                if (impar[j] % 2 != 0)
                {
                    aux2[j] = impar[j];
                }
                    
                
            }
            Console.WriteLine("vetor par");
            for (int i = 0; i < par.Length; i++)
            {
                Console.WriteLine(aux1[i]);
            }
            Console.WriteLine("vetor impar");

            for (int j = 0; j < impar.Length; j++)
            {
                Console.WriteLine(aux2[j]);
            }



        }// fim do exercicio 20



    }//fim da classe
}//fim do projeto
