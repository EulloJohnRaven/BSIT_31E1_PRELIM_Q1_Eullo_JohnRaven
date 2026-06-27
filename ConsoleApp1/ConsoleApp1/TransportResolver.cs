namespace TransportChallenge;

public static class TransportResolver
{
    public static Vehicle? Resolve(string input)
    {
        input = input.ToLower();

        if (input == "car")
        {
            return new Car();
        }
        else if (input == "plane")
        {
            return new Airplane();
        }
        else if (input == "boat")
        {
            return new Boat();
        }
        else if (input == "helicopter")
        {
            return new Helicopter();
        }
        else
        {
            return null;
        }
    }
}