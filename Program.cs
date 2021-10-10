using System;
using System.Linq;
using System.Text;

namespace EjerciciosCapitulo8
{
    class Program
    {
        public static void Imprime(String datos) // Metodo para imprimir con un linea de por medio
        {
            Console.WriteLine("{0}", datos);
        }

        public static String lee(String dato) // MEtodo para leer cadenas
        {
            dato = Console.ReadLine();

            return dato;
        }

        public static int Toint(string dato) // Metodo para convertir cadenas a enteros
        {
            int retorno = 0;
            int.TryParse(dato, out retorno);

            return retorno;
        }

        //Este es el ejercicio 3 del capitulo 8
        public static String Ejercicio3()
        {
            DateTime FechaActual = new();
            string fecha = "";

            FechaActual = DateTime.Now;

            fecha = String.Format("La hora y fecha actual es {0: hh: mm: ss tt yyyy / dd / MMMM}", FechaActual);

            Console.WriteLine(fecha);

            return fecha;
        }

        //Este es el ejercicio 5 del capitulo 8
        public static void Ejercicio5()
        {
            String Cadena1 = "";
            String Cadena2 = "";

            Imprime("Digite la primera Cadena:");
            Cadena1 = Console.ReadLine();
            Imprime("Digite la segunda Cadena:");
            Cadena2 = Console.ReadLine();

            if (Cadena1.CompareTo(Cadena2) < 0)
            {
                Imprime("\nCadenas ordenadas alfabeticamente\n");
                Imprime(Cadena1);
                Imprime(Cadena2);
            }
            else if (Cadena1.CompareTo(Cadena2) == 0)
            {
                Imprime("\nCadenas ordenadas alfabeticamente\n");
                Imprime(Cadena1);
                Imprime(Cadena2);
            }
            else if (Cadena1.CompareTo(Cadena2) > 0)
            {
                Imprime("\nCadenas ordenadas alfabeticamente\n");
                Imprime(Cadena2);
                Imprime(Cadena1);
            }
        }


        //Este es el ejercicio 1 del capitulo 9
        public struct Productos
        {
            public string nombre;
            public int codigo;
            public float precio;
            public int cantidad;

            public Productos(String pNombre, int pCodigo, float pPrecio, int pCantidad)
            {
                nombre = pNombre;
                if (pCodigo < 0)
                    pCodigo *= -1;
                codigo = pCodigo;


                if (pPrecio < 0)
                    pPrecio *= -1;
                precio = pPrecio;

                if (pCantidad < 0)
                    pCantidad *= -1;

                cantidad = pCantidad;

            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("\nCodigo: {0}\nNombre: {1} \nCantidad: {2}\nPrecio: {3}", codigo, nombre, cantidad, precio);

                return (sb.ToString());
            }

        }
        public static void Ejercicio1()
        {
            Productos[] productos = new Productos[3];

            productos[0].codigo = 1;
            productos[0].nombre = "Zapato";
            productos[0].precio = 795;
            productos[0].cantidad = 100;

            productos[1].codigo = 2;
            productos[1].nombre = "Vestido";
            productos[1].precio = 650;
            productos[1].cantidad = 150;

            productos[2].codigo = 3;
            productos[2].nombre = "Cartera";
            productos[2].precio = 1500;
            productos[2].cantidad = 50;

            Console.WriteLine(productos[0].ToString());
            Console.WriteLine(productos[1].ToString());
            Console.WriteLine(productos[2].ToString());

        }

        //Ejercicio 3 del capitulo 9
        public struct Mascota
        {
            public string nombre;
            public string tipo;
            public string raza;
            public int edad;
            public Persona propietario;

            public Mascota(string mNombre, string mTipo, string mRaza, int mEdad, string pNombre, string pTelefono)
            {
                nombre = mNombre;
                tipo = mTipo;
                raza = mRaza;
                edad = mEdad;

                propietario = new Persona(pNombre, pTelefono);
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("\nNombre: {0}\nTipo: {1} \nRaza: {2}\nEdad: {3} año(s)\n" + propietario.ToString(), nombre, tipo, raza, edad);

                return (sb.ToString());
            }
        }

        public struct Persona
        {
            public string nombre;
            public string telefono;

