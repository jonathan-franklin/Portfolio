// File Prologue
// Name: Jonathan Franklin
// Project: Project #5
// Date: October 24, 2016


// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    class ShippingCost
    {
        //Setting class constants
        private const double STANDARD_A_MULTIPLIER = 3;
        private const double STANDARD_B_MULTIPLIER = 1.45;
        private const double EXPRESS_A_MULTIPLIER = 4;
        private const double EXPRESS_B_MULTIPLIER = 2.5;
        private const double SAMEDAY_A_MULTIPLIER = 5.5;
        private const double SAMEDAY_B_MULTIPLIER = 3;
        private const double STANDARD_SURCHARGE = 2.5;
        private const double EXPRESS_SURCHARGE = 5;
        private const double SAMEDAY_SURCHARGE = 8;

        //Setting class variables
        private bool standardShipping;
        private bool expressShipping;
        private bool sameDayShipping;
        private bool categoryA;
        private bool categoryB;
        private int itemCount;
        private double itemWeight;
        private bool surcharge;
        private bool noSurcharge;
        private double shippingCost;

        //Non-parameterized Constructor
        public ShippingCost()
        {
            standardShipping = false;
            expressShipping = false;
            sameDayShipping = false;
            categoryA = false;
            categoryB = false;
            itemCount = 0;
            itemWeight = 0;
            surcharge = false;
            noSurcharge = true;
        }

        //Parameterized Constructor
        public ShippingCost(bool ss, bool es, bool sds, bool cata, bool catb, int ic, double iw, bool sr, bool nsr)
        {
            standardShipping = ss;
            expressShipping = es;
            sameDayShipping = sds;
            categoryA = cata;
            categoryB = catb;
            itemCount = ic;
            itemWeight = iw;
            surcharge = sr;
            noSurcharge = nsr;
        }

        //This method calculates the shipping cost depending on the various inputted variables.
        public double CalculateCost()
        {
            //If user selects standard shipping and category A and is located in either Hawaii or Alabama
            if (categoryA && standardShipping && surcharge)
                shippingCost = itemCount * STANDARD_A_MULTIPLIER + STANDARD_SURCHARGE;

            //If user selects express shipping and category A and is located in either Hawaii or Alabama
            else if (categoryA && expressShipping && surcharge)
                shippingCost = itemCount * EXPRESS_A_MULTIPLIER + EXPRESS_SURCHARGE;

            //If user selects same day shipping and category A and is located in either Hawaii or Alabama
            else if (categoryA && sameDayShipping && surcharge)
                shippingCost = itemCount * SAMEDAY_A_MULTIPLIER * SAMEDAY_SURCHARGE;

            //If user selects standard shipping and category A and is not located in either Hawaii or Alabama
            else if (categoryA && standardShipping && noSurcharge)
                shippingCost = itemCount * STANDARD_A_MULTIPLIER;

            //If user selects express shipping and category A and is not located in either Hawaii or Alabama
            else if (categoryA && expressShipping && noSurcharge)
                shippingCost = itemCount * EXPRESS_A_MULTIPLIER;

            //If user selects same day shipping and category A and is not located in either Hawaii or Alabama
            else if (categoryA && sameDayShipping && noSurcharge)
                shippingCost = itemCount * SAMEDAY_A_MULTIPLIER;

            //If user selects standard shipping and category B and is located in either Hawaii or Alabama
            else if (categoryB && standardShipping && surcharge)
                shippingCost = itemWeight * STANDARD_B_MULTIPLIER + STANDARD_SURCHARGE;

            //If user selects express shipping and category B and is located in either Hawaii or Alabama
            else if (categoryB && expressShipping && surcharge)
                shippingCost = itemWeight * EXPRESS_B_MULTIPLIER + EXPRESS_SURCHARGE;

            //If user selects same day shipping and category B and is located in either Hawaii or Alabama
            else if (categoryB && sameDayShipping && surcharge)
                shippingCost = itemWeight * SAMEDAY_B_MULTIPLIER * SAMEDAY_SURCHARGE;

            //If user selects standard shipping and category B and is not located in either Hawaii or Alabama
            else if (categoryB && standardShipping && noSurcharge)
                shippingCost = itemWeight * STANDARD_B_MULTIPLIER;

            //If user selects express shipping and category B and is not located in either Hawaii or Alabama
            else if (categoryB && expressShipping && noSurcharge)
                shippingCost = itemWeight * EXPRESS_B_MULTIPLIER;

            //If user selects same day shipping and category B and is not located in either Hawaii or Alabama
            else if (categoryB && sameDayShipping && noSurcharge)
                shippingCost = itemWeight * SAMEDAY_B_MULTIPLIER;

            return shippingCost;

        }
    }
}
