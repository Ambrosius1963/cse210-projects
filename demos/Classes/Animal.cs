public abstract class Animal{

    public string name;
    public string sound;

    public Animal(string name, string sound) {
        this.name = name;
        this.sound = sound;

    }

    public virtual void MakeSound() {
        Console.WriteLine("**Deep Guttural Rawer**");
    }

}