using LibraryManagment.LibraryData.DatabaseContext.RepositoryInterface;
using LibraryManagment.LibraryData.Model;
using LibraryManagment.LibraryData.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LibraryManagment.LibraryData.DatabaseContext.Repository {
    public class LibrarianRepository : ILibrarianRepository {
        private DegaRepository degaRepository = new DegaRepository();


        SqlConnection connection = DatabaseConnection.connect();


        public Librarian gjejMeId(int id) {
            Librarian librarian = new Librarian();
            String queryString = "SELECT * FROM Librarian WHERE id=@id";
            try {
                SqlCommand query = new SqlCommand(queryString, connection);

                query.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader reader = query.ExecuteReader();

                if (reader.Read()) {
                    librarian.Id = reader.GetInt32(0);
                    librarian.Emri = reader.GetString(1);
                    librarian.Mbiemri = reader.GetString(2);
                    librarian.Adresa = reader.GetString(3);
                    librarian.NumerTelefoni = reader.GetInt32(4);
                    librarian.Email = reader.GetString(5);
                    librarian.Username = reader.GetString(6);
                    librarian.Password = reader.GetString(7);
                    librarian.Dega = degaRepository.gjejMeId(reader.GetInt32(8));
                    
                }

                return librarian;
            } catch (SqlException e) {
                String error = e.Message;
            }
            finally {
                connection.Close();
            }
            return librarian;
        }

        public List<Librarian> gjejTeGjitha() {
            List<Librarian> libraShitesit = new List<Librarian>();

            String queryString = "SELECT * FROM Librarian";
            try {
                SqlCommand query = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = query.ExecuteReader();
                while (reader.Read()) {

                    Librarian librarian = new Librarian();

                    librarian.Id = reader.GetInt32(0);
                    librarian.Emri = reader.GetString(1);
                    librarian.Mbiemri = reader.GetString(2);
                    librarian.Adresa = reader.GetString(3);
                    librarian.NumerTelefoni = reader.GetInt32(4);
                    librarian.Email = reader.GetString(5);
                    librarian.Username = reader.GetString(6);
                    librarian.Password = reader.GetString(7);
                    librarian.Dega = degaRepository.gjejMeId(reader.GetInt32(8));

                    libraShitesit.Add(librarian);

                }

                return libraShitesit;
            } catch (SqlException e) {
                String error = e.Message;
            }
            finally {
                connection.Close();
            }
            return libraShitesit;

        }

        public int shto(Librarian librarian) {
            String queryString = "INSERT INTO Librarian(id,emri,mbiemri,username,email,password,adresa,numer_telefoni,dega_id) VALUES(@id,@emri,@mbiemri,@username,@email,@password,@adresa,@numerTelefoni,@degaId) ";

            try {
                SqlCommand query = new SqlCommand(queryString, connection);

                query.Parameters.AddWithValue("@id", librarian.Id);
                query.Parameters.AddWithValue("@emri", librarian.Emri);
                query.Parameters.AddWithValue("@mbiemri", librarian.Mbiemri);
                query.Parameters.AddWithValue("@username", librarian.Username);
                query.Parameters.AddWithValue("@email", librarian.Email);
                query.Parameters.AddWithValue("@password", librarian.Password);
                query.Parameters.AddWithValue("@adresa", librarian.Adresa);
                query.Parameters.AddWithValue("@numerTelefoni", librarian.NumerTelefoni);
                query.Parameters.AddWithValue("@degaId", librarian.Dega.Id);
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

        public int perditeso(Librarian librarian) {

            String queryString = "UPDATE Librarian SET id=@id,emri=@emri,mbiemri=@mbiemri,username=@username," +
                                 "email=@email,password=@password,adresa=@adresa,numer_telefoni=@numerTelefoni,dega_id=@degaId) ";

            try {
                SqlCommand query = new SqlCommand(queryString, connection);

                query.Parameters.AddWithValue("@id", librarian.Id);
                query.Parameters.AddWithValue("@emri", librarian.Emri);
                query.Parameters.AddWithValue("@mbiemri", librarian.Mbiemri);
                query.Parameters.AddWithValue("@username", librarian.Username);
                query.Parameters.AddWithValue("@email", librarian.Email);
                query.Parameters.AddWithValue("@password", librarian.Password);
                query.Parameters.AddWithValue("@adresa", librarian.Adresa);
                query.Parameters.AddWithValue("@numerTelefoni", librarian.NumerTelefoni);
                query.Parameters.AddWithValue("@degaId", librarian.Dega.Id);
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

            String queryString = "DELETE FROM Librarian WHERE id=@id";
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