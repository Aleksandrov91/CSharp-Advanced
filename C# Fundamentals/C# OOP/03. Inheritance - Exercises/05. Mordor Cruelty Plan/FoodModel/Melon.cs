﻿namespace _05.Mordor_Cruelty_Plan.FoodModel
{
    public class Melon : Food
    {
        private int pointsOfHappines = 1;

        public override int FoodFactor
        {
            get { return this.pointsOfHappines; }
        }
    }
}
