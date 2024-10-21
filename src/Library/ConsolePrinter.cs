using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter   
    {
        public void PrintRecipe(IPrintable printable)
        {
            Console.WriteLine(printable.GetTextToPrint());
        }
    }
    
    // ConsolePrinter ya no depende de Recipe.
}