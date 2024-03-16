namespace patterns
{
  class Client
  {
    public static void ClientMethod(IUnitsFactory unitsFactory)
    {
      var tank = unitsFactory.CreateTank();
      var soldier = unitsFactory.CreateSoldier();

      System.Console.WriteLine(tank.GetInfo() + "\n" + soldier.GetInfo());
    }
  }
}