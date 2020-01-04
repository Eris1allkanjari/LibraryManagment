using LibraryManagment.LibraryData.DatabaseContext.RepositoryInterface;
using LibraryManagment.LibraryData.Model;
using LibraryManagment.LibraryData.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LibraryManagment.LibraryData.DatabaseContext.Repository {
    public class KartaRepository : IKartaRepository {

        KlientRepository klientRepository = new KlientRepository();

        SqlConnection connection = DatabaseConnection.connect();
        public Karta gjejMeId(int id) {

            Karta karta = new Karta();

            String queryString = "SELECT * from Karta where id=@id";
            try {
                SqlCommand query = new SqlCommand(queryString, connection);
                query.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader reader = query.ExecuteReader();
                if (reader.Read()) {
                    karta.Id = reader.GetInt32(0);
                    karta.Pagesa = reader.GetDecimal(1);
                    karta.Klient = klientRepository.gjejMeId(reader.GetInt32(2));

                }
                return karta;
            } 
            catch(SqlException e) {
                String error = e.Message;
            }
            finally {
                connection.Close();
            }
            return karta;
        }

        public List<Karta> gjejTeGjitha() {

            List<Karta> kartat = new List<Karta>();

            String queryString = "SELECT * FROM Karta";
            try {
                SqlCommand query = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = query.ExecuteReader();

                while (reader.Read()) {
                    Karta karta = new Karta();

                    karta.Id = reader.GetInt32(0);
                    karta.Pagesa = reader.GetDecimal(1);
                    karta.Klient = klientRepository.gjejMeId(reader.GetInt32(2));

                    kartat.Add(karta);
                }

                return kartat;
            }  catch (SqlException e) {
                String error = e.Message;
            }
            finally {
                connection.Close();
            }
            return kartat;
        }


        public int shto(Karta karta) {

            String queryString = "INSERT INTO Karta(id,pagesa,klient_id) VALUES(@id,@pagesa,@klientId) ";

            try {
                SqlCommand query = new SqlCommand(queryString, connection);

                query.Parameters.AddWithValue("@id", karta.Id);
                query.Parameters.AddWithValue("@pagesa", karta.Pagesa);
                query.Parameters.AddWithValue("@klientId", karta.Klient.Id);


                connection.Open();

                int numberOfRows = query.ExecuteNonQuery();

                return numberOfRows;
            } catch (SqlException e) {
                String error = e.Message;
            }
            finally {
                connection.Close();
            }

            return 0;
        }

        public int perditeso(Karta karta) {

            String queryString = "UPDATE Karta SET pagesa=@pagesa,klient_id=@klientId WHERE id=@id";

            try {
                SqlCommand query = new SqlCommand(queryString, connection);

                query.Parameters.AddWithValue("@pagesa", karta.Pagesa);
                query.Parameters.AddWithValue("@klientId", karta.Klient.Id);
                query.Parameters.AddWithValue("@id", karta.Id);

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
            String queryString = "DELETE FROM Karta WHERE id=@id";
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