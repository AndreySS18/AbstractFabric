namespace patterns
{
  class Program
  {
    static int Menu()
    {
      Console.WriteLine("1. Create Human army!\n" +
          "2. Create Alien army!\n" +
          "3. Exit.");

      int choise = 0;
      bool num = false;
      while (!num)
      {
        Console.WriteLine("Введите число!");
        num = Int32.TryParse(Console.ReadLine(), out choise);
        if (choise < 1 || choise > 3)
        {
          num = false;
          Console.WriteLine("Нет такого варианта!");
        }
      }
      Console.Clear();
      return choise;
    }

    static void Main(string[] args)
    {
      while (true)
      {
        switch (Menu())
        {
          case 1:
            Client.ClientMethod(new HumanFactory());

            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            break;

          case 2:
            Client.ClientMethod(new AlienFactory());

            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
            Console.Clear();
            break;

          case 3:
            Environment.Exit(0);
            break;
        }
      }
    }
  }
}