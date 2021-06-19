using BaseFramework.Interfaces;

namespace BaseFramework.Models
{
    public class Mipp : IUnitOfMeasure
    {
        public Mipp(float amount) 
        {
            this.Amount = amount;
        }
        
        public float Amount { get; set; }

        public Kilometer ToKilometer () 
        {
            var km = new Kilometer (0);
            km.Amount = this.Amount / 2;
            return km;
        }

        public Lutt ToLutt () 
        {
            var lutt = new Lutt(0);
            lutt.Amount = this.Amount / 10;
            return lutt;
        }

        public Mipp ToMipp () 
        {
            return this;
        }
    }
}