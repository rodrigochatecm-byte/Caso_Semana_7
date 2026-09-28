using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_Semana_7
{
    internal class Program
    {
        static int max = 100;
        static string[] nombres = new string[max];
        static double[] notas = new double[max];
        static int contador = 0;
        static public void Titulo()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("**********-Sistema de Gestion de Notas-**********");
            Console.WriteLine("-------------------------------------------------");
        }
        static public void Registrar_Estudiante()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Registro de Estudiante Nuevo:");
            Console.WriteLine("-------------------------------------------------");
            if(contador == 100)
            {
                Console.WriteLine("El numero que ha ingresado alcazo la capacidad maxima");
                return;
            }
            else
            {
                Console.WriteLine(("El numero que ha ingresado no es valido");
            }
            Console.WriteLine("Ingresar el nombre del estudiante: ");
            string nombre = Console.ReadLine();
            double nota;
            while (true)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Ingresar la nota del estudiante [0-20]:");
                Console.WriteLine("-------------------------------------------------");
                nota = double.Parse(Console.ReadLine());
                if(nota >= 0 && nota <= 20)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("201012011201302103120310201300310301230123013012");
                    Console.WriteLine("Error!!!!!!!, INGRESA DE NUEVO LA NOTA [0-20]");
                    Console.WriteLine("201012011201302103120310201300310301230123013012");
                }
            }
            nombres[contador] = nombre;
            notas[contador] = nota;
            contador++;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("*******-Registro realizado Correctamente-********");
            Console.WriteLine("-------------------------------------------------");
        }
        static public void Buscar_Estudiante()
        {
            
        }
        static void Main(string[] args)
        {

        }
    }
}
