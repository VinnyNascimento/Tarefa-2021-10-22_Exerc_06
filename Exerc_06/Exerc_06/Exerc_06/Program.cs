using System;

namespace Exerc_06
{
    class Program
    {
        static void Main(string[] args)
        {
            #region declarações & instâncias
            Calculo s;
            s = new Calculo();
            #endregion

            #region Introducao
            Console.Write("Converta Milhas Marítimas em quilômetros (km)");
            Console.ReadLine();
            #endregion

            #region entrada
            Console.Write("Informe o valor em milha marítima: ");
            s.setNum1(double.Parse(Console.ReadLine()));
            #endregion

            #region processo
            s.calcular();
            #endregion

            #region saída
            Console.WriteLine("O valor {0} em milhas marítimas é: {1} quilometros (km)", s.getNum1(), s.getResultado());
            #endregion
        }
    }
}