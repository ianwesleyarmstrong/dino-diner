using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {

        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal(0.99, tea.Price, 2);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Sweet);
        }

        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Lemon);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal(0.99, tea.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            tea.Size = Size.Medium;
            Assert.Equal(1.49, tea.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectPriceForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            tea.Size = Size.Large;
            Assert.Equal(1.99, tea.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }

        [Fact]
        public void ShouldHoldIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }

        [Fact]
        public void ShouldAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }


        [Fact]
        public void ShouldHaveCorrectCaloriesForSmallAndSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            Assert.Equal<uint>(16, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMediumAndSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Sweet = true;
            Assert.Equal<uint>(32, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLargeAndSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Sweet = true;
            Assert.Equal<uint>(64, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForSmallAndNotSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForMediumAndNotSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<uint>(16, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesForLargeAndNotSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<uint>(32, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Equal(1, tea.Ingredients.Count);
        }

        [Fact]
        public void SpecialShouldBeEmpty()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Empty(tea.Special);
        }

        [Fact]
        public void SpecialShouldHoldIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.Collection<string>(tea.Special,
                 item =>
                 {
                     Assert.Equal("Hold Ice", item);
                 }
                 );
        }

        [Fact]
        public void SpecialShouldAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.Collection<string>(tea.Special,
                 item =>
                 {
                     Assert.Equal("Add Lemon", item);
                 }
                 );
        }

        [Fact]
        public void SpecialShouldHoldIceAndAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            tea.AddLemon();
            Assert.Collection<string>(tea.Special,
                 item =>
                 {
                     Assert.Equal("Hold Ice", item);
                 },
                 item =>
                 {
                     Assert.Equal("Add Lemon", item);
                 }
                 );
        }

        [Theory]
        [InlineData("Description")]
        [InlineData("Special")]
        public void ChangingSweetShouldNotifyOfPropertyChange(string propName)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, propName, () => tea.Sweet = false);
            Assert.PropertyChanged(tea, propName, () => tea.Sweet = true);
        }

        [Fact]
        public void HoldIceShouldNotifyOfPropertyChanged()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", tea.HoldIce);
        }

        [Fact]
        public void AddLemonShouldNotifyOfPropertyChanged()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", tea.AddLemon);
        }

        [Theory]
        [InlineData("Price")]
        [InlineData("Description")]
        public void ChangingSizeShouldNotifyOfPropertyChange(string propName)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, propName, () => tea.Size = Size.Small);
            Assert.PropertyChanged(tea, propName, () => tea.Size = Size.Medium);
            Assert.PropertyChanged(tea, propName, () => tea.Size = Size.Large);
        }
    }
}

