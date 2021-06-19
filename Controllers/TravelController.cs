using BaseFramework.Components.Travel.Interfaces;
using BaseFramework.Components.Travel.Models;
using BaseFramework.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BaseFramework.Components.Travel;

namespace BaseFramework.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TravelController : ControllerBase
    {

        [HttpGet]
        public float Get(string unitOfTime)
        {
            return CalculateTimeSpentToTravel.Run(unitOfTime);
        }
    }
}