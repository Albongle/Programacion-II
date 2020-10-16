﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Ejercicio_N43
{
    class Program
    {
        static void Main(string[] args)
        {
            Random azar = new Random();
            Competencia formulaUno = new Competencia(10, 5, Competencia.TipoCompetencia.F1);
            AutoF1[] autos = new AutoF1[10];
            MotoCross moto = new MotoCross((short)10, azar.Next(1, 5).ToString());

            for (int i = 0; i < autos.Length; i++)
            {
                autos[i] = new AutoF1((short)i, azar.Next(1, 5).ToString());

                                    
                    if ((formulaUno + autos[i]))
                    {
                        Console.WriteLine("Se Agrego el siguiente auto a la competencia: {0}", autos[i].MostrarDatos());
                    }
                    else
                    {
                        Console.WriteLine("No se agrego ya que la competencia esta completa: {0}", autos[i].MostrarDatos());
                    }
            }
            try
            {
                if(formulaUno+moto)
                {

                }
            }
            catch(CompetenciaNoDisponibleException ex)
            {
                Console.WriteLine();
                Console.WriteLine("<---------------------------------Execpcion--------------------------------->");
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("<-------------------------------------------------------------------------------------------------->");
            Console.WriteLine(formulaUno.MostrarDatos());

            Console.ReadKey();
        }
    }
}
