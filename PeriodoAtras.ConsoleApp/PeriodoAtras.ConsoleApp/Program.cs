using System;

namespace PeriodoAtras.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Visualizar();
        }
        static void Visualizar()
        {
            DateTime data = Inserir();
            double dias = CalcularPeriodoAtras(data);
            Console.WriteLine("Data atual" + DateTime.Now + " - " + "Data: " + data.ToString("dd/MM/yyyy") + " = " + DiasPorEscrito(dias) + " atrás({0})", Math.Round(dias, 2));
            Console.ReadLine();
        }

        static string DiasPorEscrito(double dias)
        {
            string diasPorEscrito = "";
            if(dias >= 1 && dias < 2)
            {
                diasPorEscrito = "Um dia";
            }else if(dias >= 2 && dias < 3)
            {
                diasPorEscrito = "Dois dias";
            }
            else if (dias >= 3 && dias < 4)
            {
                diasPorEscrito = "Três dias";
            }
            else if (dias >= 4 && dias < 5)
            {
                diasPorEscrito = "Quatro dias";
            }
            else if (dias >= 5 && dias < 6)
            {
                diasPorEscrito = "Cinco dias";
            }
            else if (dias >= 6 && dias < 7)
            {
                diasPorEscrito = "Seis dias";
            }
            else if (dias >= 7 && dias < 14)
            {
                diasPorEscrito = "Uma semana";
            }else if (dias >= 14 && dias < 21)
            {
                diasPorEscrito = "Duas semanas";
            }
            else if (dias >= 21 && dias < 28)
            {
                diasPorEscrito = "Três semanas";
            }
            else if (dias >= 28 && dias < 30)
            {
                diasPorEscrito = "Quatro semanas";
            }
            else if (dias == 30)
            {
                diasPorEscrito = "Um mês";
            }
            else if (dias >= 30 && dias <= 365)
            {
                diasPorEscrito = "Mais de um mês";
            }
            else if (dias == 365)
            {
                diasPorEscrito = "Um ano";
            }
            else if (dias >= 3.650)
            {
                diasPorEscrito = "Dez anos";
            }
            return diasPorEscrito;
        }

        static DateTime Inserir()
        {
            Console.WriteLine("Informe a data");
            DateTime data = Convert.ToDateTime(Console.ReadLine());
            return data;
        }

        static double CalcularPeriodoAtras(DateTime data)
        {
            TimeSpan diferenca = DateTime.Now - data;
            double dias = diferenca.TotalDays;

            double segundos = diferenca.TotalSeconds;
            double minutos = diferenca.TotalMinutes;
            double horas = diferenca.TotalHours;
 
            return dias;
        }
    }
}
