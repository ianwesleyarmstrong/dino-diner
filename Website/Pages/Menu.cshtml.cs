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

        public List<IMenuItem> MenuList;

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
            MenuList = Menu.Search(MenuList, "");
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
                MenuList = Menu.Search(MenuList, search);

            if (menuCategory.Count != 0)
                MenuList = Menu.FilterByCategory(MenuList, menuCategory);

            if (minimumPrice != null)
                MenuList = Menu.FilterByMinPrice(MenuList, minimumPrice.Value);

            if (maximumPrice != null)
                MenuList = Menu.FilterByMaxPrice(MenuList, maximumPrice.Value);

            if (excludedIngredients.Count != 0)
                MenuList = Menu.FilterByIngredients(MenuList, excludedIngredients);

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