namespace patterns
{
  public interface IUnitsFactory
  {
    IAbstractTank CreateTank();

    IAbstractSoldier CreateSoldier();
  }

  class HumanFactory : IUnitsFactory
  {
    public IAbstractTank CreateTank()
    {
      return new HumanTank();
    }

    public IAbstractSoldier CreateSoldier()
    {
      return new HumanSoldier();
    }
  }

  class AlienFactory : IUnitsFactory
  {
    public IAbstractTank CreateTank()
    {
      return new AlienTank();
    }

    public IAbstractSoldier CreateSoldier()
    {
      return new AlienSoldier();
    }
  }

  public interface IAbstractTank
  {
    public int Health { get; }
    public int Defence { get; }
    public int Attack { get; }
    public string GetInfo();
  }

  class HumanTank : IAbstractTank
  {
    public int Health { get => 100; }
    public int Defence { get => 10; }
    public int Attack { get => 18; }
    public string GetInfo() => $"Human Tank: {Health} HP, {Attack} attack, {Defence} defence";
  }

  class AlienTank : IAbstractTank
  {
    public int Health { get => 120; }
    public int Defence { get => 6; }
    public int Attack { get => 20; }
    public string GetInfo() => $"Alien Tank: {Health} HP, {Attack} attack, {Defence} defence";
  }

  public interface IAbstractSoldier
  {
    public int Health { get; }
    public int Attack { get; }
    public string GetInfo();
  }

  class HumanSoldier : IAbstractSoldier
  {
    public int Health { get => 60; }
    public int Attack { get => 36; }
    public string GetInfo() => $"Human Soldier: {Health} HP, {Attack} attack";
  }

  class AlienSoldier : IAbstractSoldier
  {
    public int Health { get => 38; }
    public int Attack { get => 50; }
    public string GetInfo() => $"Alien Soldier: {Health} HP, {Attack} attack";
  }

}