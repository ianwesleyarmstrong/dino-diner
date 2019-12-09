using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {

        public Menu menu;

        public IEnumerable<IMenuItem> MenuList;

        /// <summary>
        /// backing variables for each type of menu item
        /// </summary>
        public List<IMenuItem> EntreeList;
        public List<IMenuItem> ComboList;
        public List<IMenuItem> SideList;
        public List<IMenuItem> DrinkList;

        [BindProperty]
        public string search { get; set; }

        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();
        [BindProperty]
        public float? minimumPrice { get; set; }
        [BindProperty]
        public float? maximumPrice { get; set; }
        [BindProperty]
        public List<string> excludedIngredients { get; set; } = new List<string>();


        public void OnGet()
        {
            MenuList = Menu.AvailableMenuItems;
            ComboList = new List<IMenuItem>();
            EntreeList = new List<IMenuItem>();
            SideList = new List<IMenuItem>();
            DrinkList = new List<IMenuItem>();
            foreach (IMenuItem item in MenuList)
            {
                if (item is CretaceousCombo)
                {
                    ComboList.Add(item);
                }
                if (item is Entree)
                {
                    EntreeList.Add(item);
                }
                if (item is Side)
                {
                    SideList.Add(item);
                }
                if (item is Drink)
                {
                    DrinkList.Add(item);
                }
            }
        }

        public void OnPost()
        {
            MenuList = Menu.AvailableMenuItems;
            ComboList = new List<IMenuItem>();
            EntreeList = new List<IMenuItem>();
            SideList = new List<IMenuItem>();
            DrinkList = new List<IMenuItem>();


            if (search != null)
                MenuList = MenuList.Where(item => item.ToString().ToLower().Contains(search.ToLower()));

            if (menuCategory.Count != 0)
                MenuList = MenuList.Where(item => (item is CretaceousCombo && menuCategory.Contains("Combo")) || (item is Entree && menuCategory.Contains("Entree")) || (item is Side && menuCategory.Contains("Side")) || (item is Drink && menuCategory.Contains("Drink")));
            if (minimumPrice != null)
                MenuList = MenuList.Where(item => item.Price >= minimumPrice);

            if (maximumPrice != null)
                MenuList = MenuList.Where(item => item.Price <= minimumPrice);

            if (excludedIngredients.Count != 0)
                MenuList = MenuList.Where(item => !item.Ingredients.Any(ingredient => excludedIngredients.Contains(ingredient)));

            foreach (IMenuItem item in MenuList)
            {
                if (item is CretaceousCombo)
                {
                    ComboList.Add(item);
                }
                if (item is Entree)
                {
                    EntreeList.Add(item);
                }
                if (item is Side)
                {
                    SideList.Add(item);
                }
                if (item is Drink)
                {
                    DrinkList.Add(item);
                }
            }
        }
    }
}