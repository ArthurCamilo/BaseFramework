using BaseFramework.Interfaces;

namespace BaseFramework.Models
{
    public class Dar : IUnitOfTime
    {
        
        public Dar(float amount) 
        {
            this.Amount = amount;
        }
        
        public float Amount { get; set; }

        public Wor ToWor () 
        {
            var wor = new Wor(0);
            wor.Amount = this.Amount * 10;
            return wor;
        } 

        public Mir ToMir () 
        {
            return this.ToWor().ToMir();
        } 

        public Dar ToDar ()
        {
            return this;
        } 

        public Hour ToHour () 
        {
            return this.ToMir().ToHour();
        } 

    }
}