using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(IPrintable printable)  // Cambio "Recipe" por la nueva interfaz IPrintable.
        {
            File.WriteAllText("Recipe.txt", printable.GetTextToPrint());
        }
    }
}