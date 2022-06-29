using Pastel;
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
    public class Program
    {
        static RecipeModel newRecipe = new RecipeModel();
        static void Main(string[] args)
        {
            showMainMenu();
        }
        public static void showMainMenu()
        {
            #region HEAD
                Console.Clear();
                string hello = " ===== PROJEKT WPiAA =====";
                Console.SetCursorPosition((Console.WindowWidth - hello.Length) / 2, Console.CursorTop);
                Console.WriteLine(hello.Pastel("#428df5").PastelBg("#101b2b"));

                Console.WriteLine();

                Console.SetCursorPosition((Console.WindowWidth - "Main Menu".Length) / 2, Console.CursorTop);
                Console.WriteLine("Main Menu".Pastel("#428df5").PastelBg("#101b2b"));

                Console.WriteLine();

            #endregion
            #region MENU
            Console.SetCursorPosition((Console.WindowWidth - "1 - Recipe Menu".Length) / 2, Console.CursorTop);
                Console.WriteLine("1 - Recipe Menu".Pastel("#428df5"));

                Console.SetCursorPosition((Console.WindowWidth - "2 - Exit".Length) / 2, Console.CursorTop);
                Console.WriteLine("2 - Exit".Pastel("#428df5"));

                Console.SetCursorPosition((Console.WindowWidth - "Operation: ".Length) / 2, Console.CursorTop);
                Console.Write("Operation: ".Pastel("#d1b32c"));
            #endregion

            int input;

            try
            {
                input = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                input = 0;
            }

            switch (input)
            {
                case 1:
                    showRecipeMenu();
                    break;
                case 2:
                    Console.WriteLine("EXIT");
                    break;
                default:
                    showMainMenu();
                    break;
            }
        }
        public static void showRecipeMenu()
        {
            #region HEAD
                Console.Clear();
                string hello = " ===== PROJEKT WPiAA =====";
                Console.SetCursorPosition((Console.WindowWidth - hello.Length) / 2, Console.CursorTop);
                Console.WriteLine(hello.Pastel("#428df5").PastelBg("#101b2b"));

                Console.WriteLine();

                Console.SetCursorPosition((Console.WindowWidth - "Recipe Menu".Length) / 2, Console.CursorTop);
                Console.WriteLine("Recipe Menu".Pastel("#428df5").PastelBg("#101b2b"));

                Console.WriteLine();

            #endregion
            #region MENU
            Console.SetCursorPosition((Console.WindowWidth - "1 - List all in this recipe".Length) / 2, Console.CursorTop);
                Console.WriteLine("1 - List all in this recipe".Pastel("#428df5"));

                Console.SetCursorPosition((Console.WindowWidth - "2 - Add new recipe".Length) / 2, Console.CursorTop);
                Console.WriteLine("2 - Add new recipe".Pastel("#428df5"));

                Console.SetCursorPosition((Console.WindowWidth - "3 - Go Back".Length) / 2, Console.CursorTop);
                Console.WriteLine("3 - Go Back".Pastel("#428df5"));

                Console.SetCursorPosition((Console.WindowWidth - "Operation: ".Length) / 2, Console.CursorTop);
                Console.Write("Operation: ".Pastel("#d1b32c"));
            #endregion

            int input;

            try
            {
                input = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                input = 0;
            }

            switch (input)
            {
                case 1:
                    //showAddMenu();
                    ListAllRecipes();
                    break;
                case 2:
                    CreateNewRecipe();
                    break;
                case 3:
                    showMainMenu();
                    break;
                default:
                    showRecipeMenu();
                    break;
            }
        }
        public static void CreateNewRecipe(){

            int input = -1;

            if (newRecipe.Id == 0) {
                newRecipe = new RecipeModel();
                newRecipe.RecipeProducts = new List<RecipeProductModel>();
            }

            while (input != 5)
            {
                #region HEAD
                    Console.Clear();
                    string hello = " ===== PROJEKT WPiAA =====";
                    Console.SetCursorPosition((Console.WindowWidth - hello.Length) / 2, Console.CursorTop);
                    Console.WriteLine(hello.Pastel("#428df5").PastelBg("#101b2b"));

                    Console.WriteLine();

                    Console.SetCursorPosition((Console.WindowWidth - "Create New Recipe".Length) / 2, Console.CursorTop);
                    Console.WriteLine("Create New Recipe".Pastel("#428df5").PastelBg("#101b2b"));

                    Console.WriteLine();
                #endregion

                FileManagerSingleton fileManager = FileManagerSingleton.GetInstance();

                Console.SetCursorPosition((Console.WindowWidth - (" ===== Recipe ===== ").Length) / 2, Console.CursorTop);
                Console.WriteLine((" ===== Recipe ===== ").Pastel("#b83c0f").PastelBg("#2e1107"));

                Console.WriteLine("ID: " + ("" + newRecipe.Id).Pastel("#c2ba21"));
                Console.WriteLine("Name: " + ("" + newRecipe.Name).Pastel("#c2ba21"));
                Console.WriteLine("Sum: " + ("" + newRecipe.Sum).Pastel("#c2ba21"));

                Console.WriteLine("Products: ");
                foreach (var e in newRecipe.RecipeProducts)
                {
                    Console.WriteLine("Product Id: " + ("" + e.Id).Pastel("#d98621"));
                    Console.WriteLine("Product Name: " + ("" + e.Name).Pastel("#d98621") + " Product Cost: " + ("" + e.Cost).Pastel("#d98621"));
                   Console.WriteLine("Manual: " + ("" + e.Manual).Pastel("#1db82d"));
                }


                #region MENU


                Console.WriteLine();

                Console.SetCursorPosition((Console.WindowWidth - "1 - Create recipe".Length) / 2, Console.CursorTop);
                Console.WriteLine("1 - Create recipe".Pastel("#428df5").PastelBg("#101b2b"));

                Console.SetCursorPosition((Console.WindowWidth - "2 - Add new product".Length) / 2, Console.CursorTop);
                Console.WriteLine("2 - Add new product".Pastel("#428df5").PastelBg("#101b2b"));

                Console.SetCursorPosition((Console.WindowWidth - "3 - Remove product".Length) / 2, Console.CursorTop);
                Console.WriteLine("3 - Remove product".Pastel("#428df5").PastelBg("#101b2b"));

                Console.SetCursorPosition((Console.WindowWidth - "4 - Save Recipe".Length) / 2, Console.CursorTop);
                Console.WriteLine("4 - Save Recipe".Pastel("#428df5").PastelBg("#101b2b"));

                Console.SetCursorPosition((Console.WindowWidth - "5 - Dont Save Recipe".Length) / 2, Console.CursorTop);
                Console.WriteLine("5 - Dont Save Recipe".Pastel("#428df5").PastelBg("#101b2b"));

                Console.SetCursorPosition((Console.WindowWidth - "6 - Back".Length) / 2, Console.CursorTop);
                Console.WriteLine("6 - Back".Pastel("#428df5").PastelBg("#101b2b"));

                Console.SetCursorPosition((Console.WindowWidth - "Operation: ".Length) / 2, Console.CursorTop);
                Console.Write("Operation: ".Pastel("#d1b32c"));

                #endregion



                try
                {
                    input = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    input = 0;
                }

                switch (input)
                {
                    case 1:

                        newRecipe.Id = DateTime.Now.Ticks;
                        newRecipe.Name = Guid.NewGuid().ToString("n").Substring(0, 8);
                        newRecipe.RecipeProducts = new List<RecipeProductModel>();

                        break;
                    case 2:
                        if (newRecipe.Id != 0)
                        {
                            AddNewProduct();
                                
                        }
                        break;
                    case 3:
                        RemoveProduct();
                        break;
                    case 4:
                        if (newRecipe.Id != 0)
                        {
                            fileManager.AddRecipe(newRecipe);
                            newRecipe = new RecipeModel();
                            newRecipe.RecipeProducts = new List<RecipeProductModel>();
                            input = 6;
                        }
                        break;
                    case 5:
                            newRecipe = new RecipeModel();
                            newRecipe.RecipeProducts = new List<RecipeProductModel>();
                            input = 6;
                        break;
                    case 6:
  
                        break;
                    default:
                        //showAddMenu();
                        break;
                }

                if (input == 6)
                {
                    Console.WriteLine(input);
                    break;
                }
            }

            showRecipeMenu();
        }
        public static void AddNewProduct()
        {
            string a = new ConcreteFactory1().Name;
            #region HEAD
            Console.Clear();
            string hello = " ===== PROJEKT WPiAA =====";
            Console.SetCursorPosition((Console.WindowWidth - hello.Length) / 2, Console.CursorTop);
            Console.WriteLine(hello.Pastel("#428df5").PastelBg("#101b2b"));

            Console.WriteLine();

            Console.SetCursorPosition((Console.WindowWidth - "Add New Product".Length) / 2, Console.CursorTop);
            Console.WriteLine("Add New Product".Pastel("#428df5").PastelBg("#101b2b"));

            Console.WriteLine();

            Console.SetCursorPosition((Console.WindowWidth - "Choose factory".Length) / 2, Console.CursorTop);
            Console.WriteLine("Choose factory".Pastel("#428df5").PastelBg("#101b2b"));

            Console.WriteLine();
            #endregion
            #region MENU
            Console.SetCursorPosition((Console.WindowWidth - ("1 - " + new ConcreteFactory1().Name).Length) / 2, Console.CursorTop);
            Console.WriteLine(("1 - " + new ConcreteFactory1().Name).Pastel("#428df5"));

            Console.SetCursorPosition((Console.WindowWidth - ("2 - " + new ConcreteFactory2().Name).Length) / 2, Console.CursorTop);
            Console.WriteLine(("2 - " + new ConcreteFactory2().Name).Pastel("#428df5"));

            Console.SetCursorPosition((Console.WindowWidth - "3 - Back".Length) / 2, Console.CursorTop);
            Console.WriteLine("3 - Back".Pastel("#428df5"));

            Console.SetCursorPosition((Console.WindowWidth - "Operation: ".Length) / 2, Console.CursorTop);
            Console.Write("Operation: ".Pastel("#d1b32c"));
            #endregion
            int input;

            try
            {
                input = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                input = 0;
            }

            switch (input)
            {
                case 1:
                    showShowFactoryMenu(new ConcreteFactory1());
                    break;
                case 2:
                    showShowFactoryMenu(new ConcreteFactory2());
                    break;
                case 3:

                    break;
                default:
                    
                    break;
            }
        }
        public static void showShowFactoryMenu(IAbstractFactory factory)
        {
            #region HEAD
            Console.Clear();
            string hello = " ===== PROJEKT WPiAA =====";
            Console.SetCursorPosition((Console.WindowWidth - hello.Length) / 2, Console.CursorTop);
            Console.WriteLine(hello.Pastel("#428df5").PastelBg("#101b2b"));

            Console.WriteLine();

            Console.SetCursorPosition((Console.WindowWidth - ("Add New Product - " + factory.GetType()).Length) / 2, Console.CursorTop);
            Console.WriteLine(("Add New Product - " + factory.GetType()).Pastel("#428df5").PastelBg("#101b2b"));

            Console.WriteLine();

            Console.SetCursorPosition((Console.WindowWidth - "Choose Product".Length) / 2, Console.CursorTop);
            Console.WriteLine("Choose Product".Pastel("#428df5").PastelBg("#101b2b"));

            Console.WriteLine();
            #endregion
            #region MENU

            var productMinA = factory.CreateMinimalProductA("Table  " + " " + factory.Name);
            var productMinAModel = productMinA.GetModelObject();
            var productFullA = factory.CreateFullProductA("Table  (With guarantee)" + " " + factory.Name);
            var productFullAModel = productFullA.GetModelObject();
            var productMinB = factory.CreateMinimalProductB("Chair  " + " " + factory.Name);
            var productMinBModel = productMinB.GetModelObject();
            var productFullB = factory.CreateFullProductB("Chair  (With guarantee)" + " " + factory.Name);
            var productFullBModel = productFullB.GetModelObject();
            var productMinC = factory.CreateMinimalProductC("Closet  " + " " + factory.Name);
            var productMinCModel = productMinC.GetModelObject();
            var productFullC = factory.CreateFullProductC("Closet  (With guarantee)" + " " + factory.Name);
            var productFullCModel = productFullC.GetModelObject();
            
            //Console.SetCursorPosition((Console.WindowWidth - ("1 - " + productMinAModel.Name).Length) / 2, Console.CursorTop);
            Console.WriteLine(("1 - " + productMinAModel.Name).Pastel("#428df5"));

            //Console.SetCursorPosition((Console.WindowWidth - ("2 - " + productFullAModel.Name).Length) / 2, Console.CursorTop);
            Console.WriteLine(("2 - " + productFullAModel.Name).Pastel("#428df5"));

            //Console.SetCursorPosition((Console.WindowWidth - ("3 - " + productMinBModel.Name).Length) / 2, Console.CursorTop);
            Console.WriteLine(("3 - " + productMinBModel.Name).Pastel("#428df5"));

            //Console.SetCursorPosition((Console.WindowWidth - ("4 - " + productFullBModel.Name).Length) / 2, Console.CursorTop);
            Console.WriteLine(("4 - " + productFullBModel.Name).Pastel("#428df5"));

            //Console.SetCursorPosition((Console.WindowWidth - ("5 - " + productMinCModel.Name).Length) / 2, Console.CursorTop);
            Console.WriteLine(("5 - " + productMinCModel.Name).Pastel("#428df5"));

            //Console.SetCursorPosition((Console.WindowWidth - ("6 - " + productFullCModel.Name).Length) / 2, Console.CursorTop);
            Console.WriteLine(("6 - " + productFullCModel.Name).Pastel("#428df5"));


            //Console.SetCursorPosition((Console.WindowWidth - "7 - Back".Length) / 2, Console.CursorTop);
            Console.WriteLine("7 - Back".Pastel("#428df5"));

            Console.SetCursorPosition((Console.WindowWidth - "Operation: ".Length) / 2, Console.CursorTop);
            Console.Write("Operation: ".Pastel("#d1b32c"));
            #endregion

            int input;

            try
            {
                input = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                input = 0;
            }

            switch (input)
            {
                case 1:
                    newRecipe.RecipeProducts.Add(productMinAModel);

                    newRecipe.Sum += productMinAModel.Cost;
                    break;
                case 2:
                    newRecipe.RecipeProducts.Add(productFullAModel);

                    newRecipe.Sum += productFullAModel.Cost;
                    break;
                case 3:


                    newRecipe.RecipeProducts.Add(productMinBModel);

                    newRecipe.Sum += productMinBModel.Cost;
                    break;
                case 4:
                    newRecipe.RecipeProducts.Add(productFullBModel);

                    newRecipe.Sum += productFullBModel.Cost;
                    break;
                case 5:


                    newRecipe.RecipeProducts.Add(productMinCModel);

                    newRecipe.Sum += productMinCModel.Cost;
                    break;
                case 6:
                    newRecipe.RecipeProducts.Add(productFullCModel);

                    newRecipe.Sum += productFullCModel.Cost;
                    break;
                case 7:

                    break;
                default:

                    break;
            }
        }
        public static void ListAllRecipes()
        {
            #region HEAD
            Console.Clear();
            string hello = " ===== PROJEKT WPiAA =====";
            Console.SetCursorPosition((Console.WindowWidth - hello.Length) / 2, Console.CursorTop);
            Console.WriteLine(hello.Pastel("#428df5").PastelBg("#101b2b"));

            Console.WriteLine();

            Console.SetCursorPosition((Console.WindowWidth - "RECIPE LIST".Length) / 2, Console.CursorTop);
            Console.WriteLine("RECIPE LIST".Pastel("#428df5").PastelBg("#101b2b"));

            Console.WriteLine();
            #endregion

            FileManagerSingleton fileManager = FileManagerSingleton.GetInstance();

            fileManager.ListRecipes();

            #region MENU
            Console.WriteLine();

            Console.SetCursorPosition((Console.WindowWidth - "1 - Back".Length) / 2, Console.CursorTop);
            Console.WriteLine("1 - Back".Pastel("#428df5").PastelBg("#101b2b"));

            Console.SetCursorPosition((Console.WindowWidth - "Operation: ".Length) / 2, Console.CursorTop);
            Console.Write("Operation: ".Pastel("#d1b32c"));
            #endregion

            int input;

            try
            {
                input = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                input = 0;
            }

            switch (input)
            {
                case 1:
                    showRecipeMenu();
                    break;
                default:
                    //showAddMenu();
                    break;
            }
        }
        public static void RemoveProduct()
        {

                #region HEAD
                Console.Clear();
                string hello = " ===== PROJEKT WPiAA =====";
                Console.SetCursorPosition((Console.WindowWidth - hello.Length) / 2, Console.CursorTop);
                Console.WriteLine(hello.Pastel("#428df5").PastelBg("#101b2b"));

                Console.WriteLine();

                Console.SetCursorPosition((Console.WindowWidth - "Remove Product - Write Product ID to remove or 1 to Back".Length) / 2, Console.CursorTop);
                Console.WriteLine("Remove Product - Write Product ID to remove or 1 to Back".Pastel("#428df5").PastelBg("#101b2b"));

                Console.WriteLine();
                #endregion

                FileManagerSingleton fileManager = FileManagerSingleton.GetInstance();

                Console.SetCursorPosition((Console.WindowWidth - (" ===== Recipe ===== ").Length) / 2, Console.CursorTop);
                Console.WriteLine((" ===== Recipe ===== ").Pastel("#b83c0f").PastelBg("#2e1107"));

                Console.WriteLine("ID: " + ("" + newRecipe.Id).Pastel("#c2ba21"));
                Console.WriteLine("Name: " + ("" + newRecipe.Name).Pastel("#c2ba21"));
                Console.WriteLine("Sum: " + ("" + newRecipe.Sum).Pastel("#c2ba21"));

                Console.WriteLine("Products: ");
                foreach (var e in newRecipe.RecipeProducts)
                {
                    Console.WriteLine("Product Id: " + ("" + e.Id).Pastel("#d98621"));
                    Console.WriteLine("Product Name: " + ("" + e.Name).Pastel("#d98621") + " Product Cost: " + ("" + e.Cost).Pastel("#d98621"));
                    Console.WriteLine("Manual: " + ("" + e.Manual).Pastel("#1db82d"));
                }


                #region MENU


                Console.WriteLine();

                Console.SetCursorPosition((Console.WindowWidth - "1 - Back".Length) / 2, Console.CursorTop);
                Console.WriteLine("1 - Back".Pastel("#428df5").PastelBg("#101b2b"));

                Console.SetCursorPosition((Console.WindowWidth - "Operation: ".Length) / 2, Console.CursorTop);
                Console.Write("Operation: ".Pastel("#d1b32c"));

            #endregion
            long input;


                try
                {
                    input = long.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    input = 0;
                }

                switch (input)
                {
                    case 1:

                        break;
                    default:
                    var prod = newRecipe.RecipeProducts.Find(ele => ele.Id == input);
                   if(prod != null)
                    {
                        newRecipe.RecipeProducts.Remove(prod);
                        newRecipe.Sum -= prod.Cost;
                    }
                    break;
                }
            
        }
    }
}
