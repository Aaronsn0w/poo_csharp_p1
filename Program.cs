using System;

namespace poo_csharp_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(holaEstudiante());
            // numerosDelUnoAlCincuenta();
            numerosRandom();
            Console.ReadKey();
        }

        static string holaEstudiante()
        {
            string msg = "Hola, estudiante Emilio. Bienvenido a programación I";
            return msg;
        }

        static void numerosDelUnoAlCincuenta()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void numerosRandom()
        {
            string oportunidad;
            int max = 6;
            Random random = new Random();
            Console.Write("Numero Aleatorio: ");
            for (int i = 0; i <= max; i++)
            {
                Console.WriteLine(random.Next(100));
                if (i != max)
                {
                    Console.WriteLine("Generar Otro Numero: si, no");
                    oportunidad = Console.ReadLine().ToLower();
                    if (oportunidad == "si")
                    {
                        Console.Write("Nuevo Numero Aleatorio: ");
                    }
                    else if (oportunidad == "no")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Opcion Incorrecta Terminando Aplicacion");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Se Terminaron Todas Las Oportunidades");

                }

            }
        }

    }

    class Vehiculo
    {
        string Marca;
        string Modelo;
        int Ano;
        string Color;
        string estado = "apagado";

        public string obtenerInformacion(){
            return "Marca: "+Marca+"Modelo: "+Modelo+"Año: "+Ano+"Color: "+Color+"Estado: "+estado;
        }
        public void cambiarEstado(){
            if(estado == "apagado"){
                estado = "encendido";
            }else{
                estado = "apagado";
            }
        }
    }

    class VerProducto {
        static void Principal() {
        Producto primer_producto = new Producto();
        primer_producto.agregarNombre("Disco Duro");

        }
    }

}
