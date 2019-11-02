using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class ComboSpecialsTests
    {
        [Fact]
        public void ShouldHaveDefualtCombos()
        {
            CretaceousCombo c = new CretaceousCombo(new Brontowurst());
            string[] specials = { "Small Fryceritops", "Small Cola Sodasaurus" };
            Assert.Equal(c.Special, specials);
        }

        [Fact]
        public void ShouldHaveCorrectHoldForEntree()
        {
            Brontowurst b = new Brontowurst();
            b.HoldOnion();
            CretaceousCombo c = new CretaceousCombo(b);
            string[] specials = { "Hold Onion", "Small Fryceritops", "Small Cola Sodasaurus" };
            Assert.Equal(c.Special, specials);
        }

        [Fact]
        public void ShouldHaveCorrectHoldForSide()
        {
            CretaceousCombo c = new CretaceousCombo(new Brontowurst());
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            c.Side = mmc;
            string[] specials = { "Small Meteor Mac and Cheese", "Small Cola Sodasaurus" };
            Assert.Equal(c.Special, specials);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialsForDrink()
        {
            CretaceousCombo c = new CretaceousCombo(new Brontowurst());
            JurassicJava java = new JurassicJava();
            java.RoomForCream = true;
            java.AddIce();
            c.Drink = java;
            string[] specials = { "Small Fryceritops", "Small Jurassic Java", "Add Ice", "Leave Room for Cream" };
            Assert.Equal(c.Special, specials);
        }

        [Fact]
        public void ShouldHaveCorrectSpecialsForAll()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            trex.HoldMayo();
            CretaceousCombo c = new CretaceousCombo(trex);
            JurassicJava java = new JurassicJava();
            java.RoomForCream = true;
            java.AddIce();
            c.Drink = java;
            Triceritots tt = new Triceritots();
            c.Side = tt;
            string[] specials = { "Hold Bun", "Hold Mayo", "Small Triceritots", "Small Jurassic Java", "Add Ice", "Leave Room for Cream" };
            Assert.Equal(c.Special, specials);
        }

    }
}
