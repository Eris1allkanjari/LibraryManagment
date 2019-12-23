﻿using System;
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

                SqlCommand query = new SqlCommand(queryString, connection);
                query.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader reader = query.ExecuteReader();
                if (reader.Read()) {
                    liber.Id =  reader.GetInt32(0);
                    liber.Titull =  reader.GetString(1);
                    liber.Autori =  reader.GetString(2);
                    liber.Viti = reader.GetInt32(3);
                    liber.Cmimi =  reader.GetInt32(4);

                }

                return liber;

        }

        public List<Liber> gjejTeGjitha() {
            List<Liber> librat = new List<Liber>();
            String queryString = "SELECT * from Liber";
            
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

                    librat.Add(liber);
                }
           
            return librat;

        }

        

        public int shto(Liber liber) {

            String queryString = "INSERT INTO Liber(id,titull,autori,viti,cmimi) VALUES(@id,@titull,@autori,@viti,@cmimi) ";

            
            SqlCommand query = new SqlCommand(queryString, connection);

            query.Parameters.AddWithValue("@id", liber.Id);
            query.Parameters.AddWithValue("@titull", liber.Titull);
            query.Parameters.AddWithValue("@autori", liber.Autori);
            query.Parameters.AddWithValue("@viti", liber.Viti);
            query.Parameters.AddWithValue("@cmimi", liber.Cmimi);
            connection.Open();

            return query.ExecuteNonQuery();
        }

        public int perditeso(Liber liber) {

            String queryString = "UPDATE Liber SET titull=@titull,autori=@autori,viti=@viti,cmimi=@cmimi";

            SqlCommand query = new SqlCommand(queryString, connection);

            query.Parameters.AddWithValue("@titull", liber.Id);
            query.Parameters.AddWithValue("@autori", liber.Autori);
            query.Parameters.AddWithValue("@viti", liber.Viti);
            query.Parameters.AddWithValue("@cmimi", liber.Cmimi);
            connection.Open();

            return query.ExecuteNonQuery();

        }

        public void fshijMeId(int id) {

            String queryString = "DELETE FROM Liber WHERE id=@id";

            SqlCommand query = new SqlCommand(queryString, connection);

            query.Parameters.AddWithValue("@id", id);

            query.ExecuteNonQuery();
        }

        public List<Liber> kerko(String fjala) {

            List<Liber> librat = new List<Liber>();

            String queryString = "SELECT * FROM Liber WHERE titulli LIKE '%@fjala%' OR autori  LIKE '%@fjala%'";

            SqlCommand query = new SqlCommand(queryString, connection);

            query.Parameters.AddWithValue("@fjala", fjala);

            connection.Open();
            SqlDataReader reader = query.ExecuteReader();
            while (reader.Read()) {
                Liber liber = new Liber();
                liber.Id = reader.GetInt32(0);
                liber.Titull = reader.GetString(1);
                liber.Autori = reader.GetString(2);
                liber.Viti = reader.GetInt32(3);
                liber.Cmimi = reader.GetInt32(4);

                librat.Add(liber);
            }

            return librat;
        }
    }
}