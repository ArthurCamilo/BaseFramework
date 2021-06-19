using BaseFramework.Components.Travel.Models;

namespace BaseFramework.Components.Travel.Interfaces
{
    public interface IUnitOfMeasure
    {
         
        float Amount { get; set; }

        Kilometer ToKilometer ();

        Mipp ToMipp ();

        Lutt ToLutt ();

    }
}