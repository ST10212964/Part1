using System;




 
    class Program
    {
        static void Main(string[] args)
        {
             var recipe = new Methods();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nRecipe Application");
                Console.WriteLine("1 - Enter Recipe Details");
                Console.WriteLine("2 - Display Recipe");
                Console.WriteLine("3 - Scale Recipe");
                Console.WriteLine("4 - Reset Quantities");
                Console.WriteLine("5 - Clear Recipe");
                Console.WriteLine("6 - Exit");

                //Promt user to select an option using only the numeric value of the options
                Console.Write("Choose an option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        recipe.RecipeDetails();
                        break;
                    case 2:
                        recipe.DisplayRecipe();
                        break;
                    case 3:
                        recipe.ScaleRecipe();
                        break;
                    case 4:
                        recipe.ResetQuantities();
                        break;
                    case 5:
                        recipe.ClearRecipe();
                        break;
                    case 6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        

        }

   

    public class Ingredient
    {
        public string Name { get; }
        public double Quantity { get; }
        public string Unit { get; }

        public Ingredient(string ingredientName, double ingredientQuantity, string ingredientUnit)
        {
            Name = ingredientName;
            Quantity = ingredientQuantity;
            Unit = ingredientUnit;
        }
    }

    public class Methods(){

    
        //Declare ingredients and steps array
        public Ingredient[] ingredients;
        public string[] steps;

        //decalare default factor
        public double factor = 1;


        // Method to enter recipe details
        public void RecipeDetails()
        {
            //Prompt user to enter number of ingredients
            Console.Write("Please enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());
            ingredients = new Ingredient[numIngredients];

            for (int i = 0; i < numIngredients; i++)
            {
                //Prompt user to enter the ingredient name
                Console.Write($"Please enter ingredient {i + 1} name: ");
                string ingredientName = Console.ReadLine();

                //Prompt user to enter the quantity of the ingredient
                Console.Write($"Please enter ingredient {i + 1} quantity: ");
                double ingredientQuantity = double.Parse(Console.ReadLine());

                //Prompt user to enter the measurement unit of the ingredient
                Console.Write($"Please enter ingredient {i + 1} unit of measurement: ");
                string ingredientUnit = Console.ReadLine();

                //add details to the ingredient array
                ingredients[i] = new Ingredient(ingredientName, ingredientQuantity, ingredientUnit);
            }
            //Prompt user to enter the number of steps
            Console.Write("Please enter the number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());
            steps = new string[numSteps];

            for (int i = 0; i < numSteps; i++)
            {
                //Prompt user to enter description of each step
                Console.Write($"Please enter step {i + 1} description: ");

                //Add description to steps array
                steps[i] = Console.ReadLine();
            }
        }

        // Method to display the recipe
        public void DisplayRecipe()
        {
            Console.WriteLine("\nRecipe");
            Console.WriteLine("Ingredients:");
            foreach (Ingredient ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity * factor} {ingredient.Unit} of {ingredient.Name}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"Step {i + 1}: {steps[i]}");
            }
        }

        // Method to scale the recipe
        public void ScaleRecipe()
        {
            //Prompt user to enter value which recipe quantity will be factored by
            Console.Write("Please enter a scale factor of 0.5(half), 2(double), or 3(triple): ");
            factor = double.Parse(Console.ReadLine());
        }

        // Method to reset the quantities
        public void ResetQuantities()
        {
            factor = 1;
        }

        // Method to clear data
        public void ClearRecipe()
        {
            ingredients = new Ingredient[0];
            steps = new string[0];
        }
    }
    }

    
   





