﻿using LibraryManagment.LibraryData.DatabaseContext.RepositoryInterface;
using LibraryManagment.LibraryData.Model;
using LibraryManagment.LibraryData.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LibraryManagment.LibraryData.DatabaseContext.Repository {
    public class DegaRepository : IDegaRepository {

        SqlConnection connection = DatabaseConnection.connect();

        public Dega gjejMeId(int id) {
            Dega dega = new Dega();

            String queryString = "SELECT * from Dega where id=@id";

            SqlCommand query = new SqlCommand(queryString, connection);
            query.Parameters.AddWithValue("@id", id);

            connection.Open();
            SqlDataReader reader = query.ExecuteReader();
            if (reader.Read()) {
                dega.Id = reader.GetInt32(0);
                dega.Emri = reader.GetString(1);
                dega.Adresa = reader.GetString(2);
                dega.Pershkrim = reader.GetString(3);
          
            }

            return dega;
        }

        public List<Dega> gjejTeGjitha() {
            List<Dega> deget = new List<Dega>();

            String queryString = "SELECT * FROM Dega";
            SqlCommand query = new SqlCommand(queryString, connection);

            connection.Open();
            SqlDataReader reader = query.ExecuteReader();

            while (reader.Read()) {
                Dega dega = new Dega();

                dega.Id = reader.GetInt32(0);
                dega.Emri = reader.GetString(1);
                dega.Adresa = reader.GetString(2);
                dega.Pershkrim = reader.GetString(3);

                deget.Add(dega);
            }

            return deget;
        }


        public int shto(Dega dega) {

            String queryString = "INSERT INTO Dega(id,emri,adresa,pershkrim) VALUES(@id,@emri,@adresa,@pershkrim) ";


            SqlCommand query = new SqlCommand(queryString, connection);

            query.Parameters.AddWithValue("@id", dega.Id);
            query.Parameters.AddWithValue("@emri", dega.Emri);
            query.Parameters.AddWithValue("@adresa", dega.Adresa);
            query.Parameters.AddWithValue("@pershkrim", dega.Pershkrim);

            connection.Open();

            return query.ExecuteNonQuery();
        }

        public int perditeso(Dega dega) {

            String queryString = "UPDATE Dega SET id=@id,emri=@emri,adresa=@adresa,pershkrim=@pershkrim";

            SqlCommand query = new SqlCommand(queryString, connection);

            query.Parameters.AddWithValue("@id", dega.Id);
            query.Parameters.AddWithValue("@emri", dega.Emri);
            query.Parameters.AddWithValue("@adresa", dega.Adresa);
            query.Parameters.AddWithValue("@pershkrim", dega.Pershkrim);

            connection.Open();

            return query.ExecuteNonQuery();
        }


        public void fshijMeId(int id) {
            String queryString = "DELETE FROM Dega WHERE id=@id";

            SqlCommand query = new SqlCommand(queryString, connection);

            query.Parameters.AddWithValue("@id", id);

            query.ExecuteNonQuery();
        }
    }
}