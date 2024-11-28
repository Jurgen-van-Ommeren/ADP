namespace ADP.TestObjects;

public class Pizza : IComparable<Pizza>
{
    public string Name { get; set; }
    public int Slices { get; set; }

    public int CompareTo(Pizza comparingPizza)
    {
        if (Slices > comparingPizza.Slices)
        {
            return 1;
        }

        if (Slices < comparingPizza.Slices)
        {
            return -1;
        }

        return 0;
    }
}