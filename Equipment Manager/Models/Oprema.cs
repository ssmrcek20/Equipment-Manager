using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment_Manager.Models
{
    public class Oprema
    {
        public int ID { get; set; }
        public string Nabavitelj { get; set; }
        public string DatumZaprimanja { get; set; }
        public string IzvorFinanciranja { get; set; }
        public string NazivProjekta { get; set; }
        public string VrstaOpreme { get; set; }
        public string NazivOpreme { get; set; }
        public string OpisOpreme { get; set; }
        public int IDCipZaposlenika { get; set; }
        public string GetNazivOpreme()
        {
            return NazivOpreme;
        }
    }
}
