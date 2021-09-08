using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        /// <summary>
        /// Esta clase fue creada para mantener el principio SRP, ya que en un principio
        /// quien se encargaba de cumplir con esta responsabilidad era la clase Recipe,
        /// pero al momento de considerar en un futuro la necesidad de que se deba
        /// imprimir estos datos en un sistema distinto del de la consola podemos hallar
        /// un motivo para cambiar, la clase ya tuvo un motivo para cambiar previo que fue
        /// calcular el gasto total, por esto es que se viola el principio y que debemos
        /// crear una nueva clase ConsolePrinter que se encargue de esta responsabilidad.
        /// 
        /// El beneficio de sacar dicha responsabilidad de recipe es que para distintas
        /// formas de impresion se pueden crear nuevas clases sin tener que modificar las
        /// ya existentes.
        /// 
        /// La clase ConsolePrinter colabora con Recipe quien ya posee el texto armado.
        /// </summary>
        /// <param name="recipe"></param>
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetRecipeText());
        }
    }
}