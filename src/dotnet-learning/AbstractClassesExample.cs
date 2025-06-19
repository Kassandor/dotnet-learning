namespace dotnet_learning;

internal static class Player
{
    public static void Fire(Weapon weapon)
    {
        weapon.Fire();
    }

    public static void CheckInfo(Weapon weapon)
    {
        weapon.ShowInfo();
    }
}

internal abstract class Weapon
{
    protected abstract int Damage { get; }
    public abstract void Fire();
    public void ShowInfo()
    {
        Console.WriteLine($"{GetType().Name} Damage: {Damage}");
    }
}

internal class WeaponGun : Weapon
{
    protected override int Damage => 5;

    public override void Fire()
    {
        Console.WriteLine("WeaponGun Fire!");
    }
}