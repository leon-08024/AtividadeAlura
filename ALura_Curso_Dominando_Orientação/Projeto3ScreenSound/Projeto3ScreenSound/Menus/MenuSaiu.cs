using Screensound.Modelos;

namespace Screensound.Menus
{
    internal class MenuSaiu : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("       Tchau :]      ");
    

        }

    }
}
