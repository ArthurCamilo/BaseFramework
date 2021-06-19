using BaseFramework.Models;

namespace BaseFramework.Interfaces
{
    public interface IUnitOfMeasure
    {
         
        float Amount { get; set; }

        Kilometer ToKilometer ();

        Mipp ToMipp ();

        Lutt ToLutt ();

    }
}