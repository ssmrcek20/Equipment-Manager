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
    public class FoiZaposlenikRepository
    {
        public static List<FoiZaposlenik> GetFoi()
        {
            var foiZaposlenici = new List<FoiZaposlenik>();

            string sql = "SELECT * FROM FoiZaposlenik";
            DB.SetConfiguration("ssmrcek20_DB", "ssmrcek20", "V0AIvsw=");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                FoiZaposlenik foiZaposlenik = CreateObject(reader);
                foiZaposlenici.Add(foiZaposlenik);
            }

            reader.Close();
            DB.CloseConnection();

            return foiZaposlenici;
        }

        private static FoiZaposlenik CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID"].ToString());
            string korisnickoIme = reader["KorisnickoIme"].ToString();
            string lozinka = reader["Lozinka"].ToString();
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();

            var foiZaposlenik = new FoiZaposlenik
            {
                ID = id,
                KorisnickoIme =korisnickoIme,
                Lozinka=lozinka,
                Ime = ime,
                Prezime=prezime
            };

            return foiZaposlenik;
        }
    }
}
