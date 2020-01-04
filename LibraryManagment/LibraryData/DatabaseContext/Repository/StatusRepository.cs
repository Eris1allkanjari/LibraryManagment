using LibraryManagment.LibraryData.DatabaseContext.RepositoryInterface;
using LibraryManagment.LibraryData.Model;
using LibraryManagment.LibraryData.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LibraryManagment.LibraryData.DatabaseContext.Repository {
    public class StatusRepository : IStatusRepository {

        SqlConnection connection = DatabaseConnection.connect();

        public Status gjejMeId(int id) {
            Status status = new Status();
            String queryString = "SELECT * FROM Statusi WHERE id=@id";

            try {
                SqlCommand query = new SqlCommand(queryString, connection);

                query.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader reader = query.ExecuteReader();

                if (reader.Read()) {
                    status.Id = reader.GetInt32(0);
                    status.Emer = reader.GetString(1);
                    status.Pershkrim = reader.GetString(2);

                }

                return status;
            } catch (SqlException e) {
                String error = e.Message;
            }
            finally {
                connection.Close();
            }
            return status;
        }

        public List<Status> gjejTeGjitha() {
            List<Status> statuset = new List<Status>();

            String queryString = "SELECT * FROM Statusi";
            try {
                SqlCommand query = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = query.ExecuteReader();
                while (reader.Read()) {

                    Status status = new Status();

                    status.Id = reader.GetInt32(0);
                    status.Emer = reader.GetString(1);
                    status.Pershkrim = reader.GetString(2);

                    statuset.Add(status);

                }

                return statuset;
            } catch(SqlException e) {
                String error = e.Message;
            }
            finally {
                connection.Close();
            }
            return statuset;
         
        }

        public int shto(Status status) {
            String queryString = "INSERT INTO Statusi(id,emer,pershkrim) VALUES(@id,@emer,@pershkrim) ";

            try {
                SqlCommand query = new SqlCommand(queryString, connection);

                query.Parameters.AddWithValue("@id", status.Id);
                query.Parameters.AddWithValue("@emer", status.Emer);
                query.Parameters.AddWithValue("@pershkrim", status.Pershkrim);


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

        public int perditeso(Status status) {

            String queryString = "UPDATE Statusi SET emer=@emer,pershkrim=@pershkrim WHERE id=@id";
            try {
                SqlCommand query = new SqlCommand(queryString, connection);

                query.Parameters.AddWithValue("@emer", status.Emer);
                query.Parameters.AddWithValue("@pershkrim", status.Pershkrim);
                query.Parameters.AddWithValue("@id", status.Id);

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

        public void fshijMeId(int id) {

            String queryString = "DELETE FROM Statusi WHERE id=@id";
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