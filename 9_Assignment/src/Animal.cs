using PretendUnity;

public abstract class Animal{
    protected Transform _transform;
}

public interface IFriendlyAnimal{
    public void Pet();
}
public interface IHostileAnimal{
    public void Fight();
}

public abstract class HostileAnimal : Animal, IHostileAnimal
{
    public abstract void Fight();
}
public abstract class FriendlyAnimal : Animal, IFriendlyAnimal
{
    public void Pet(){
        Console.WriteLine("Friendly animal was pettet");
    }
}

public class Cow : FriendlyAnimal{

}

public class Lion : HostileAnimal{
    
}