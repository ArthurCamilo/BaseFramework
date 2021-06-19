using BaseFramework.Components.Travel.Interfaces;
using BaseFramework.Components.Travel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BaseFramework.Components.Travel;

namespace BaseFramework.Events
{
    public class CalculateTimeSpentToTravel
    {
        public static float Run (string unitOfTime) 
        {
            var cityA = new City();
            cityA.CityName = "A"; 
            cityA.DistanceToTarget = new Lutt(4);
            cityA.SpeedToTarget = new Speed(new Lutt(0), new Wor(0), 24);

            var cityB = new City();
            cityB.CityName = "B"; 
            cityB.DistanceToTarget = new Lutt(8);
            cityB.SpeedToTarget = new Speed(new Lutt(0), new Wor(0), 30);

            var cityC = new City();
            cityC.CityName = "C"; 
            cityC.DistanceToTarget = new Lutt(10);
            cityC.SpeedToTarget = new Speed(new Lutt(0), new Wor(0), 30);
            
            var cityD = new City();
            cityD.CityName = "D"; 

            cityA.TargetCity = cityB;
            cityB.TargetCity = cityC;
            cityC.TargetCity = cityD;

            var travel = new Travel();
            travel.Cities = new List<City>();

            travel.Cities.Add(cityA);
            travel.Cities.Add(cityB);
            travel.Cities.Add(cityC);
            travel.Cities.Add(cityD);

            var timeInWors = travel.GetTimeSpentToTravel();

            return Converter.ConvertToUnitOfTime("Wor", timeInWors, unitOfTime);
        }
    }
}