            public Persona(string pNombre, string pTelefono)
            {
                nombre = pNombre;
                if (pTelefono.Length == 10)
                    telefono = pTelefono;
                else
                    telefono = "Telefono no valido";
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("\nDueño: {0}\nTelefono Dueño: {1}", nombre, telefono);

                return (sb.ToString());
            }
        }

        public static void Ejercicio3Cap9()
        {
            Mascota mascota = new Mascota("Doffy", "Perro", "Chihuawa", 1, "Frankelyn Garcia", "(829)-986-3213");

            Console.WriteLine(mascota.ToString());
        }

        //Ejercicio 4 del capitulo 9
        enum Neumaticos {Todo_terreno, de_invierno, de_pista, Deportivos, Todo_tiempo, de_verano, Anti_Pinchazo};

        public static void Ejercicio4Cap9()
        {
            Neumaticos[] neumaticos = new Neumaticos[7];

            neumaticos[0] = Neumaticos.Anti_Pinchazo;
            neumaticos[1] = Neumaticos.Deportivos;
            neumaticos[2] = Neumaticos.de_invierno;
            neumaticos[3] = Neumaticos.de_pista;
            neumaticos[4] = Neumaticos.de_verano;
            neumaticos[5] = Neumaticos.Todo_terreno;
            neumaticos[6] = Neumaticos.Todo_tiempo;

            for (int i=0; i<7; i++)
            {
                Console.WriteLine("Neumatico {0}\n", neumaticos[i]);
            }
        }




        static void Main(string[] args)
        {
            string valor = "";

            int opcion = 0;
            int opcion2 = 0;
            int opcion3 = 0;

            do
            {
                Imprime("Ejericios del capitulo 8 y 9");
                Imprime("\nMenu de opciones");
                Imprime("1) Ver ejercicios del capitulo 8");
                Imprime("2) Ver ejercicios del capitulo 9");
                Imprime("3) Salir");
                opcion = Toint(lee(valor));

                switch (opcion)
                {
                    case 1:
                        {
                            do
                            {
                                Imprime("\nEjercicios capitulo 8");
                                Imprime("\nMenu de opciones");
                                Imprime("1) Ver ejercicio 3");
                                Imprime("2) Ver ejericio 5");
                                Imprime("3) Salir");
                                opcion2 = Toint(lee(valor));

                                switch (opcion2)
                                {
                                    case 1:
                                        {
                                            Imprime("\nEjercicio 3 - Hacer un programa que muestre la hora del día en formato AM / FM seguida del año, el día y el mes actual.\n");
                                            Ejercicio3();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Imprime("\nEjercicio 5 - Hacer un programa que le solicite al usuario dos cadenas y luego las muestre en orden alfabético.\n");
                                            Ejercicio5();
                                            break;
                                        }
                                    case 3:
                                        {
                                            break;
                                        }
                                    default:
                                        {
                                            Imprime("\nOpcion no valida");
                                            break;
                                        }
                                }
                            } while (opcion2 != 3);

                            break;
                        }
                    case 2:
                        {
                            do
                            {
                                Imprime("\nEjercicios capitulo 9");
                                Imprime("\nMenu de opciones");
                                Imprime("1) Ver ejercicio 1");
                                Imprime("2) Ver ejericio 3");
                                Imprime("3) Ver ejercicio 4");
                                Imprime("4) Salir");
                                opcion3 = Toint(lee(valor));

                                switch (opcion3)
                                {
                                    case 1:
                                        {
                                            Imprime("\nEjercicio 1 - Crear una estructura para guardar los productos de una tienda.\n");
                                            Ejercicio1();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Imprime("\nEjericio 3 - Crear estructuras enlazadas para guardar la información de una mascota y su dueño.");
                                            Ejercicio3Cap9();
                                            break;
                                        }
                                    case 3:
                                        {
                                            Imprime("\nEjercicio 4 - Crear una enumeración para los diferentes tipos de neumáticos.\n");
                                            Ejercicio4Cap9();
                                            break;
                                        }
                                    case 4:
                                        {
                                            break;
                                        }
                                    default:
                                        {
                                            Imprime("\nOpcion no valida");
                                            break;
                                        }
                                }
                            } while (opcion3 != 4);

                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    default:
                        {
                            Imprime("\nOpcion no valida");
                            break;
                        }
                }


            } while (opcion != 3);
        }
    }
}
