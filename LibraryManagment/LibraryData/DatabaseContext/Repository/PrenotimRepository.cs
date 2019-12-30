using LibraryManagment.LibraryData.DatabaseContext.RepositoryInterface;
using LibraryManagment.LibraryData.Model;
using LibraryManagment.LibraryData.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LibraryManagment.LibraryData.DatabaseContext.Repository {
    public class PrenotimRepository : IPrenotimRepository {

        LiberRepository liberRepository = new LiberRepository();
        KartaRepository kartaRepository = new KartaRepository();
        SqlConnection connection = DatabaseConnection.connect();


        public Prenotim gjejMeId(int id) {
            Prenotim prenotim = new Prenotim();
            String queryString = "SELECT * FROM Prenotim WHERE id=@id";
            try {
                SqlCommand query = new SqlCommand(queryString, connection);

                query.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader reader = query.ExecuteReader();

                if (reader.Read()) {
                    prenotim.Id = reader.GetInt32(0);
                    prenotim.VendosjaPrenotimit = reader.GetDateTime(1);
                    prenotim.Liber = liberRepository.gjejMeId(reader.GetInt32(2));
                    prenotim.Karta = kartaRepository.gjejMeId(reader.GetInt32(3));

                }

                return prenotim;
            } catch(SqlException e) {
                String error = e.Message;
            }
            finally {
                connection.Close();
            }
            return prenotim;
        }

        public List<Prenotim> gjejTeGjitha() {
            List<Prenotim> prenotimet = new List<Prenotim>();

            String queryString = "SELECT * FROM Librarian";
            try {
                SqlCommand query = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = query.ExecuteReader();
                while (reader.Read()) {

                    Prenotim prenotim = new Prenotim();

                    prenotim.Id = reader.GetInt32(0);
                    prenotim.VendosjaPrenotimit = reader.GetDateTime(1);
                    prenotim.Liber = liberRepository.gjejMeId(reader.GetInt32(2));
                    prenotim.Karta = kartaRepository.gjejMeId(reader.GetInt32(3));

                    prenotimet.Add(prenotim);

                }

                return prenotimet;
            } catch(SqlException e) {
                String error = e.Message;
            }
            finally {
                connection.Close();
            }
            return prenotimet;

        }

        public int shto(Prenotim prenotim) {
            String queryString = "INSERT INTO Prenotim(id,vendosja_prenotimit,liber_id,karte_id) VALUES(@id,@vendosjaPrenotimit,@liber_id,@karte_id) ";

            try {
                SqlCommand query = new SqlCommand(queryString, connection);

                query.Parameters.AddWithValue("@id", prenotim.Id);
                query.Parameters.AddWithValue("@vendosjaPrenotimit", prenotim.VendosjaPrenotimit);
                query.Parameters.AddWithValue("@liber_id", prenotim.Liber.Id);
                query.Parameters.AddWithValue("@karte_id", prenotim.Karta.Id);

                connection.Open();

                int numberOfRows = query.ExecuteNonQuery();
                return numberOfRows;
            } catch(SqlException e) {
                String error = e.Message;
            }
            finally {
                connection.Close();
            }
            return 0;
        }

        public int perditeso(Prenotim prenotim) {

            String queryString = "UPDATE Librarian SET id=@id,vendosja_prenotimit=@vendosjaPrenotimit,liber_id=@liberId,karte_id=@karteId";

            try {
                SqlCommand query = new SqlCommand(queryString, connection);

                query.Parameters.AddWithValue("@id", prenotim.Id);
                query.Parameters.AddWithValue("@vendosjaPrenotimit", prenotim.VendosjaPrenotimit);
                query.Parameters.AddWithValue("@liber_id", prenotim.Liber.Id);
                query.Parameters.AddWithValue("@karte_id", prenotim.Karta.Id);
                connection.Open();

                int numberOfRows = query.ExecuteNonQuery();

                return numberOfRows;
            } catch(SqlException e) {
                String error = e.Message;
            }
            finally {
                connection.Close();
            }

            return 0;
        }

        public void fshijMeId(int id) {

            String queryString = "DELETE FROM Prenotim WHERE id=@id";
            try {
                SqlCommand query = new SqlCommand(queryString, connection);

                query.Parameters.AddWithValue("@id", id);

                connection.Open();

                query.ExecuteNonQuery();
            } catch(SqlException e) {
                String error = e.Message;
            }
            finally {
                connection.Close();
            }
        }
    }
}