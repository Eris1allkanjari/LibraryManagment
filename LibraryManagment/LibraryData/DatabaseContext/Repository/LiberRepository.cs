using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using LibraryManagment.LibraryData.DatabaseContext.RepositoryInterface;
using LibraryManagment.LibraryData.Model;
using LibraryManagment.LibraryData.Utils;

namespace LibraryManagment.LibraryData.DatabaseContext.Repository {
    public class LiberRepository : ILiberRepository {

        SqlConnection connection = DatabaseConnection.connect();

        public Liber gjejMeId(int id) {

            Liber liber = new Liber();

            String queryString  = "SELECT * from Liber where id=@id" ;
            try {
                SqlCommand query = new SqlCommand(queryString, connection);
                query.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader reader = query.ExecuteReader();
                if (reader.Read()) {
                    liber.Id = reader.GetInt32(0);
                    liber.Titull = reader.GetString(1);
                    liber.Autori = reader.GetString(2);
                    liber.Viti = reader.GetInt32(3);
                    liber.Cmimi = reader.GetInt32(4);
                    liber.ImageUrl = reader.GetString(5);

                }

                return liber;
            } catch(SqlException e) {
                String error = e.Message;
            }
            finally {
                connection.Close();
            }
            
            return liber;
            

        }

        public List<Liber> gjejTeGjitha() {
            List<Liber> librat = new List<Liber>();
            String queryString = "SELECT * from Liber";
            try {
                SqlCommand query = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = query.ExecuteReader();
                while (reader.Read()) {
                    Liber liber = new Liber();
                    liber.Id = reader.GetInt32(0);
                    liber.Titull = reader.GetString(1);
                    liber.Autori = reader.GetString(2);
                    liber.Viti = reader.GetInt32(3);
                    liber.Cmimi = reader.GetInt32(4);
                    liber.ImageUrl = reader.GetString(6);

                    librat.Add(liber);
                }
                return librat;
            } catch(SqlException e) {
                String error = e.Message;
            }
            finally {
                connection.Close();
            }
            
            return librat;
           

        }

        

        public int shto(Liber liber) {

            String queryString = "INSERT INTO Liber(id,titull,autori,viti,cmimi) VALUES(@id,@titull,@autori,@viti,@cmimi) ";

            try {
                SqlCommand query = new SqlCommand(queryString, connection);

                query.Parameters.AddWithValue("@id", liber.Id);
                query.Parameters.AddWithValue("@titull", liber.Titull);
                query.Parameters.AddWithValue("@autori", liber.Autori);
                query.Parameters.AddWithValue("@viti", liber.Viti);
                query.Parameters.AddWithValue("@cmimi", liber.Cmimi);
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

        public int perditeso(Liber liber) {

            String queryString = "UPDATE Liber SET titull=@titull,autori=@autori,viti=@viti,cmimi=@cmimi WHERE id=@id";
            try {

                SqlCommand query = new SqlCommand(queryString, connection);

                query.Parameters.AddWithValue("@titull", liber.Titull);
                query.Parameters.AddWithValue("@autori", liber.Autori);
                query.Parameters.AddWithValue("@viti", liber.Viti);
                query.Parameters.AddWithValue("@cmimi", liber.Cmimi);
                query.Parameters.AddWithValue("@id", liber.Id);
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

            String queryString = "DELETE FROM Liber WHERE id=@id";
            try {
                SqlCommand query = new SqlCommand(queryString, connection);

                query.Parameters.AddWithValue("@id", id);

                connection.Open();

                query.ExecuteNonQuery();
            }
            catch (SqlException e) {
                String error = e.Message;
            }
            finally {
                connection.Close();
            }
            
        }

        public List<Liber> kerko(String fjala) {

            List<Liber> librat = new List<Liber>();

            
            try {
                
                String queryString = "SELECT * FROM Liber WHERE titull LIKE @fjala OR autori LIKE @fjala";
                SqlCommand query = new SqlCommand(queryString, connection);

                String param = "%" + fjala + "%";
                query.Parameters.AddWithValue("@fjala", param);


                connection.Open();
                SqlDataReader reader = query.ExecuteReader();
                while (reader.Read()) {
                    Liber liber = new Liber();
                    liber.Id = reader.GetInt32(0);
                    liber.Titull = reader.GetString(1);
                    liber.Autori = reader.GetString(2);
                    liber.Viti = reader.GetInt32(3);
                    liber.Cmimi = reader.GetInt32(4);
                    liber.ImageUrl = reader.GetString(6);

                    librat.Add(liber);
                }
            } catch(SqlException e) {
                String error = e.Message;
            }
            finally {
                connection.Close();
            }
            
            return librat;

            
        }
    }
}