/*
 * Created by SharpDevelop.
 * User: Virginia
 * Date: 22/03/2021
 * Time: 09:04 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Programa_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			string datos = "";
			int tamaño = 0;
			int edad = 0;
			double peso = 0.0;
			int actividad = 0;
			int opcion = 0;
			double total= 0.0;
			do{
			
				Console.WriteLine("¿Quisiera saber cual es la cantidad de comida que tiene que comer su perro?");
				
				
				Console.WriteLine("¿De que tamaño es su perro?");
				Console.WriteLine("1= Tamaño miniatura");
				Console.WriteLine("2= Tamaño pequeño");
				Console.WriteLine("3= Tamaño mediano");
				Console.WriteLine("4= Tamaño Grande");
				datos= Console.ReadLine();
				tamaño= Convert.ToInt32(datos);
				
				Console.WriteLine("indique la edad de su perro (en meses)");
				datos= Console.ReadLine();
				edad= Convert.ToInt32(datos);
				
				Console.WriteLine("Indique el peso de su perro (en gramos)");
				datos= Console.ReadLine();
				peso= Convert.ToDouble(datos);
				
				total= edad + peso;
					
					if (tamaño==1 && total<13)
				{
					Console.WriteLine("su perro es un Cachorro, tamaño miniatura.");
					Console.WriteLine("¿Como considera la actividad de su mascota?");
                Console.WriteLine("1 - Actividad Alta");
                Console.WriteLine("2 - Actividad Normal");
                Console.WriteLine("3 - Actividad Baja");
                datos = Console.ReadLine();
                actividad= Convert.ToInt32(datos);
                
                 switch (actividad) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 55 - 100 gramos de comida.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 50 - 95 gramos de comida.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 45 -85 gramos de comidaa.");
                            break;
                            
                           default:
                            Console.WriteLine("Esta opcion no fue solicitada");
                            break;
                    }
				}
				
				if (tamaño==1 && total >=13)
				{
					
					Console.WriteLine("Su perro es ya un adulto, tamaño miniatura.");
					Console.WriteLine("¿Como considera la actividad de su mascota?");
                Console.WriteLine("1 - Actividad Alta");
                Console.WriteLine("2 - Actividad Normal");
                Console.WriteLine("3 - Actividad Baja");
                datos = Console.ReadLine();
                actividad= Convert.ToInt32(datos);
				  switch (actividad) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 60 - 115 gramos de comida.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 55 - 95 gramos de comida.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 40 -80 gramos de comidaa.");
                            break;
                              default:
                            Console.WriteLine("Esta opcion no fue solicitada");
                            break;
					}
				}
				if(tamaño==2 && total<20 )
				{
				
				Console.WriteLine("su perro es un Cachorro, tamaño pequeño.");
					Console.WriteLine("¿Como considera la actividad de su mascota?");
                Console.WriteLine("1 - Actividad Alta");
                Console.WriteLine("2 - Actividad Normal");
                Console.WriteLine("3 - Actividad Baja");
                datos = Console.ReadLine();
                actividad= Convert.ToInt32(datos);
                
                 switch (actividad) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 110- 185 gramos de comida.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 95 - 165 gramos de comida.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 8 - 140 gramos de comidaa.");
                            break;
                            
                           default:
                            Console.WriteLine("Esta opcion no fue solicitada");
                            break;
                    }
				
				}
					
				if(tamaño==2 && total>= 20)
				{
				Console.WriteLine("Su perro es ya un adulto, tamaño pequeño.");
				Console.WriteLine("¿Como considera la actividad de su mascota?");
                Console.WriteLine("1 - Actividad Alta");
                Console.WriteLine("2 - Actividad Normal");
                Console.WriteLine("3 - Actividad Baja");
                datos = Console.ReadLine();
                actividad= Convert.ToInt32(datos);
				  switch (actividad) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 115 - 190 gramos de comida.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 100 y 170 gramos de comida.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 85 -145 gramos de comidaa.");
                            break;
                              default:
                            Console.WriteLine("Esta opcion no fue solicitada");
                            break;
					}
				
				}
				
				if (tamaño==3 && total<62)
					{
				Console.WriteLine("Su perro es un cachorro, tamaño mediano.");
				Console.WriteLine("¿Como considera la actividad de su mascota?");
                Console.WriteLine("1 - Actividad Alta");
                Console.WriteLine("2 - Actividad Normal");
                Console.WriteLine("3 - Actividad Baja");
                datos = Console.ReadLine();
                actividad= Convert.ToInt32(datos);
				  switch (actividad) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 185 - 250 gramos de comida.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 165 - 220 gramos de comida.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 140 -190 gramos de comidaa.");
                            break;
                              default:
                            Console.WriteLine("Esta opcion no fue solicitada");
                            break;
					}
				
				}
				if(tamaño== 3 && total>=62)
					{
				Console.WriteLine("Su perro es un adulto, tamaño mediano.");
				Console.WriteLine("¿Como considera la actividad de su mascota?");
                Console.WriteLine("1 - Actividad Alta");
                Console.WriteLine("2 - Actividad Normal");
                Console.WriteLine("3 - Actividad Baja");
                datos = Console.ReadLine();
                actividad= Convert.ToInt32(datos);
				  switch (actividad) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 190 - 255 gramos de comida.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 170 - 225 gramos de comida.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 145 -195 gramos de comidaa.");
                            break;
                              default:
                            Console.WriteLine("Esta opcion no fue solicitada");
                            break;
					}
				
				}
				
				if (tamaño==4 && total< 105)
					{
				Console.WriteLine("Su perro es un cachorro, tamaño grande.");
				Console.WriteLine("¿Como considera la actividad de su mascota?");
                Console.WriteLine("1 - Actividad Alta");
                Console.WriteLine("2 - Actividad Normal");
                Console.WriteLine("3 - Actividad Baja");
                datos = Console.ReadLine();
                actividad= Convert.ToInt32(datos);
				  switch (actividad) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 255 - 380 gramos de comida.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 225 - 330 gramos de comida.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 195 -285 gramos de comidaa.");
                            break;
                              default:
                            Console.WriteLine("Esta opcion no fue solicitada");
                            break;
					}
				}
				
				if (tamaño==4 && total>= 105 || total<200)
					{
				Console.WriteLine("Su perro es un adolescente, tamaño grande.");
				Console.WriteLine("¿Como considera la actividad de su mascota?");
                Console.WriteLine("1 - Actividad Alta");
                Console.WriteLine("2 - Actividad Normal");
                Console.WriteLine("3 - Actividad Baja");
                datos = Console.ReadLine();
                actividad= Convert.ToInt32(datos);
				  switch (actividad) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 380 - 680 gramos de comida.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 330 - 600 gramos de comida.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 285 -520 gramos de comidaa.");
                            break;
                              default:
                            Console.WriteLine("Esta opcion no fue solicitada");
                            break;
					}
				}
					if (tamaño==4 && total>= 200 || total<270)
					{
				Console.WriteLine("Su perro es un adulto, tamaño grande.");
				Console.WriteLine("¿Como considera la actividad de su mascota?");
                Console.WriteLine("1 - Actividad Alta");
                Console.WriteLine("2 - Actividad Normal");
                Console.WriteLine("3 - Actividad Baja");
                datos = Console.ReadLine();
                actividad= Convert.ToInt32(datos);
				  switch (actividad) {
                        case 1:
                            Console.WriteLine("Su perro debe comer entre 680 - 985 gramos de comida.");
                            break;
                        case 2:
                            Console.WriteLine("Su perro debe comer entre 600 - 870 gramos de comida.");
                            break;
                        case 3:
                            Console.WriteLine("Su perro debe comer entre 520 - 750 gramos de comidaa.");
                            break;
                              default:
                            Console.WriteLine("Esta opcion no fue solicitada");
                            break;
					}
				}
					
				 Console.WriteLine("Si desea continuar escriba un numero (excepto 4) de lo contrario escriba 4");
                datos = Console.ReadLine();
                opcion = Convert.ToInt32(datos);
                
                Console.Clear();
                
			
			 }while(opcion !=4);
			
				 }
			}
	
		}
	