namespace Full_GRASP_And_SOLID
{
    public interface IPrinter                    // Modifico IPrinter para que se amolde a IPrintable
    {
        void PrintRecipe(IPrintable printable);
    }
}
