using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Vjezba6.Enumeracija;

namespace Vjezba6
{
    public class StanjeProjekta
    {
        public StatusProjekta TrenutniStatus { get; set; }

        private Dictionary<Prijelaz, StatusProjekta> dozvoljeniPrijelazi;

        public StanjeProjekta()
        {
            TrenutniStatus = StatusProjekta.NemaRijeci;
            DefinirajDopustenePrijelaze();
        }

        private void DefinirajDopustenePrijelaze()
        {
            dozvoljeniPrijelazi = new Dictionary<Prijelaz, StatusProjekta>();
            dozvoljeniPrijelazi.Add(new Prijelaz(StatusProjekta.NemaRijeci, Dogadjaj.RijecUnesena), StatusProjekta.ImaRijeci);
            dozvoljeniPrijelazi.Add(new Prijelaz(StatusProjekta.ImaRijeci, Dogadjaj.RijecUpisanaZaPrijevod), StatusProjekta.ImaRijeciZaPrijevod);
            dozvoljeniPrijelazi.Add(new Prijelaz(StatusProjekta.ImaRijeciZaPrijevod, Dogadjaj.PrijevodManjeOdJedneRijeci), StatusProjekta.ImaViseRijeciZaPrijevod);
            dozvoljeniPrijelazi.Add(new Prijelaz(StatusProjekta.ImaViseRijeciZaPrijevod, Dogadjaj.RijecNePostoji), StatusProjekta.NemaRijeci);
            dozvoljeniPrijelazi.Add(new Prijelaz(StatusProjekta.ImaViseRijeciZaPrijevod, Dogadjaj.PrijevodRijeci), StatusProjekta.RijecPrevedena);

        }

        public void IzvrsiPrijelaz(Dogadjaj aktivacijskiDogadjaj)
        {
            Prijelaz prijelaz = new Prijelaz(TrenutniStatus, aktivacijskiDogadjaj);
            StatusProjekta odredisniStatus;

            if(dozvoljeniPrijelazi.TryGetValue(prijelaz, out odredisniStatus) == false)
            {
                throw new ApplicationException($"Prijelaz {TrenutniStatus} -> {aktivacijskiDogadjaj} nije moguc");
            }

            TrenutniStatus = odredisniStatus;


        }
    }
}
