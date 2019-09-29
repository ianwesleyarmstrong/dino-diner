using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class SodasaurusTests
    {

        [Fact]
        public void ShouldBeAbleToSetFlavorToCola()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToVanila()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Vanila;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanila, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToLime()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToRootBeer()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToChocolate()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, soda.Flavor);
        }


        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal(1.50, soda.Price, 2);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(112, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, soda.Size);
        }






        [Fact]
        public void ShoudHaveCorrectPriceForSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal(1.50, soda.Price, 2);
        }

        [Fact]
        public void ShoudHaveCorrectPriceForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal(2.00, soda.Price, 2);
        }

        [Fact]
        public void ShoudHaveCorrectPriceForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal(2.50, soda.Price, 2);
        }

        [Fact]
        public void ShoudHaveCorrectPriceForLargeAfterChanging()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Small;
            soda.Size = Size.Large;
            Assert.Equal(2.50, soda.Price, 2);
        }

        [Fact]
        public void ShoudHaveCorrectPriceForMediumAfterChanging()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Small;
            soda.Size = Size.Medium;
            Assert.Equal(2.00, soda.Price, 2);
        }

        [Fact]
        public void ShoudHaveCorrectPriceForSmallAfterChanging()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            soda.Size = Size.Small;
            Assert.Equal(1.50, soda.Price, 2);
        }


        [Fact]
        public void CanHoldIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Contains<string>("Water", soda.Ingredients);
            Assert.Contains<string>("Natural Flavors", soda.Ingredients);
            Assert.Contains<string>("Cane Sugar", soda.Ingredients);
            Assert.Equal(3, soda.Ingredients.Count);
        }


    }
}
