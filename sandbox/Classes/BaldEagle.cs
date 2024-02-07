class BaldEagle : Animal{

    public BaldEagle(string name, string sound) : base(name, sound){

    }



    public override void MakeSound(){
        Console.WriteLine($"{this.name} says: {this.sound}");
    }
}