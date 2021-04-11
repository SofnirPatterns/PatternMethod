using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageWithCoffeine coffe = new Coffe();
            BeverageWithCoffeine tea = new Tea();
            coffe.BrewingRecipe();
            Console.WriteLine();
            tea.BrewingRecipe();
            Console.ReadKey();
        }

        public abstract class BeverageWithCoffeine
        {
            public void BrewingRecipe()
            {
                CookingWater();
                BrewingBeverage();
                PouringIntoCup();
                if(IsAddingAdditions())
                {
                    AddingAdditions();
                }                
            }

            private void CookingWater() { Console.WriteLine("Cooking water"); }
            protected abstract void BrewingBeverage();
            private void PouringIntoCup() { Console.WriteLine("Pouring into cup"); }
            protected abstract void AddingAdditions();
            protected virtual bool IsAddingAdditions()
            {
                return true;
            }
        }

        public class Coffe : BeverageWithCoffeine
        {                        
            protected override void BrewingBeverage() { Console.WriteLine("Brewing coffe"); }            
            protected override void AddingAdditions() { Console.WriteLine("Adding sugar and milk"); }
        }

        public class Tea : BeverageWithCoffeine
        {
            protected override void BrewingBeverage() { Console.WriteLine("Brewing tea"); }
            protected override void AddingAdditions() { Console.WriteLine("Adding lemon"); }         
            protected override bool IsAddingAdditions()
            {
                return false;
            }
        }
    }
}
