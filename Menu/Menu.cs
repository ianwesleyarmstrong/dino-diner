using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu 
    {
        List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> menuItems = new List<IMenuItem>();
                menuItems.Add(new Brontowurst());
                menuItems.Add(new DinoNuggets());
                menuItems.Add(new PrehistoricPBJ());
                menuItems.Add(new PterodactylWings());
                menuItems.Add(new SteakosaurusBurger());
                menuItems.Add(new TRexKingBurger());
                menuItems.Add(new VelociWrap());
                menuItems.Add(new Fryceritops());
                menuItems.Add(new MeteorMacAndCheese());
                menuItems.Add(new MezzorellaSticks());
                menuItems.Add(new Triceritots());
                menuItems.Add(new JurassicJava());
                menuItems.Add(new Sodasaurus());
                menuItems.Add(new Tyrannotea());
                menuItems.Add(new Water());
                menuItems.Add(new CretaceousCombo(new Brontowurst()));
                menuItems.Add(new CretaceousCombo(new DinoNuggets()));
                menuItems.Add(new CretaceousCombo(new PrehistoricPBJ()));
                menuItems.Add(new CretaceousCombo(new PterodactylWings()));
                menuItems.Add(new CretaceousCombo(new SteakosaurusBurger()));
                menuItems.Add(new CretaceousCombo(new TRexKingBurger()));
                menuItems.Add(new CretaceousCombo(new VelociWrap()));
                return menuItems;

            }
        }
        List<IMenuItem> AvailableEntrees
        {
            get
            {
                List<IMenuItem> availEntrees = new List<IMenuItem>();
                availEntrees.Add(new Brontowurst());
                availEntrees.Add(new DinoNuggets());
                availEntrees.Add(new PrehistoricPBJ());
                availEntrees.Add(new PterodactylWings());
                availEntrees.Add(new SteakosaurusBurger());
                availEntrees.Add(new TRexKingBurger());
                availEntrees.Add(new VelociWrap());
                return availEntrees;
            }
        }
        List<IMenuItem> AvailableSides
        {
            get
            {
                List<IMenuItem> availSides = new List<IMenuItem>();
                availSides.Add(new Fryceritops());
                availSides.Add(new MeteorMacAndCheese());
                availSides.Add(new MezzorellaSticks());
                availSides.Add(new Triceritots());
                return availSides;
            }
        }
        List<IMenuItem> AvailableDrinks
        {
            get
            {
                List<IMenuItem> availDrinks = new List<IMenuItem>();
                availDrinks.Add(new JurassicJava());
                availDrinks.Add(new Sodasaurus());
                availDrinks.Add(new Tyrannotea());
                availDrinks.Add(new Water());
                return availDrinks;
            }
        }
        List<IMenuItem> AvailableCombos
        {
            get
            {
                List<IMenuItem> availCombos = new List<IMenuItem>();
                availCombos.Add(new CretaceousCombo(new Brontowurst()));
                availCombos.Add(new CretaceousCombo(new DinoNuggets()));
                availCombos.Add(new CretaceousCombo(new PrehistoricPBJ()));
                availCombos.Add(new CretaceousCombo(new PterodactylWings()));
                availCombos.Add(new CretaceousCombo(new SteakosaurusBurger()));
                availCombos.Add(new CretaceousCombo(new TRexKingBurger()));
                availCombos.Add(new CretaceousCombo(new VelociWrap()));
                return availCombos;

            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (IMenuItem menuItem in AvailableMenuItems)
            {
                sb.Append(menuItem.ToString());
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
