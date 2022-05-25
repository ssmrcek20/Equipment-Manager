using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment_Manager.Models
{
    public class Posudba
    {
        public int ID { get; set; }
        public int IDCipZaposlenika { get; set; }
        public int IDFoiZaposlenika { get; set; }
        public string DatumPosudbe { get; set; }
        public string RazlogPosudbe { get; set; }
        public string DatumVracanja { get; set; }
        public int IDOpreme { get; set; }
    }
}
