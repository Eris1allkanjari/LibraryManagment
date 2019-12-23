﻿using LibraryManagment.LibraryData.DatabaseContext.RepositoryInterface;
using LibraryManagment.LibraryData.Model;
using LibraryManagment.LibraryData.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LibraryManagment.LibraryData.DatabaseContext.Repository {
    public class CheckoutRepository : ICheckoutRepository {

        KartaRepository karteRepository = new KartaRepository();

        SqlConnection connection = DatabaseConnection.connect();
        

        public Checkout gjejMeId(int id) {

            Checkout checkout = new Checkout();

            String queryString = "SELECT * FROM Checkout WHERE id=@id";
            
                SqlCommand query = new SqlCommand(queryString, connection);

                query.Parameters.AddWithValue("@id", id);

                connection.Open();

                SqlDataReader reader = query.ExecuteReader();

                if (reader.Read()) {
                    checkout.Id = reader.GetInt32(0);
                    checkout.MarrjaLibrit = reader.GetDateTime(1);
                    checkout.MarrjaLibrit = reader.GetDateTime(2);
                    checkout.Karte = karteRepository.gjejMeId(reader.GetInt32(3));
                }

                return checkout;
            }
        

        public List<Checkout> gjejTeGjitha() {

            List<Checkout> checkouts = new List<Checkout>();

            String queryString = "SELECT * FROM Checkout ";

            SqlCommand query = new SqlCommand(queryString, connection);

            connection.Open();

            SqlDataReader reader = query.ExecuteReader();

            while (reader.Read()) {

                Checkout checkout = new Checkout();

                checkout.Id = reader.GetInt32(0);
                checkout.MarrjaLibrit = reader.GetDateTime(1);
                checkout.MarrjaLibrit = reader.GetDateTime(2);
                checkout.Karte = karteRepository.gjejMeId(reader.GetInt32(3));

                checkouts.Add(checkout);
            }

            return checkouts;
        }
        public int shto(Checkout checkout) {

            String queryString = "INSERT INTO Checkout(id,since,until,karte_id) VALUES (@id,@since,@until,@karte_id)";

            SqlCommand query = new SqlCommand(queryString, connection);

            query.Parameters.AddWithValue("@id", checkout.Id);
            query.Parameters.AddWithValue("@since", checkout.MarrjaLibrit);
            query.Parameters.AddWithValue("@until", checkout.KthimiLibrit);
            query.Parameters.AddWithValue("@karte_id", checkout.Karte.Id);

            connection.Open();

            return query.ExecuteNonQuery();
        }

        public int perditeso(Checkout checkout) {

            String queryString = "UPDATE Checkout SET id=@id,since=@since,until=@until,karte_id=@karteId";

            SqlCommand query = new SqlCommand(queryString, connection);

            query.Parameters.AddWithValue("@id", checkout.Id);
            query.Parameters.AddWithValue("@since", checkout.MarrjaLibrit);
            query.Parameters.AddWithValue("@until", checkout.KthimiLibrit);
            query.Parameters.AddWithValue("@karte_id", checkout.Karte.Id);

            connection.Open();

            return query.ExecuteNonQuery();
        }

        

        public void fshijMeId(int id) {
            String queryString = "DELETE FROM Checkout WHERE id=@id";

            SqlCommand query = new SqlCommand(queryString, connection);

            query.Parameters.AddWithValue("@id", id);

            query.ExecuteNonQuery();
        }
    }
}