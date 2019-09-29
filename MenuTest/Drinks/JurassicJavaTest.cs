using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class JurassicJavaTest
    {
        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultPrice()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal(0.59, java.Price, 2);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }

        [Fact]
        public void ShouldHaveDefaultRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.LeaveRoomForCream);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForSamll()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Small;
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal(0.59, java.Price, 2);
        }
        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            java.Size = Size.Medium;
            Assert.Equal(0.99, java.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            java.Size = Size.Large;
            Assert.Equal(1.49, java.Price, 2);
        }

        [Fact]
        public void ShouldHoldIce()
        {
            JurassicJava java = new JurassicJava();
            java.Ice = true;
            java.HoldIce();
            Assert.False(java.Ice);
        }

        [Fact]
        public void ShouldLeaveRoomForCream()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream = true;
            Assert.True(java.LeaveRoomForCream);
        }

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurassicJava java = new JurassicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
            Assert.Equal(2, java.Ingredients.Count);
        }
    }
}
