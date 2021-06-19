using BaseFramework.Components.Travel;
using BaseFramework.Components.Travel.Interfaces;
using BaseFramework.Components.Travel.Models;

namespace BaseFramework.Components.Travel
{
    public class Converter
    {
        public static float ConvertToUnitOfTime(string fromUnitOfTime, float amount, string toUnitOfTime) 
        {
            IUnitOfTime unitOfTime;

            switch(fromUnitOfTime) 
            {
                case "Hour":
                    unitOfTime = new Hour(amount);
                    break;
                case "Wor":
                    unitOfTime = new Wor(amount);
                    break;
                case "Mir":
                    unitOfTime = new Mir(amount);
                    break;
                case "Dar":
                    unitOfTime = new Dar(amount);
                    break;
                default:
                    unitOfTime = new Wor(amount);
                    break;
            }

            switch(toUnitOfTime) 
            {
                case "Hour":
                    return unitOfTime.ToHour().Amount;
                case "Wor":
                    return unitOfTime.ToWor().Amount;
                case "Mir":
                    return unitOfTime.ToMir().Amount;
                case "Dar":
                    return unitOfTime.ToDar().Amount;
            }

            return 0;
        }
    }
}