using ProjektWPiAA.Models;
using System;
using Pastel;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;

namespace ProjektWPiAA.Singleton
{
    public sealed class FileManagerSingleton
    {
        private const string _dbFileName = "localDataBase.json";

        private FileManagerSingleton() {

            if (!File.Exists(_dbFileName))
            {
                DbModel db = new DbModel();
                db.Recipes = new List<RecipeModel>();

                //File.WriteAllText(_dbFileName, "{\"Recipes\" : []}") ;
                File.WriteAllText(_dbFileName, JsonSerializer.Serialize(db));
            }

        }

        private static FileManagerSingleton _instance;

        public static FileManagerSingleton GetInstance()
        {
            if (_instance == null)
                _instance = new FileManagerSingleton();

            return _instance;
        }

        public void AddRecipe(RecipeModel recipe)
        {
            string content;

            using (var fs = new FileStream(_dbFileName, FileMode.Open, FileAccess.Read))
            {
                using (var sr = new StreamReader(fs, Encoding.UTF8))
                {
                    content = sr.ReadToEnd();
                }
            }
            //Console.WriteLine("Content: " + content);
            var DbJson = JsonSerializer.Deserialize<DbModel>(content);

            var objExists = DbJson.Recipes.Where(r => r.Id == recipe.Id).FirstOrDefault();

            if(objExists == null)
            {
                DbJson.Recipes.Add(recipe);
            }

            using (var fs = new FileStream(_dbFileName, FileMode.Open, FileAccess.Write))
            {
                using (var sr = new StreamWriter(fs, Encoding.UTF8))
                {
                    sr.Write(JsonSerializer.Serialize(DbJson, new JsonSerializerOptions { WriteIndented = true }));
                }
            }
        }

        public void RemoveRecipe(long id)
        {
            Console.WriteLine("DELETED");
            string content;

            using (var fs = new FileStream(_dbFileName, FileMode.Open, FileAccess.Read))
            {
                using (var sr = new StreamReader(fs, Encoding.UTF8))
                {
                    content = sr.ReadToEnd();
                }
            }
            //Console.WriteLine("Content: " + content);
            var DbJson = JsonSerializer.Deserialize<DbModel>(content);

            var objToRemove = DbJson.Recipes.Where(recipe => recipe.Id == id).FirstOrDefault();
            if (objToRemove != null)
            {
                Console.WriteLine("DELETED: " + id);
                DbJson.Recipes.Remove(objToRemove);
            }

            using (var fs = new FileStream(_dbFileName, FileMode.Create, FileAccess.Write))
            {
                using (var sr = new StreamWriter(fs, Encoding.UTF8))
                {
                    sr.Write(JsonSerializer.Serialize(DbJson, new JsonSerializerOptions { WriteIndented = true }));
                }
            }
        }

        public void ListRecipes()
        {
            Console.WriteLine("LIST OF RECIPES: \n");

            string content;

            using(var fs = new FileStream(_dbFileName, FileMode.Open, FileAccess.Read))
            {
                using(var sr = new StreamReader(fs, Encoding.UTF8))
                {
                    content = sr.ReadToEnd();    
                }
            }
            //Console.WriteLine("Content: " + content);
            var DbJson = JsonSerializer.Deserialize<DbModel>(content);

            
            
            for (int i = 0; i < DbJson.Recipes.Count; i++)
            {
                //Console.WriteLine(JsonSerializer.Serialize(DbJson.Recipes[i], new JsonSerializerOptions { WriteIndented = true }));

                Console.SetCursorPosition((Console.WindowWidth - (" ===== Recipe #" + (i + 1) + " ===== ").Length) / 2, Console.CursorTop);
                Console.WriteLine((" ===== Recipe #" + (i + 1) + " ===== ").Pastel("#b83c0f").PastelBg("#2e1107"));

                Console.WriteLine("ID: " + ( "" +DbJson.Recipes[i].Id).Pastel("#c2ba21"));
                Console.WriteLine("Name: " + ("" + DbJson.Recipes[i].Name).Pastel("#c2ba21"));
                Console.WriteLine("Sum: " + ("" + DbJson.Recipes[i].Sum).Pastel("#c2ba21"));
                Console.WriteLine("Products: ");
;

                foreach (var e in DbJson.Recipes[i].RecipeProducts)
                {
                    Console.WriteLine("Product Id: " + ("" + e.Id).Pastel("#d98621"));
                    Console.WriteLine("Product Name: " + ("" + e.Name).Pastel("#d98621") + " Product Cost: " + ("" + e.Cost).Pastel("#d98621"));
                    Console.WriteLine("Manual: " + ("" + e.Manual).Pastel("#1db82d"));
                }

                Console.WriteLine();    
            }
        }

    }
}
