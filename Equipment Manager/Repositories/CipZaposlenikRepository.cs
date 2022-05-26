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
    public class CipZaposlenikRepository
    {
        public static CipZaposlenik GetCips(int id)
        {
            CipZaposlenik cipZaposlenik = null;

            string sql = $"SELECT * FROM CipZaposlenik WHERE ID = {id}";
            DB.SetConfiguration("ssmrcek20_DB", "ssmrcek20", "V0AIvsw=");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                cipZaposlenik = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return cipZaposlenik;
        }
        public static List<CipZaposlenik> GetCip()
        {
            var cipZaposlenici = new List<CipZaposlenik>();

            string sql = "SELECT * FROM CipZaposlenik";
            DB.SetConfiguration("ssmrcek20_DB", "ssmrcek20", "V0AIvsw=");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                CipZaposlenik cipZaposlenik = CreateObject(reader);
                cipZaposlenici.Add(cipZaposlenik);
            }

            reader.Close();
            DB.CloseConnection();

            return cipZaposlenici;
        }

        private static CipZaposlenik CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID"].ToString());
            string korisnickoIme = reader["KorisnickoIme"].ToString();
            string lozinka = reader["Lozinka"].ToString();
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();

            var cipZaposlenik = new CipZaposlenik
            {
                ID = id,
                KorisnickoIme =korisnickoIme,
                Lozinka=lozinka,
                Ime = ime,
                Prezime=prezime
            };

            return cipZaposlenik;
        }
    }
}
