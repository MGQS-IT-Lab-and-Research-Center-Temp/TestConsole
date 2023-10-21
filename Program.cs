
string[] cars = new string[] { "Lamborghini", "Rolls Royce", "Bugatti Veronni", "Ferrari", "Tesla" };

try
{
    List<string> names = new() { "Ahmad Raza", "Abdul Tawwab", "Hasbiyallah" };

    List<int> numbers = new() { 15 };

    if (names.Count >= 3)
    {
        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine(names[i] + " is " + numbers[i] + " years old");
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
