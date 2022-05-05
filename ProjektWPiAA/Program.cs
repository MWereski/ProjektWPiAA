using ProjektWPiAA.FactoryA;
using ProjektWPiAA.FactoryB;
using ProjektWPiAA.IFactory;
using ProjektWPiAA.Models;
using ProjektWPiAA.Singleton;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ProjektWPiAA
{

    class Client {
    
        public void Main()
        {
            FileManagerSingleton fileManager = FileManagerSingleton.GetInstance();

            

            var newRecipe = new RecipeModel();

            newRecipe.Id = DateTime.Now.Ticks;
            newRecipe.Name = Guid.NewGuid().ToString("n").Substring(0, 8);
            newRecipe.RecipeProducts = new List<RecipeProductModel>();

            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new ConcreteFactory1(), newRecipe);
            Console.WriteLine();

            fileManager.AddRecipe(newRecipe);

            newRecipe = new RecipeModel();

            newRecipe.Id = DateTime.Now.Ticks;
            newRecipe.Name = Guid.NewGuid().ToString("n").Substring(0, 8);
            newRecipe.RecipeProducts = new List<RecipeProductModel>();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new ConcreteFactory2(), newRecipe);

            fileManager.AddRecipe(newRecipe);

            //Console.WriteLine(JsonSerializer.Serialize(newRecipe));

            fileManager.ListRecipes();

            //fileManager.RemoveRecipe(637873467783275010);

            //fileManager.ListRecipes();
        }

        public static void ClientMethod(IAbstractFactory factory, RecipeModel recipe)
        {
            
            var productMinA = factory.CreateMinimalProductA("Minimum product");
            var productMinAModel = productMinA.GetModelObject();

            recipe.Sum += productMinAModel.Cost;

            recipe.RecipeProducts.Add(productMinAModel);

            Console.WriteLine("Min Product: " + productMinA.ListParts() + "\n" + productMinA.UsefulFunctionA());

            Console.WriteLine(JsonSerializer.Serialize(productMinAModel));

            var productFullA = factory.CreateFullProductA("Maximum product");
            var productFullAModel = productFullA.GetModelObject();
            recipe.Sum += productFullAModel.Cost;

            recipe.RecipeProducts.Add(productFullAModel);
            // var productB = factory.CreateProductB();
            // var productC = factory.CreateProductC();

            Console.WriteLine("Full Product: " + productFullA.ListParts() + "\n" + productFullA.UsefulFunctionA());

            Console.WriteLine(JsonSerializer.Serialize(productFullAModel));

            //Console.WriteLine(productA.UsefulFunctionA());
            //Console.WriteLine(productC.UsefulFunctionC());
            //Console.WriteLine(productB.AnotherUsefulFunctionB(productC));
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
           new Client().Main();
        }
    }
}
