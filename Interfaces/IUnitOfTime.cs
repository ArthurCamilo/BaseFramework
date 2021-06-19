using BaseFramework.Models;

namespace BaseFramework.Interfaces
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