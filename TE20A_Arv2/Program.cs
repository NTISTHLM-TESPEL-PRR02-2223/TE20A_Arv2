Jedi obiwank = new Jedi();

List<Weapon> weapons = new();

weapons.Add(new Bow());
weapons.Add(new Sword());

foreach ( Weapon w in weapons)
{
  Console.WriteLine(w.Name);
  if (w is Bow)
  {
    Console.WriteLine(" ...And hopefully it has some arrows");
  }
}


Console.ReadLine();
