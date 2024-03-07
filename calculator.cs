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
            var carbonFootrPrint = TotalCO2eEmitted / (double.Parse(distanceTraveled));//
            return carbonFootrPrint;
        }
        public static double gasolineOrPetrol(string distanceTraveled, string usageInLiters)
        {
            var gasolineOrPetrolCarbonIntensity = 2.31;
            var TotalCO2Emitted = double.Parse(usageInLiters) * gasolineOrPetrolCarbonIntensity;
            var carbonFootPrint = TotalCO2Emitted / (double.Parse(distanceTraveled));
            return carbonFootPrint;
        }
        public static double wind(string sourceType, string powerConsumption)
        {
            var windCarbonIntensity = 0.011;
            var carbonFootPrint = windCarbonIntensity * double.Parse(powerConsumption);
            return carbonFootPrint;
        }
        public static double coal(string sourceType, string powerConsumption)
        {
            var windCarbonIntensity = 0.980;
            var carbonFootPrint = windCarbonIntensity * double.Parse(powerConsumption);
            return carbonFootPrint;
        }
        public static double naturalGas(string sourceType, string powerConsumption)
        {
            var NaturalGasCarbonIntensity = 0.465;
            var carbonFootPrint = NaturalGasCarbonIntensity * double.Parse(powerConsumption);
            return carbonFootPrint;
        }
        public static double hydroPower(string sourceType, string powerConsumption)
        {
            var hydroPowerCarbonIntensity = 0.024;
            var carbonFootPrint = hydroPowerCarbonIntensity * double.Parse(powerConsumption);
            return carbonFootPrint;
        }
        public static double solar(string sourceType, string powerConsumption)
        {
            var solarCarbonIntensity = 0.049;
            var carbonFootPrint = solarCarbonIntensity * double.Parse(powerConsumption);
            return carbonFootPrint;
        }
        public static double electricCars( string distanceTraveled)
        {
            var electricCarsCarbonEmission = 0.06;
            var carbonFootPrint = electricCarsCarbonEmission*double.Parse(distanceTraveled);
            return carbonFootPrint;
        }
    }
}