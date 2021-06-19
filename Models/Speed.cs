using BaseFramework.Interfaces;

namespace BaseFramework.Models
{
    public class Speed
    {
        
        public Speed(IUnitOfMeasure measure, IUnitOfTime time, float measurePerTime) 
        {
            this.Measure = measure;
            this.Time = time;
            this.MeasurePerTime = measurePerTime;
        }
        
        public IUnitOfMeasure Measure { get; set; }
        
        public IUnitOfTime Time { get; set; }

        public float MeasurePerTime { get; set;}

    }
}