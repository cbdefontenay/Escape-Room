namespace Escape
{
    public class Map: IDrawing
    {
        public void Cart()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("|               |");
            Console.WriteLine("|               |");
            Console.WriteLine("|       o       |");
            Console.WriteLine("|      -|-      |");
            Console.WriteLine("|      / \\      |");
            Console.WriteLine("|               |");
            Console.WriteLine("|               |");
            Console.WriteLine("-----------------");
        }

        public void OldMan()
        {
        Console.WriteLine("     / \\");
        Console.WriteLine("    /   \\");
        Console.WriteLine("   | o o |");
        Console.WriteLine("   |  ^  |");
        Console.WriteLine("   | \\_/ |");
        Console.WriteLine("   \\_____/");
        Console.WriteLine("     |||");
        Console.WriteLine("    /|||\\");
        Console.WriteLine("   / ||| \\");
        Console.WriteLine("      |||");
        }

        public void Tree()
        {
        Console.WriteLine("      /\\");
        Console.WriteLine("     /  \\");
        Console.WriteLine("    /    \\");
        Console.WriteLine("   /______\\");
        Console.WriteLine("    /    \\");
        Console.WriteLine("   /      \\");
        Console.WriteLine("  /________\\");
        Console.WriteLine("      ||");
        }

        public void Guards()
        {
        Console.WriteLine("          ||                ||  ");
        Console.WriteLine("          ||                ||  ");
        Console.WriteLine("          ||                ||  ");
        Console.WriteLine("          ||                ||  ");
        Console.WriteLine("   _______||   _________    ||__");
        Console.WriteLine("  / Guard ||  /  Guard  \\    ||  ");
        Console.WriteLine(" |    A   ||  |    B     |  ||  ");
        Console.WriteLine("  \\_______/  ||\\_______/      ||  ");
        Console.WriteLine("          ||                ||  ");
        Console.WriteLine("          ||                || /");
        }
    }
}
