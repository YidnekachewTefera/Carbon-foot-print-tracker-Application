using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace carbon_footprint_application
{
    public class calculator
    {
        public static void main(string[] args)
        {
            Console.WriteLine(diesel("12", "3"));
        }
        public static double diesel(string distanceTraveled, string usageInLiters)
        {
            var dieselCarbonIntensity = 2.68;
            var TotalCO2eEmitted = double.Parse(usageInLiters) * dieselCarbonIntensity;
            var carbonFootrPrint = TotalCO2eEmitted / (double.Parse(distanceTraveled));
            return carbonFootrPrint;
        }
        public static double gasolineOrPetrol(string distanceTraveled, string usageInLiters)
        {
            var gasolineOrPetrolCarbonIntensity = 2.31;
            var TotalCO2Emitted = double.Parse(usageInLiters) * gasolineOrPetrolCarbonIntensity;
            var carbonFootPrint = TotalCO2Emitted/(double.Parse(distanceTraveled));
            return carbonFootPrint;
        }
        public static double Electric(string distanceTraveled, string usagePerWat)
        {
            return 0;
        }
    }
}