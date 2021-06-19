using BaseFramework.Components.Travel.Interfaces;

namespace BaseFramework.Components.Travel.Models
{
    public class Hour : IUnitOfTime
    {
        public Hour (float amount) 
        {
            this.Amount = amount;
        }
        
        public float Amount { get; set; }

        public Wor ToWor () {
            return this.ToMir().ToWor();
        } 

        public Mir ToMir () {
            var hour = new Mir(0);
            hour.Amount = this.Amount * 2;
            return hour;
        } 

        public Dar ToDar () {
            return this.ToWor().ToDar();
        } 

        public Hour ToHour () 
        {
            return this;
        } 

    }
}