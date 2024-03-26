﻿using DTOLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EmergencyContactDAL : Database
    {
        public void CreateEmergencyContact(EmergencyContactDTO contact)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand(
                    "INSERT INTO EmergencyContact (FirstName, LastName, PhoneNumber, Email) " +
                    "VALUES (@FirstName, @LastName, @PhoneNumber, @Email)", connection);

                command.Parameters.AddWithValue("@FirstName", contact.FirstName);
                command.Parameters.AddWithValue("@LastName", contact.LastName);
                command.Parameters.AddWithValue("@PhoneNumber", contact.PhoneNumber);
                command.Parameters.AddWithValue("@Email", contact.Email);

                command.ExecuteNonQuery();
            }
        }

        public EmergencyContactDTO ReadEmergencyContact(int id)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("SELECT * FROM EmergencyContact WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new EmergencyContactDTO
                        {
                            Id = (int)reader["Id"],
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Email = reader["Email"].ToString()
                        };
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public void UpdateEmergencyContact(EmergencyContactDTO contact)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("UPDATE EmergencyContact SET FirstName=@FirstName,LastName=@LastName,PhoneNumber=@PhoneNumber,Email=@Email" +
                    "WHERE Id=@Id", connection);
                command.Parameters.AddWithValue("@Id", contact.Id);
                command.Parameters.AddWithValue("@FirstName", contact.FirstName);
                command.Parameters.AddWithValue("@LastName", contact.LastName);
                command.Parameters.AddWithValue("@PhoneNumber", contact.PhoneNumber);
                command.Parameters.AddWithValue("@Email", contact.Email);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteEmergencyContact(int id)
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("DELETE FROM EmergencyContact WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
        }

        public List<EmergencyContactDTO> GetAllEmergencyContacts()
        {
            var contacts = new List<EmergencyContactDTO>();
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("SELECT * FROM EmergencyContact", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        contacts.Add(new EmergencyContactDTO
                        {
                            Id = (int)reader["Id"],
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Email = reader["Email"].ToString()
                        });
                    }
                }
            }
            return contacts;
        }

    }
}
