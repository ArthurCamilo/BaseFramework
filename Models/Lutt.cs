using BaseFramework.Interfaces;

namespace BaseFramework.Models
{
    public class Lutt : IUnitOfMeasure
    {
        public Lutt(float amount) 
        {
            this.Amount = amount;
        }
                
        public float Amount { get; set; }

        public Kilometer ToKilometer () 
        {
            var mipp = this.ToMipp();
            return mipp.ToKilometer();
        }

        public Lutt ToLutt () 
        {
            return this;
        }

        public Mipp ToMipp () 
        {
            var mipp = new Mipp(0);
            mipp.Amount = this.Amount * 10;
            return mipp;
        }

        
        

    }
}