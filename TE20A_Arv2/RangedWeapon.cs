
public class RangedWeapon: Weapon
{
  public int Range { get; set; } = 10;

  public RangedWeapon()
  {
    Damage = 15;
  }

  public override void Attack(Character target)
  {
    Console.WriteLine("Ranged attack!");
    Random generator = new Random();
    target.Hitpoints -= generator.Next(Damage);
  }
}
