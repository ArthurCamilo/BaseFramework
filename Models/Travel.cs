using BaseFramework.Interfaces;
using BaseFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BaseFramework.Models
{
    public class Travel
    {
        
        public List<City> Cities { get; set; }

        public float GetTimeSpentToTravel () 
        {
            float timeSpent = 0;
            foreach (var city in this.Cities)
            {
                if (city.TargetCity != null) {
                    var timeSpentToTravel = city.GetTimeSpentToTargetInLutts();
                    timeSpent += timeSpentToTravel.Amount;
                }
            }
            return timeSpent;
        }

    }
}