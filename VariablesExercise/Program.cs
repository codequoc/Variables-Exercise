namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Rachel";
            int age = 26;
            char lastInitial = 'J';
            bool isFemale = true;
            double loans = 400.65;
            decimal height = 5.9m;
            Console.WriteLine($"My friend's name is {name}, and she is {age} years old. Her last initial is {lastInitial}, and is {height} feet tall. She is a female which is {isFemale}. She owns some student debt and has ${loans} left.");
        }
    }
}
