using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibraryManagment.LibraryData.Model;
using LibraryManagment.LibraryData.DatabaseContext.RepositoryInterface;
using System.Data.SqlClient;
using LibraryManagment.LibraryData.Utils;
using LibraryManagment.LibraryData.DatabaseContext.Repository;

namespace LibraryManagment.LibraryData.DatabaseContext {
    public class KlientRepository : IKlientRepository {

        private DegaRepository degaRepository = new DegaRepository();

       
        SqlConnection connection = DatabaseConnection.connect();


        public Klient gjejMeId(int id) {
            Klient klient = new Klient();
            String queryString = "SELECT * FROM Klient WHERE id=@id";

            try {
                SqlCommand query = new SqlCommand(queryString, connection);

                query.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader reader = query.ExecuteReader();

                if (reader.Read()) {
                    klient.Id = reader.GetInt32(0);
                    klient.Emri = reader.GetString(1);
                    klient.Mbiemri = reader.GetString(2);
                    klient.Adresa = reader.GetString(3);
                    klient.NumerTelefoni = reader.GetInt32(4);
                    klient.Email = reader.GetString(5);
                    klient.Username = reader.GetString(6);
                    klient.Password = reader.GetString(7);
                    klient.Dega = degaRepository.gjejMeId(reader.GetInt32(8));
                }

                return klient;
            }
            catch(SqlException e) {
                String error = e.Message;
            }
            finally {
                connection.Close();
            }
            return klient;
        }

        public Klient gjejMeEmail(String email) {
            Klient klient = new Klient();
            String queryString = "SELECT * FROM Klient WHERE email=@email";
            try {
                SqlCommand query = new SqlCommand(queryString, connection);

                query.Parameters.AddWithValue("@email", email);

                connection.Open();
                SqlDataReader reader = query.ExecuteReader();

                if (reader.Read()) {
                    klient.Id = reader.GetInt32(0);
                    klient.Emri = reader.GetString(1);
                    klient.Mbiemri = reader.GetString(2);
                    klient.Adresa = reader.GetString(3);
                    klient.NumerTelefoni = reader.GetInt32(4);
                    klient.Email = reader.GetString(5);
                    klient.Username = reader.GetString(6);
                    klient.Password = reader.GetString(7);
                    klient.Dega = degaRepository.gjejMeId(reader.GetInt32(8));
                }

                return klient;
            } catch(SqlException e) {
                String error = e.Message;
            }
            finally {
                connection.Close();
            }
            return klient;
        }


        public List<Klient> gjejTeGjitha() {
            List<Klient> klientet = new List<Klient>();

            String queryString = "SELECT * FROM Klient";
            try {
                SqlCommand query = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = query.ExecuteReader();
                while (reader.Read()) {

                    Klient klient = new Klient();
                    klient.Id = reader.GetInt32(0);
                    klient.Emri = reader.GetString(1);
                    klient.Mbiemri = reader.GetString(2);
                    klient.Adresa = reader.GetString(3);
                    klient.NumerTelefoni = reader.GetInt32(4);
                    klient.Email = reader.GetString(5);
                    klient.Username = reader.GetString(6);
                    klient.Password = reader.GetString(7);
                    klient.Dega = degaRepository.gjejMeId(reader.GetInt32(8));

                    klientet.Add(klient);

                }

                return klientet;
            } catch(SqlException e) {
                String error = e.Message;
            }
            finally {
                connection.Close();
            }
            return klientet;

            }

        public int shto(Klient klient) {
            String queryString = "INSERT INTO Klient(id,emri,mbiemri,username,email,password,adresa,numer_telefoni,dega_id) VALUES(@id,@emri,@mbiemri,@username,@email,@password,@adresa,@numerTelefoni,@degaId) ";

            try {
                SqlCommand query = new SqlCommand(queryString, connection);

                query.Parameters.AddWithValue("@id", klient.Id);
                query.Parameters.AddWithValue("@emri", klient.Emri);
                query.Parameters.AddWithValue("@mbiemri", klient.Mbiemri);
                query.Parameters.AddWithValue("@username", klient.Username);
                query.Parameters.AddWithValue("@email", klient.Email);
                query.Parameters.AddWithValue("@password", klient.Password);
                query.Parameters.AddWithValue("@adresa", klient.Adresa);
                query.Parameters.AddWithValue("@numerTelefoni", klient.NumerTelefoni);
                query.Parameters.AddWithValue("@degaId", klient.Dega.Id);

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

        public int perditeso(Klient klient) {

            String queryString = "UPDATE Klient SET " +
            "emri=@emri,mbiemri=@mbiemri,username=@username,email=@email,password=@password,adresa=@adresa,numer_telefoni=@numerTelefoni,dega_id=@degaId";

            try {
                SqlCommand query = new SqlCommand(queryString, connection);
                query.Parameters.AddWithValue("@emri", klient.Emri);
                query.Parameters.AddWithValue("@mbiemri", klient.Mbiemri);
                query.Parameters.AddWithValue("@username", klient.Username);
                query.Parameters.AddWithValue("@email", klient.Email);
                query.Parameters.AddWithValue("@password", klient.Password);
                query.Parameters.AddWithValue("@adresa", klient.Adresa);
                query.Parameters.AddWithValue("@numerTelefoni", klient.NumerTelefoni);
                query.Parameters.AddWithValue("@degaId", klient.Dega.Id);

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

            String queryString = "DELETE FROM Klient WHERE id=@id";
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