using System;
using System.Collections.Generic;
using System.Text;

namespace KitchenLib
{
    internal class Recipe
    {
        // fields
        public string Name { get; set; }
        
        public string Description { get; set; } 
        
        public List<Ingredient> Ingredients { get; set; }

        protected List<string> Instructions { get; set; }
        
        public TimeSpan PrepTime { get; set; } 
            
        // methods
        public Recipe(string name, string description, List<Ingredient> ingredients, List<string> instructions, TimeSpan prepTime)
        {
            Name = name;
            Description = description;
            Ingredients = ingredients;
            Instructions = instructions;
            PrepTime = prepTime;
        }
        
        public Recipe(string name, string description, TimeSpan prepTime)
        {
            Name = name;
            Description = description;
            PrepTime = prepTime;
        }
    }
}
