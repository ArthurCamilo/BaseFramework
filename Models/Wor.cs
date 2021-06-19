using BaseFramework.Interfaces;

namespace BaseFramework.Models
{
    public class Wor : IUnitOfTime
    {
        public Wor(float amount) 
        {
            this.Amount = amount;
        }
        
        public float Amount { get; set; }

        public Wor ToWor ()
        {
            return this;
        } 

        public Mir ToMir () 
        {
            var mir = new Mir(0);
            mir.Amount = this.Amount * 5;
            return mir;
        } 

        public Dar ToDar () 
        {
            var dar = new Dar(0);
            dar.Amount = this.Amount / 10;
            return dar;
        } 

        public Hour ToHour () {
            return this.ToMir().ToHour();
        } 

    }
}