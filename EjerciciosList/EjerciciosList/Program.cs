using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosList
{
    class Program
    {

        //Ejercicio1:

        //static void Main(string[] args)
        //{

        //    List<string> compra = new List<string>();

        //    CrearLista(compra);
        //    MostrarLista(compra);
        //    OrdenarLista(compra);
        //    BorrarDeLista(compra);
        //    ContarElementos(compra);


        //    Console.ReadLine();

        //}
        //public static void CrearLista(List<string>compra)
        //{
        //    compra.Add("Vino");
        //    compra.Add("Croquetas");
        //    compra.Add("Aceite");
        //    compra.Add("Sal");
        //    compra.Add("Azucar");
        //}

        //public static void MostrarLista(List<string> compra)
        //{
        //    foreach (String x in compra)
        //    {
        //        Console.WriteLine("La lista de la compra es: " + x);
        //    }


        //}

        //public static void OrdenarLista(List<string> compra)
        //{
        //    compra.Sort();
        //    foreach (String x in compra)
        //    {
        //        Console.WriteLine("La lista de la compra ordenada " + x);
        //    }
        //}

        //public static void BorrarDeLista(List<string> compra)
        //{
        //    compra.IndexOf("Vino");
        //    compra.Remove("Vino");
        //    foreach (String x in compra)
        //    {
        //        Console.WriteLine("La nueva lista de la compra es: " + x);
        //    }
        //}

        //public static void ContarElementos(List<string> compra)
        //{
        //    Console.WriteLine("El numero de elemento de la compra es: " + compra.Count);
        //}


        //Ejercicio 2

        //static void Main(string[] args)
        //{
        //    double num;
        //    List<double> dec = new List<double>();
        //    List<int> numint = new List<int>();
        //    //List<double> union = new List<double>();

        //    bool Neg = false;
        //    while (Neg == false)
        //    {
        //        Console.WriteLine("Introduzca un numero");
        //        try
        //        {
        //            num = Convert.ToDouble(Console.ReadLine());
        //            string respuesta = num.ToString();

        //            if (num < 0)
        //            {
        //                Neg = true;
        //            }

        //            else if (respuesta.Contains(","))
        //            {
        //                dec.Add(num);
        //            }
        //            else
        //            {
        //                int enteroIntr = Convert.ToInt32(num);
        //                numint.Add(enteroIntr);
        //            }
        //        }
        //        catch (FormatException ex)
        //        {
        //            Console.WriteLine("El valor introducido no es un numero");
        //        }
        //    }


        //    MuestraNum(dec, numint);
        //    MuestraSum(numint);
        //    MuestraMedia(dec, numint);

        //    Console.ReadLine();

        //}

        //public static void MuestraNum(List<double> dec, List<int> numint)
        //{
        //    Console.WriteLine("El numero de decimales es: " + dec.Count + " y el nuemro de enteros es: " + numint.Count);
        //}
        //public static void MuestraSum(List<int> numint)
        //{
        //    Console.WriteLine("La suma de los numeros enteros es: " + numint.Sum());
        //}
        //public static void MuestraMedia(List<double> dec, List<int> numint)
        //{
        //    double Media = ((numint.Sum() + dec.Sum()) / (numint.Count + dec.Count));
        //    Console.WriteLine("La media de todos los numeros es: " + Media);
        //}

        //Ejercicio 4:
        static void Main(string[] args)
        {
            CantanteFamoso cf1 = new CantanteFamoso("Bon Jovi", "These days");
            CantanteFamoso cf2 = new CantanteFamoso("AC/DC", "Thunderball");
            CantanteFamoso cf3 = new CantanteFamoso("Loquillo", "Ritmo del Garaje");
            CantanteFamoso cf4 = new CantanteFamoso("HIM", "Dark Love");
            CantanteFamoso cf5 = new CantanteFamoso("Amaral", "Hacia lo Salvaje");


            List<CantanteFamoso> listasCantantesFamosos = new List<CantanteFamoso>();
            listasCantantesFamosos.Add(cf1);
            listasCantantesFamosos.Add(cf2);
            listasCantantesFamosos.Add(cf3);
            listasCantantesFamosos.Add(cf4);
            listasCantantesFamosos.Add(cf5);


            foreach (CantanteFamoso x in listasCantantesFamosos)
            {
                //Accedo a cada atributo de cada objeto Cuenta
                Console.WriteLine("El cantante " + x.GetName() + " tiene el disco con más ventas: " + x.Getdiscos());
            }

            try
            {
                int valor;
                do
                {
                    Console.WriteLine("Lista de Cantantes Famosos");
                    Console.WriteLine("1. Insertar Cantante");
                    Console.WriteLine("2. Salir");
                    valor = Convert.ToInt32(Console.ReadLine());

                    switch (valor)
                    {
                        case 1:
                            Console.WriteLine("Inserte Nombre de Cantante/Banda");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("Inserte Disco mas vendido");
                            string disco = Console.ReadLine();

                            listasCantantesFamosos.Add(new CantanteFamoso(nombre, disco));

                            foreach (CantanteFamoso x in listasCantantesFamosos)
                            {

                                Console.WriteLine("El cantante " + x.GetName() + " tiene el disco con más ventas: " + x.Getdiscos());
                            }

                            break;
                        case 2:
                            Console.WriteLine("Hasta otra");
                            break;

                    
                } while (valor != 2);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("El valor introducido no es un numero");
            }
            

            Console.ReadLine();
        }
    }
}
