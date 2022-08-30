using Altkom.Models;

namespace ProcessFile.IServices
{
    public interface IItemService : IDisposable
    {
        Item[] Get();
    }

    public interface IBankomat
    {
        void Wplata(decimal kwota);
        void Wyplata(decimal kwota);
    }

    public interface IWplatomat
    {
        void Wplata(decimal kwota);
    }

    public interface IWyplatomat
    {
        void Wyplata(decimal kwota);
    }

    public class ABCBankomat : IWyplatomat
    {       
        public void Wyplata(decimal kwota)
        {
            // ...
        }
    }

    public class XYZBankomat : IWyplatomat, IWplatomat
    {
        public void Wplata(decimal kwota)
        {
            throw new NotImplementedException();
        }

        public void Wyplata(decimal kwota)
        {
            throw new NotImplementedException();
        }
    }
}
