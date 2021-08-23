using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace silver_windows_forms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
            

                int menu = 1;
                while (menu != 0)
                {

                    Console.WriteLine("Que tipo de investimento você quer simular?");
                    Console.WriteLine(".");
                    Console.WriteLine(" 1- Renda Fixa ou 2- Fundos Imobiliarios, se desejar sair digite 0");
                    menu = int.Parse(Console.ReadLine());

                    if (menu == 1)
                    {
                        rendaFixa();

                    }
                    else if (menu == 2)
                    {
                        fiis();

                    }
                    else if (menu == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida");
                    }
                }




                Console.WriteLine("a");
                Console.WriteLine("a");
                Console.WriteLine("a");
                Console.WriteLine("a");
                Console.WriteLine("a");
                Console.WriteLine("a");
                Console.WriteLine("a");
                Console.WriteLine("a");
                Console.WriteLine("a");
                Console.WriteLine("a");

        }

            private static void rendaFixa()
            {     ////Pergunta investimento inicial
                double habt11 = 125;
                double mxrf11 = 10;
                int cotas1int, cotas2int, investimento;
                double sobra, resultado, cotas1real, deuPraInvestir, total;
                double resultado2, juros2, composto, composto2, anos, meses, aporte, montante;
                int i;
                double juros1, juros3;

                Console.WriteLine("Quanto você quer investir no primeiro Mês?");
                investimento = int.Parse(Console.ReadLine());

                cotas1real = (investimento / habt11);
                cotas1int = Convert.ToInt32(cotas1real);

                deuPraInvestir = (cotas1int * habt11);
                sobra = (investimento - deuPraInvestir);
                resultado = (sobra / mxrf11);
                cotas2int = Convert.ToInt32(resultado);
                total = (cotas2int * mxrf11);


                //// Aportes Mensais
                Console.WriteLine("Aportando quanto por mês?");
                aporte = double.Parse(Console.ReadLine());
                //// Qual é o rendimento ao ano
                Console.WriteLine("Qual é o rendimento ao ano");
                juros3 = double.Parse(Console.ReadLine());

                //// investir por quanto tempo
                Console.WriteLine("Por Quantos anos você deseja investir?");
                anos = double.Parse(Console.ReadLine());

                //// Total investido pelo usuario ao longo de x anos
                meses = (anos * 12);
                resultado2 = ((resultado * mxrf11) + deuPraInvestir * (meses));
                Console.WriteLine("Total investido ao longo de " + anos + " anos");
                Console.WriteLine("R$" + resultado2);
                Console.WriteLine(".");
                Console.WriteLine(".");

                //// Seu patrimonio seria de.....
                juros1 = juros3 / 12;
                juros2 = juros1 / 100;

                composto = ((resultado * mxrf11) + deuPraInvestir);

                ///// juros compostos
                montante = composto * (1 + juros2);
                for (i = 1; i < meses; i++)
                {

                    montante = (montante + aporte) * (1 + juros2);


                }
                montante = Convert.ToInt32(montante);
                Console.WriteLine("Patrimônio acumulado de " + montante);
                Console.WriteLine(".");
                Console.WriteLine(".");
                //// Total de Juros recebido

                composto2 = montante - resultado2;
                Console.WriteLine("Total de Juros recebido : " + composto2);
                Console.WriteLine(".");
                Console.WriteLine(".");
            }

            private static void fiis()
            {
                double habt11 = 125;
                double mxrf11 = 10;
                int cotas1int, cotas2int, investimento;
                double sobra, resultado, cotas1real, deuPraInvestir, total;
                double resultado2, juros2, juros4, composto, composto2, anos, meses, aporte, montante;
                int i;
                double juros1 = 1.16, juros3 = 8;

                Console.WriteLine("Quanto você quer investir no primeiro Mês?");
                investimento = int.Parse(Console.ReadLine());

                cotas1real = (investimento / habt11);
                cotas1int = Convert.ToInt32(cotas1real);

                deuPraInvestir = (cotas1int * habt11);
                sobra = (investimento - deuPraInvestir);
                resultado = (sobra / mxrf11);
                cotas2int = Convert.ToInt32(resultado);
                total = (cotas2int * mxrf11);

                //// apresentação da quantidade de cotas que o investimento inicial comprou
                Console.WriteLine("Se você investir " + investimento + " Reais");
                Console.WriteLine("Você compraria " + cotas1int + " cotas de HABT11.");
                Console.WriteLine(".");
                Console.WriteLine("e o que sobrou daria para comprar também mais " + cotas2int + " cotas de MXRF11.");
                Console.WriteLine(".");
                Console.WriteLine("Total investido de: " + (deuPraInvestir + total) + " Reais");
                Console.WriteLine("a");
                Console.WriteLine("a");
                Console.WriteLine("a");


                //// Aportes Mensais
                Console.WriteLine("Aportando quanto por mês?");
                aporte = double.Parse(Console.ReadLine());

                //// investir por quanto tempo
                Console.WriteLine("Por Quantos anos você deseja investir?");
                anos = double.Parse(Console.ReadLine());

                //// Total investido pelo usuario ao longo de x anos
                meses = (anos * 12);
                resultado2 = ((resultado * mxrf11) + deuPraInvestir * (meses));
                Console.WriteLine("Total investido ao longo de " + anos + " anos");
                Console.WriteLine("R$" + resultado2);

                //// Seu patrimonio seria de.....
                juros2 = juros1 / 100;
                juros4 = juros3 / 100;
                composto = ((resultado * mxrf11) + deuPraInvestir);

                /// juros compostos
                montante = composto * (1 + juros2);
                for (i = 1; i < meses; i++)
                {

                    montante = (montante + aporte) * (1 + juros2);

                    Console.WriteLine(montante);
                }
                montante = Convert.ToInt32(montante);
                Console.WriteLine("Patrimônio acumulado de " + montante);



                //// Total de Juros recebido

                composto2 = montante - resultado2;
                Console.WriteLine("Total de Juros recebido : " + composto2);
            }




        
    }
    
}
