using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal(0.1, water.Price, 2);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            Water water = new Water();
            Assert.Equal<Size>(Size.Small, water.Size);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Water water = new Water();
            Assert.False(water.Lemon);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal(0.1, water.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Water water = new Water();
            water.Size = Size.Large;
            water.Size = Size.Medium;
            Assert.Equal(0.1, water.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Large;
            Assert.Equal(0.1, water.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Water water = new Water();
            water.Size = Size.Large;
            water.Size = Size.Medium;
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Large;
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
        }

        [Fact]
        public void ShouldHoldIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Water water = new Water();
            Assert.Contains<string>("Water", water.Ingredients);
            Assert.Equal(1, water.Ingredients.Count);
        }
    }
}
