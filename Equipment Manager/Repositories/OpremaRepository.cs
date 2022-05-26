using DBLayer;
using Equipment_Manager.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment_Manager.Repositories
{
    public class OpremaRepository
    {
        public static Oprema GetOpreme(int id)
        {
            Oprema oprema = null;

            string sql = $"SELECT * FROM Oprema WHERE ID = {id}";
            DB.SetConfiguration("ssmrcek20_DB", "ssmrcek20", "V0AIvsw=");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                oprema = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return oprema;
        }
        public static List<Oprema> GetOprema()
        {
            var opreme = new List<Oprema>();

            string sql = "SELECT * FROM Oprema";
            DB.SetConfiguration("ssmrcek20_DB", "ssmrcek20", "V0AIvsw=");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Oprema oprema = CreateObject(reader);
                opreme.Add(oprema);
            }

            reader.Close();
            DB.CloseConnection();

            return opreme;
        }

        private static Oprema CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID"].ToString());
            string nabavitelj = reader["Nabavitelj"].ToString();
            string datumZaprimanja = reader["DatumZaprimanja"].ToString();
            string izvorFinanciranja = reader["IzvorFinanciranja"].ToString();
            string nazivProjekta = reader["NazivProjekta"].ToString();
            string vrstaOpreme = reader["VrstaOpreme"].ToString();
            string nazivOpreme = reader["NazivOpreme"].ToString();
            string opisOpreme = reader["OpisOpreme"].ToString();
            int idCipZaposlenika = int.Parse(reader["IdCipZaposlenika"].ToString());

            var oprema = new Oprema
            {
                ID = id,
                Nabavitelj = nabavitelj,
                DatumZaprimanja = datumZaprimanja,
                IzvorFinanciranja = izvorFinanciranja,
                NazivProjekta = nazivProjekta,
                VrstaOpreme = vrstaOpreme,
                NazivOpreme= nazivOpreme,
                OpisOpreme = opisOpreme,
                IDCipZaposlenika = idCipZaposlenika
            };

            return oprema;
        }
    }
}
