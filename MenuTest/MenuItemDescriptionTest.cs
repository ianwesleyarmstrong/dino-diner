using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class DescriptionTest
    {
        #region Entrees

        [Fact]
        public void BrontowurstDescription()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal("Brontowurst", bw.ToString());
        }


        [Fact]
        public void DinoNuggetDescription()
        {

            DinoNuggets dn = new DinoNuggets();
            Assert.Equal("Dino-Nuggets", dn.ToString());
        }


        [Fact]
        public void PrehistoricPBJDescription()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal("Prehistoric PB&J", pbj.ToString());
        }

        [Fact]
        public void PterodactylWingsDescription ()
        {
            PterodactylWings pw = new PterodactylWings();
            Assert.Equal("Pterodactyl Wings", pw.ToString());
        }

        [Fact]
        public void SteakosaurusBurgerDescription()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal("Steakosaurus Burger", sb.ToString());
        }

        [Fact]
        public void TRexKingBurgerDescription()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal("T-Rex King Burger", trex.ToString());
        }

        [Fact]
        public void VelociWrapDescription()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal("Veloci-Wrap", vw.ToString());
        }

        #endregion

        #region Sides

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void FryceritopsDescriptionForSize(Size size)
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = size;
            Assert.Equal($"{size} Fryceritops", ft.ToString());
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void MeteorMacAndCheeseDescriptionForSize(Size size)
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = size;
            Assert.Equal($"{size} Meteor Mac and Cheese", mmc.ToString());
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void MezzorellaSticksDescriptionForSize(Size size)
        {
            MezzorellaSticks ms = new MezzorellaSticks();
            ms.Size = size;
            Assert.Equal($"{size} Mezzorella Sticks", ms.ToString());
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ToStringDescriptionForSize(Size size)
        {
            Triceritots tt = new Triceritots();
            tt.Size = size;
            Assert.Equal($"{size} Triceritots", tt.ToString());
        }

        #endregion

        #region Drinks

        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void JurrasicJavaDescriptionForSizeAndDecaf(Size size, bool decaf)
        {
            JurassicJava java = new JurassicJava();
            java.Size = size;
            java.Decaf = decaf;
            if (decaf) Assert.Equal($"{size} Decaf Jurassic Java", java.ToString());
            else Assert.Equal($"{size} Jurassic Java", java.ToString());
        }


        [Theory]
        [InlineData(Size.Small, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Small, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Small, SodasaurusFlavor.Cola)]
        [InlineData(Size.Small, SodasaurusFlavor.Lime)]
        [InlineData(Size.Small, SodasaurusFlavor.Orange)]
        [InlineData(Size.Small, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Small, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Medium, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cola)]
        [InlineData(Size.Medium, SodasaurusFlavor.Lime)]
        [InlineData(Size.Medium, SodasaurusFlavor.Orange)]
        [InlineData(Size.Medium, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Medium, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Large, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Large, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Large, SodasaurusFlavor.Cola)]
        [InlineData(Size.Large, SodasaurusFlavor.Lime)]
        [InlineData(Size.Large, SodasaurusFlavor.Orange)]
        [InlineData(Size.Large, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Large, SodasaurusFlavor.Vanilla)]
        public void SodaSaurusDescriptionForSizeAndFlavor(Size size, SodasaurusFlavor flavor)
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = size;
            soda.Flavor = flavor;
            Assert.Equal($"{size} {flavor} Sodasaurus", soda.ToString());
        }

        [Theory]
        [InlineData(Size.Small, false)]
        [InlineData(Size.Medium, false)]
        [InlineData(Size.Large, false)]
        [InlineData(Size.Small, true)]
        [InlineData(Size.Medium, true)]
        [InlineData(Size.Large, true)]
        public void TyrannoTeaDescriptionForSizeAndSweetness(Size size, bool sweet)
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = size;
            tea.Sweet = sweet;
            if (sweet) Assert.Equal($"{size} Sweet Tyrannotea", tea.ToString());
            else Assert.Equal($"{size} Tyrannotea", tea.ToString());
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void WaterDescriptionForSize(Size size)
        {
            Water water = new Water();
            water.Size = size;
            Assert.Equal($"{size} Water", water.ToString());
        }

        #endregion

        #region Combos

        [Theory]
        [InlineData(typeof(Brontowurst),Size.Small, "Small Brontowurst Combo")]
        [InlineData(typeof(Brontowurst), Size.Medium, "Medium Brontowurst Combo")]
        [InlineData(typeof(Brontowurst), Size.Large, "Large Brontowurst Combo")]
        [InlineData(typeof(DinoNuggets), Size.Small, "Small Dino-Nuggets Combo")]
        [InlineData(typeof(DinoNuggets), Size.Medium, "Medium Dino-Nuggets Combo")]
        [InlineData(typeof(DinoNuggets), Size.Large, "Large Dino-Nuggets Combo")]
        [InlineData(typeof(PrehistoricPBJ), Size.Small, "Small Prehistoric PB&J Combo")]
        [InlineData(typeof(PrehistoricPBJ), Size.Medium, "Medium Prehistoric PB&J Combo")]
        [InlineData(typeof(PrehistoricPBJ), Size.Large, "Large Prehistoric PB&J Combo")]
        [InlineData(typeof(PterodactylWings), Size.Small, "Small Pterodactyl Wings Combo")]
        [InlineData(typeof(PterodactylWings), Size.Medium, "Medium Pterodactyl Wings Combo")]
        [InlineData(typeof(PterodactylWings), Size.Large, "Large Pterodactyl Wings Combo")]
        [InlineData(typeof(SteakosaurusBurger), Size.Small, "Small Steakosaurus Burger Combo")]
        [InlineData(typeof(SteakosaurusBurger), Size.Medium, "Medium Steakosaurus Burger Combo")]
        [InlineData(typeof(SteakosaurusBurger), Size.Large, "Large Steakosaurus Burger Combo")]
        [InlineData(typeof(TRexKingBurger), Size.Small, "Small T-Rex King Burger Combo")]
        [InlineData(typeof(TRexKingBurger), Size.Medium, "Medium T-Rex King Burger Combo")]
        [InlineData(typeof(TRexKingBurger), Size.Large, "Large T-Rex King Burger Combo")]
        [InlineData(typeof(VelociWrap), Size.Small, "Small Veloci-Wrap Combo")]
        [InlineData(typeof(VelociWrap), Size.Medium, "Medium Veloci-Wrap Combo")]
        [InlineData(typeof(VelociWrap), Size.Large, "Large Veloci-Wrap Combo")]

        public void ComboDescriptionShouldGiveName(Type type, Size size, string name)
        {
            Entree entree = (Entree)Activator.CreateInstance(type);
            CretaceousCombo combo = new CretaceousCombo(entree);
            combo.Size = size;
            Assert.Equal(name, combo.ToString());
        }

        #endregion
    }
}
