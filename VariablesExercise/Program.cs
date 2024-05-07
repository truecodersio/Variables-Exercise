namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {           
            /*
             * Assignment: declare and initialize variables for the following types:
             * string
             * int
             * char
             * bool
             * double
             * decimal 
             */

            string dogName = "Ralph";
            int dogAge = 9;
            char firstInital = dogName[0];
            double foodAmount = 0.25;
            decimal milesWalkDaily = 1.50m;
            bool truth = false;


            Console.WriteLine($"My dog's name is {dogName}, He is {dogAge} years old. He eats {foodAmount} cup of food per meal. We go for a walk of {milesWalkDaily} daily.  This above statment is all true: {truth}");
            Console.ReadLine();
        }
    }
}
