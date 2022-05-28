using DBLayer;
using Equipment_Manager.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equipment_Manager.Repositories
{
    public class PosudbaRepository
    {
        
        public static Posudba GetPosudba(int id)
        {
            Posudba posudba = null;

            string sql = $"SELECT * FROM Posudba WHERE ID = {id}";
            DB.SetConfiguration("ssmrcek20_DB", "ssmrcek20", "V0AIvsw=");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                posudba = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return posudba;
        }

        public static List<Posudba> GetPosudbe()
        {
            var posudbe = new List<Posudba>();

            string sql = "SELECT * FROM Posudba";
            DB.SetConfiguration("ssmrcek20_DB", "ssmrcek20", "V0AIvsw=");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Posudba posudba = CreateObject(reader);
                posudbe.Add(posudba);
            }

            reader.Close();
            DB.CloseConnection();

            return posudbe;
        }

        private static Posudba CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID"].ToString());
            int idCipZaposlenika = int.Parse(reader["IDCip"].ToString());
            int idFoiZaposlenika = int.Parse(reader["IDFoi"].ToString());
            string datumPosudbe = reader["DatumPosudbe"].ToString();
            string razlogPosudbe = reader["RazlogPosudbe"].ToString();
            string datumVracanja = reader["DatumVracanja"].ToString();
            int idOpreme = int.Parse(reader["IDOpreme"].ToString());

            var posudba = new Posudba
            {
                ID = id,
                IDCipZaposlenika =idCipZaposlenika,
                IDFoiZaposlenika=idFoiZaposlenika,
                DatumPosudbe = datumPosudbe,
                RazlogPosudbe=razlogPosudbe,
                DatumVracanja = datumVracanja,
                IDOpreme = idOpreme
            };

            return posudba;
        }
        public static void InsertPosudba(FoiZaposlenik foiZaposlenik, CipZaposlenik cipZaposlenik, Oprema oprema, int idPosudba, string datumPosudbe, string razlogPosudbe, string datumVracanja)
        {
            string sql = $"INSERT INTO Posudba (ID, IDCip, IDFoi, DatumPosudbe, RazlogPosudbe, DatumVracanja, IDOpreme) VALUES ({idPosudba}, {cipZaposlenik.ID}, {foiZaposlenik.ID}, '{datumPosudbe}', '{razlogPosudbe}', '{datumVracanja}', {oprema.ID})";
            DB.SetConfiguration("ssmrcek20_DB", "ssmrcek20", "V0AIvsw=");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static void UpdatePosudba(FoiZaposlenik foiZaposlenik, CipZaposlenik cipZaposlenik, Oprema oprema, int idPosudba, string datumPosudbe, string razlogPosudbe, string datumVracanja)
        {
            string sql = $"UPDATE Posudba SET IDCip = {cipZaposlenik.ID}, IDFoi = {foiZaposlenik.ID}, DatumPosudbe = '{datumPosudbe}', RazlogPosudbe = '{razlogPosudbe}', DatumVracanja = '{datumVracanja}', IDOpreme = {oprema.ID} WHERE ID = {idPosudba}";
            DB.SetConfiguration("ssmrcek20_DB", "ssmrcek20", "V0AIvsw=");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection(); 
        }
        public static void DeletePosudba(int ID)
        {
            string sql = $"DELETE FROM Posudba WHERE ID = {ID}";
            DB.SetConfiguration("ssmrcek20_DB", "ssmrcek20", "V0AIvsw=");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
