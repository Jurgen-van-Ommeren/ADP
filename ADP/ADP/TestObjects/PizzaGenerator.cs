namespace ADP.TestObjects;

public class PizzaGenerator
{
    private static Random random = new Random();

    public static Pizza[] GenerateRandomPizzas(int numberOfPizzas)
    {
        Pizza[] pizzas = new Pizza[numberOfPizzas];

        for (int i = 0; i < numberOfPizzas; i++)
        {
            pizzas[i] = new Pizza
            {
                Name = GenerateRandomName(),
                Slices = random.Next(4, 13)
            };
        }

        return pizzas;
    }

    private static string GenerateRandomName()
    {
        int nameLength = random.Next(5, 10);
        char[] name = new char[nameLength];

        for (int i = 0; i < nameLength; i++)
        {
            name[i] = (char)random.Next('A', 'Z' + 1);
        }

        return new string(name);
    }
}