using RPGDio.src.Entities;

namespace RPGDio
{
  class Program
  {
  
    static void Main(string[] args)
    {
      Hero hero = new Hero("Arus", 23, "Knight");
      Hero oponent = new Hero("Maleficus", 99, "Devil");
      Wizard oponent2 = new Wizard("Jennica", 23, "White Wizard");
      
      Console.WriteLine(hero.Attack());
      Console.WriteLine(oponent2.Attack(7));
    }
  }
}