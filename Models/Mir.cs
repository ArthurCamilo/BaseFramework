using BaseFramework.Interfaces;

namespace BaseFramework.Models
{
    public class Mir : IUnitOfTime
    {
        public Mir(float amount) 
        {
            this.Amount = amount;
        }
        
        public float Amount { get; set; }

        public Wor ToWor () {
            return this.ToDar().ToWor();
        } 

        public Mir ToMir () 
        {
            return this;
        } 

        public Dar ToDar () {
            return this.ToHour().ToDar();
        } 

        public Hour ToHour () 
        {
            var hour = new Hour(0);
            hour.Amount = this.Amount / 2;
            return hour;
        }

    }
}