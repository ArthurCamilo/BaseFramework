using BaseFramework.Interfaces;

namespace BaseFramework.Models
{
    public class Kilometer : IUnitOfMeasure
    {
        
        public Kilometer(float amount) 
        {
            this.Amount = amount;
        }
        
        public float Amount { get; set; }

        public Kilometer ToKilometer () 
        {
            return this;
        }

        public Lutt ToLutt () 
        {
            var mipp = this.ToMipp();
            return mipp.ToLutt();
        }

        public Mipp ToMipp () 
        {
            var mipp = new Mipp(0);
            mipp.Amount = this.Amount * 2;
            return mipp;
        }

    }
}