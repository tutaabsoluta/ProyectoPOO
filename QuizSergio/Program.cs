using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSergio
{
    internal class Program
    {
        static void Main(string[] args)//metodo principal
        {
            calcularNotas();//llamado del metodo calcularNotas
        }
        static void calcularNotas()//metodo calcularNotas
        {
            float q1, q2, t1, t2, e1, e2, p, nF;/*declaracion de las variables locales
                                                 la nomenclatura es q para Quiz, t para Tarea, e para Examen y p para Proyecto */


            //se solicita al usuario ingresar las notas de las evaluaciones
            Console.WriteLine("Ingrese los puntos obtenidos el el Quiz 1");
            q1 = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Ingrese los puntos obtenidos el el Quiz 2");
            q2 = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Ingrese los puntos obtenidos el la Tarea 1");
            t1 = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Ingrese los puntos obtenidos el la Tarea 2");
            t2 = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Ingrese los puntos obtenidos el el Examen 1");
            e1 = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Ingrese los puntos obtenidos el el Examen 2");
            e2 = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Ingrese los puntos obtenidos el el Proyecto");
            p = float.Parse(Console.ReadLine());
            Console.Clear();

            //formulas utilizadas para calcular las notas de las asignaciones
            q1 = q1 * 100 / 15;
            q2 = q2 * 100 / 15;
            t1 = t1 * 100 / 35;
            t2 = t2 * 100 / 35;
            e1 = e1 * 100 / 55;
            e2 = e2 * 100 / 55;
            p = p * 100 / 45;

            //lineas de codigo que muestrabn en pantalla las notas obtenidas
            Console.WriteLine("La nota del Quiz 1 es: " + q1);
            Console.WriteLine("La nota del Quiz 1 es: " + q2);
            Console.WriteLine("La nota de la Tarea 1 es: " + t1);
            Console.WriteLine("La nota de la Tarea 2 es: " + t2);
            Console.WriteLine("La nota del Examen 1 es: " + e1);
            Console.WriteLine("La nota del Examen 2 es: " + e2);
            Console.WriteLine("La nota del Proyecto es: " + p);

            //formula utilizada para calcular la nota final
            nF = (q1 + q2 + t1 + t2 + e1 + e2 + p) / 7;

            //flujo de control para determinar s un estudiante es aprobado, reprobado o si este deserto
            if (nF >= 70)
            {
                Console.WriteLine("La nota final del estudiante es: " + nF + " y la condicion es aprobado");
            }

            if (nF <= 50 && nF < 70)
            {
                Console.WriteLine("La nota final es: " + nF + " y la condicion es reprobado");
            }

            if (nF < 50)
            {
                Console.WriteLine("La nota final es: " + nF + " y la condicion es deserto");
            }
            Console.ReadLine();//se usa a manera de pausa (Esperar tecla)
            calcularNotas();
        }
    }
}

