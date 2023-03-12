namespace Encontro_Remoto.classes
{
    public static class Utils
    {

        public static void BarraCarregamento(string texto)
        {
            Console.Write($"{texto}");
            Console.ForegroundColor = ConsoleColor.Red;
            for (var contador = 0; contador < 6; contador++)
            {

                Console.Write($"**");
                Thread.Sleep(500);
            }

            Console.ResetColor();

        }


    }
}