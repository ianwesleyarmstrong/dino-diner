using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DinoDiner.Menu
{
    public class Menu 
    {

        /// <summary>
        /// List of all available menu items
        /// </summary>
        
        
        private static List<IMenuItem> availableMenuItems;
        private static HashSet<string> possibleIngredients;
        private static List<IMenuItem> availableDrinks;
        private static List<IMenuItem> availableSides;
        private static List<IMenuItem> availableEntrees;



        public static List<IMenuItem> AvailableMenuItems
        {
            get
            {
                if (availableMenuItems == null)
                {
                    availableMenuItems = new List<IMenuItem>();
                    // Entrees
                    availableMenuItems.Add(new Brontowurst());
                    availableMenuItems.Add(new DinoNuggets());
                    availableMenuItems.Add(new PrehistoricPBJ());
                    availableMenuItems.Add(new PterodactylWings());
                    availableMenuItems.Add(new SteakosaurusBurger());
                    availableMenuItems.Add(new TRexKingBurger());
                    availableMenuItems.Add(new VelociWrap());
                    //sides with all sizes
                    Fryceritops fry = new Fryceritops();
                    availableMenuItems.Add(fry);
                    MeteorMacAndCheese mmc = new MeteorMacAndCheese();
                    availableMenuItems.Add(mmc);
                    MezzorellaSticks mezz = new MezzorellaSticks();
                    availableMenuItems.Add(mezz);
                    Triceritots tt = new Triceritots();
                    availableMenuItems.Add(tt);
                    //drinks
                    JurassicJava jj = new JurassicJava();
                    availableMenuItems.Add(jj);
                    Sodasaurus soda = new Sodasaurus();
                    availableMenuItems.Add(soda);
                    Tyrannotea tea = new Tyrannotea();
                    availableMenuItems.Add(tea);
                    availableMenuItems.Add(new Water());
                    availableMenuItems.Add(new CretaceousCombo(new Brontowurst()));
                    availableMenuItems.Add(new CretaceousCombo(new DinoNuggets()));
                    availableMenuItems.Add(new CretaceousCombo(new PrehistoricPBJ()));
                    availableMenuItems.Add(new CretaceousCombo(new PterodactylWings()));
                    availableMenuItems.Add(new CretaceousCombo(new SteakosaurusBurger()));
                    availableMenuItems.Add(new CretaceousCombo(new TRexKingBurger()));
                    availableMenuItems.Add(new CretaceousCombo(new VelociWrap()));
                    
                }
                return availableMenuItems;
            }
        }

        /// <summary>
        /// List of all avilable Entrees.
        /// </summary>
        public static List<IMenuItem> AvailableEntrees
        {
            get
            {
                List<IMenuItem> availEntrees = new List<IMenuItem>();
                foreach(IMenuItem item in AvailableMenuItems)
                {
                    if (item is Entree)
                    {
                        availEntrees.Add(item);
                    }
                }
                return availEntrees;
            }
        }

        /// <summary>
        /// List of all avilable sides
        /// </summary>
        public static List<IMenuItem> AvailableSides
        {
            get
            {
                List<IMenuItem> availSides = new List<IMenuItem>();
                foreach (IMenuItem item in AvailableMenuItems)
                {
                    if (item is Side)
                    {
                        availSides.Add(item);
                    }
                }
                return availSides;
            }
        }

        /// <summary>
        /// List of available drinks
        /// </summary>
        public static List<IMenuItem> AvailableDrinks
        {
            get
            {
                List<IMenuItem> availDrinks = new List<IMenuItem>();
                foreach (IMenuItem item in AvailableMenuItems)
                {
                    if (item is Drink)
                    {
                        availDrinks.Add(item);
                    }
                }
                return availDrinks;
            }
        }

        /// <summary>
        /// List of all available combos
        /// </summary>
        public static List<IMenuItem> AvailableCombos
        {
            get
            {
                List<IMenuItem> availCombos = new List<IMenuItem>();
                foreach (IMenuItem item in AvailableMenuItems)
                {
                    if (item is CretaceousCombo)
                    {
                        availCombos.Add(item);
                    }
                }
                return availCombos;

            }
        }

        public static HashSet<string> PossibleIngredients
        {
            get
            {
                if (possibleIngredients == null)
                {
                    possibleIngredients = new HashSet<string>();

                    
                    foreach (IMenuItem item in Menu.AvailableMenuItems)
                    {
                        foreach (string ingredient in item.Ingredients)
                            possibleIngredients.Add(ingredient);
                    }
                }
                return possibleIngredients;
            }
        }



        /// <summary>
        /// Displays the all available items in the menu
        /// </summary>
        /// <returns></returns>
        public static string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (IMenuItem menuItem in AvailableMenuItems)
            {
                sb.Append(menuItem.ToString());
                sb.Append("\n");
            }
            return sb.ToString();
        }

        /// <summary>
        /// searches the menu for a given term
        /// </summary>
        /// <param name="menuItems"></param>
        /// <param name="term"></param>
        /// <returns></returns>
        public static List<IMenuItem> Search(List<IMenuItem> menuItems, string term)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach(IMenuItem item in menuItems)
            {
                if (item.ToString().ToLower().Contains(term.ToLower()))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// filters the list based on what categories are selected
        /// </summary>
        /// <param name="menuItems"></param>
        /// <param name="categories"></param>
        /// <returns></returns>
        public static List<IMenuItem> FilterByCategory(List<IMenuItem> menuItems, List<string> categories)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach(IMenuItem item in menuItems)
            {
                if (categories.Contains("Combo") && item is CretaceousCombo)
                {
                    results.Add(item);
                }
                else if (categories.Contains("Entree") && item is Entree)
                {
                    results.Add(item);
                }
                else if (categories.Contains("Drink") && item is Drink)
                {
                    results.Add(item);
                }
                else if (categories.Contains("Side") && item is Side)
                {
                    results.Add(item);
                }
            }
            return results;
        }


        /// <summary>
        /// Filters the list by min price seleted 
        /// </summary>
        /// <param name="menuItems"></param>
        /// <param name="minPrice"></param>
        /// <returns></returns>
        public static List<IMenuItem> FilterByMinPrice(List<IMenuItem> menuItems, float minPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach(IMenuItem item in menuItems)
            {
                if (minPrice <= item.Price)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the list by max price seleted 
        /// </summary>
        /// <param name="menuItems"></param>
        /// <param name="minPrice"></param>
        /// <returns></returns>
        public static List<IMenuItem> FilterByMaxPrice(List<IMenuItem> menuItems, float maxPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem item in menuItems)
            {
                if (maxPrice >= item.Price)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        public static List<IMenuItem> FilterByIngredients(List<IMenuItem> menuItems, List<string> excludedIngredients)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach(IMenuItem item in menuItems)
            {
                results.Add(item);
            }
            foreach(IMenuItem item in menuItems)
            {
                foreach(string ingredient in item.Ingredients)
                {
                    if (excludedIngredients.Contains(ingredient))
                        results.Remove(item);
                }
                results.Add(item);
            }
            return results;
        }

    }
}
