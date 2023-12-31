﻿using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class ControlCalculadora
    {
        //Criando um objeto calculadora na memória
        ModelCalculadora calculadora;

        public ControlCalculadora()
        {
            this.calculadora = new ModelCalculadora();
        }//fim do construtor

        public void Coletar()
        {
            Console.WriteLine("Informe um número: ");
            this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe outro número: ");
            this.calculadora.GetSetNum2 = Convert.ToDouble(Console.ReadLine());
        }//fim do coletar





        public int Menu()
        {
            Console.WriteLine("------ Menu -------" +
                              "\n0. Sair" +
                              "\n1. Somar" +
                              "\n2. Subtrair" +
                              "\n3. Dividir" +
                              "\n4. Multiplicar" +
                              "\n5. Potência" +
                              "\n6. Raiz" +
                              "\n7. Tabuada" +
                              "\n8. Conversão de binário para decimal" +
                              "\n9. Conversão de decimal para binário" +
                              "\n10. Hexadecimal para decimal " +
                              "\n11. Decimal para Hexadecimal" +
                              "\n12. Bhaskara" +
                              "\n14.Exercicio 1" +
                              "\n15. Exercicio 2" +
                              "\n16. Exercicio 3 " +
                              "\n17. Exercicio 4" +
                              "\n18. Exercicio 5" +
                              "\n19. Exercicio 6" +
                              "\n20. Exercicio 7" +
                              "\n21. Exercicio 8" +
                              "\n22. Exercicio 9" +
                              "\n23. Exercicio 10" +
                              "\n24. Exercicio 11" +
                              "\n25. Exercicio 12" +
                              "\n26. Exercicio 13" +
                              "\n27. Exercicio 14" +
                              "\n28. Exercicio 15" +
                              "\n29. Exercicio 16" +
                              "\n30. Exercicio 17" +
                              "\n31. Exercicio 18" +
                              "\n32. Exercicio 19" +
                              "\n33. Exercicio 20" +


                              "\n\nEscolha uma das opções acima: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }//fim do método Menu

        public void Operacao()
        {
            int opcao = 0;
            do
            {
                opcao = Menu();
                Console.Clear();//Limpa a tela
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Coletar();
                        Console.WriteLine("Soma: " + this.calculadora.Somar());
                        break;
                    case 2:
                        Coletar();
                        Console.WriteLine("Subtração: " + this.calculadora.Subtrair());
                        break;
                    case 3:
                        Coletar();
                        if (this.calculadora.Dividir() == -1)
                        {
                            Console.WriteLine("Impossível dividir!");
                        }
                        else
                        {
                            Console.WriteLine("Divisão: " + this.calculadora.Dividir());
                        }
                        break;
                    case 4:
                        Coletar();
                        Console.WriteLine("Multiplicar: " + this.calculadora.Multiplicar());
                        break;
                    case 5:
                        Coletar();
                        Console.WriteLine("Potência: " + this.calculadora.Potencia());
                        break;
                    case 6:
                        Coletar();
                        Console.WriteLine(this.calculadora.Raiz());
                        break;
                    case 7:
                        Console.WriteLine("Informe um número: ");
                        this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaNum1());
                        break;
                    case 8:
                        Console.WriteLine("Informe um valor em binário: ");
                        Console.WriteLine(this.calculadora.ConverterDecimal(Console.ReadLine()));
                        break;
                    case 9:
                        Console.WriteLine("Informe um valor em decimal: ");
                        Console.WriteLine(this.calculadora.ConverterBinario(Convert.ToInt32(Console.ReadLine())));
                        break;
                    case 10:
                        Console.WriteLine("Informe um valor em Hexadecimal: ");
                        Console.WriteLine(this.calculadora.ConverterHexaDecimal(Console.ReadLine()));
                        break;
                    case 11:
                        Console.WriteLine("Informe um valor em Decimal: ");
                        Console.WriteLine(this.calculadora.ConverterDecimalHexa(Convert.ToInt32(Console.ReadLine())));
                        break;
                    case 12:
                        Console.WriteLine("Informe A: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe B: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe C: ");
                        double c = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.bhaskara(a, b, c));
                        break;

                    case 14:
                        Console.WriteLine("Informe um valor para retornarmos ele dobrado");
                        this.calculadora.GetSetNum = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("duplicar: " + this.calculadora.ExerUMParteUm());


                        Console.WriteLine("Informe um valor para retornarmos ele triplicado");
                        this.calculadora.GetSetNum = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("triplicar: " + this.calculadora.ExerUmParteDois());
                        break;

                    case 15:
                        Console.WriteLine("Informe o valor do seu salario");
                        double salario = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.ExerDois(salario));
                        break;


                    case 16:
                        Console.WriteLine("Informe um valor");
                        this.calculadora.GetSetNum = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.ExerTresParteDois());
                        Console.WriteLine(this.calculadora.ExerTresParteUm());
                        break;

                    case 17:
                        Console.WriteLine("somando: " + this.calculadora.ExerQuatro());
                        break;

                    case 18:
                        Console.WriteLine("digite o valor de N : ");
                        this.calculadora.GetSetNum = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.ExerCinco());

                        break;


                    case 19:
                        Console.WriteLine("Informe um primeiro valor");
                        int inicio = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o segundo valor");
                        int final = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.calculadora.ExerSeis(inicio, final));
                        break;

                    case 20:
                        Console.WriteLine("Aqui estão os números impares entre 100 e 200");
                        Console.WriteLine(this.calculadora.ExerSete());
                        break;

                    case 21:

                        Console.WriteLine("Soma dos números");
                        Console.WriteLine("resultado: " + this.calculadora.ExerOito());

                        break;

                    case 22:
                        Console.WriteLine("Soma dos números");
                        Console.WriteLine("resultado: " + this.calculadora.ExerNove());
                        break;

                    case 23:

                        Console.WriteLine("A média dos valores pares é de:" + this.calculadora.ExerDez());
                        break;

                    case 24:

                        Console.WriteLine(this.calculadora.ExerOnze());
                        
                        break;

                    case 25:
                        Console.WriteLine("Soma dos número positivos e quantidade de negativos");
                        this.calculadora.ExerDoze();

                        break;

                    case 26:
                        Console.WriteLine("Informe um número para começar: ");
                        int numero = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.calculadora.ExerTreze(numero));

                        break;

                    case 27:
                        Console.WriteLine("Quantos jogadores há no time ?");
                        double jogadores = Convert.ToDouble(Console.ReadLine());
                        
                        this.calculadora.ExerQuator(jogadores);


                        break;

                    case 28:

                        this.calculadora.ExerQuinze();
                        break;

                    case 29:
                        Console.WriteLine("Informe a quantidade de eleitores");
                        double eleitores = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe a quantidade de votos nulos");
                        double nulos = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe a quantidade de votos validos");
                        double validos = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe a quantidade de votos brancos");
                        double brancos = Convert.ToInt32(Console.ReadLine());

                        this.calculadora.ExerDezesseis(eleitores,nulos,validos,brancos);

                        break;

                    case 30:
                        Console.WriteLine("Qual é o valor do custo da fábrica");
                        double custoFabrica = Convert.ToDouble(Console.ReadLine());
                        this.calculadora.ExerDezessete(custoFabrica);
                        break;

                    case 31:

                        this.calculadora.ExerDezoito();
                        break;

                    case 32:
                        this.calculadora.ExerDezenove();
                        break;

                    case 33:
                        this.calculadora.ExerVinte();
                        break;

                    default:
                        Console.WriteLine("Opção escolhida não é valida");
                        break;
                }//fim do switch

            } while (opcao != 0);//fim do Do...while
        }//fim do operacao
    }//fim da classe
}//fim do projeto
