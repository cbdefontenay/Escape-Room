namespace Escape
{
    public class Map : IDrawing
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

        public void Arms()
        {
            Console.WriteLine("          Sword              Axe");
            Console.WriteLine("       /\\                /\\");
            Console.WriteLine("      //\\\\______________//\\\\");
            Console.WriteLine("      \\//              \\//");
            Console.WriteLine("     /(_)              (_)\\");
            Console.WriteLine("   _/(_)\\________________/(_)\\_");
            Console.WriteLine("   |/ \\_|______________|_/ \\|");
            Console.WriteLine("    \\ |/             \\| /");
            Console.WriteLine("     \\|               |/ ");

        }
    }
}
