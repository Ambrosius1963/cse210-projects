public class Ingredient
{
    public string Name { get; set; }
    public string Quantity { get; set; }
    public string Unit { get; set; }

    public override string ToString()
    {
        return $"{Quantity} {Unit} of {Name}";
    }
}