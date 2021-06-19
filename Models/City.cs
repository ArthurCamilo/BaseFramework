using BaseFramework.Interfaces;

namespace BaseFramework.Models
{
    public class City
    {
        
        public string CityName { get; set; }
        
        public City TargetCity { get; set; }

        public IUnitOfMeasure DistanceToTarget { get; set; } 

        public Speed SpeedToTarget { get; set; }

        public IUnitOfTime GetTimeSpentToTargetInLutts () 
        {
            var lutt = DistanceToTarget.ToLutt();
            var time = lutt.Amount / SpeedToTarget.MeasurePerTime;
            return new Wor(time);
        }

    }
}