using BaseFramework.Components.Travel.Models;

namespace BaseFramework.Components.Travel.Interfaces
{
    public interface IUnitOfTime
    {
         
        float Amount { get; set; }

        Wor ToWor ();

        Mir ToMir ();

        Dar ToDar ();

        Hour ToHour ();

    }
}