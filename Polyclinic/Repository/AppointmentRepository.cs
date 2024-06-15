using Polyclinic.Entity;
using Polyclinic.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Polyclinic.Repository
{
    public class AppointmentRepository
    {
        public Appointment getAppointmentByDate(SqlConnection connection, string formattedDateTime)
        {
            string query = $"SELECT * " +
                           $"FROM doctors_examinations " +
                           $"WHERE date = @formattedDateTime";

            Appointment appointment = null;

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@formattedDateTime", System.Data.SqlDbType.NVarChar).Value = formattedDateTime;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        appointment = new Appointment(
                             Convert.ToInt32(reader["id"]),
                             Convert.ToString(reader["date"]),
                             Convert.ToInt32(reader["doctor_id"]),
                             Convert.ToString(reader["ward"]),
                             Convert.ToInt32(reader["account_id"])
                             );
                    }
                }
            }
            return appointment;
        }
        public int makeAppointment(string formattedDateTime, int doctorId, string doctorWard, int accountId, SqlConnection connection)
        {
            string query = $"INSERT INTO " +
                           $"doctors_examinations(date, doctor_id, ward, account_id) " +
                           $"output INSERTED.ID " +
                           $"VALUES " +
                           $"(@formattedDateTime,@doctorId,@doctorWard,@accountId)";

            int id = 0;

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@formattedDateTime", System.Data.SqlDbType.NVarChar).Value = formattedDateTime;
                cmd.Parameters.Add("@doctorId", System.Data.SqlDbType.NVarChar).Value = doctorId;
                cmd.Parameters.Add("@doctorWard", System.Data.SqlDbType.NVarChar).Value = doctorWard;
                cmd.Parameters.Add("@accountId", System.Data.SqlDbType.NVarChar).Value = accountId;

                id = (int)cmd.ExecuteScalar();
            }
            return id;
        }
        public int makeAppointmentWithTransaction(string formattedDateTime, int doctorId, string doctorWard, int accountId, SqlConnection connection, SqlTransaction transaction)
        {
            string query = $"INSERT INTO " +
                           $"doctors_examinations(date, doctor_id, ward, account_id) " +
                           $"output INSERTED.ID " +
                           $"VALUES " +
                           $"(@formattedDateTime,@doctorId,@doctorWard,@accountId)";

            int id = 0;

            using (SqlCommand cmd = new SqlCommand(query, connection, transaction))
            {
                cmd.Parameters.Add("@formattedDateTime", System.Data.SqlDbType.NVarChar).Value = formattedDateTime;
                cmd.Parameters.Add("@doctorId", System.Data.SqlDbType.NVarChar).Value = doctorId;
                cmd.Parameters.Add("@doctorWard", System.Data.SqlDbType.NVarChar).Value = doctorWard;
                cmd.Parameters.Add("@accountId", System.Data.SqlDbType.NVarChar).Value = accountId;

                id = (int)cmd.ExecuteScalar();
            }
            return id;
        }

        public List<Appointment> loadAppointmentsById(int id, SqlConnection connection)
        {
            string query = $"SELECT * " +
                           $"FROM doctors_examinations " +
                           $"WHERE account_id = @id";

            List<Appointment> appointments = new List<Appointment>();

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Appointment appointment = new Appointment(
                            Convert.ToInt32(reader["id"]),
                            Convert.ToString(reader["date"]),
                            Convert.ToInt32(reader["doctor_id"]),
                            Convert.ToString(reader["ward"]),
                            Convert.ToInt32(reader["account_id"])
                        );

                        appointments.Add(appointment);
                    }
                }
            }
            return appointments;
        }

        public List<Appointment> loadAppointments(SqlConnection connection)
        {
            string query = "SELECT * FROM " +
                           "doctors_examinations ";

            List<Appointment> appointments = new List<Appointment>();

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Appointment appointment = new Appointment(
                            Convert.ToInt32(reader["id"]),
                            Convert.ToString(reader["date"]),
                            Convert.ToInt32(reader["doctor_id"]),
                            Convert.ToString(reader["ward"]),
                            Convert.ToInt32(reader["account_id"])
                        );

                        appointments.Add(appointment);
                    }
                }
            }
            return appointments;
        }

        public Appointment getAppointmentById(int id, SqlConnection connection)
        {
            string query = "SELECT * FROM " +
                           "doctors_examinations " +
                           "WHERE id = @id";

            Appointment appointment = null;

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        appointment = new Appointment(
                        Convert.ToInt32(reader["id"]),
                        Convert.ToString(reader["date"]),
                        Convert.ToInt32(reader["doctor_id"]),
                        Convert.ToString(reader["ward"]),
                        Convert.ToInt32(reader["account_id"])
                        );
                    }
                }
            }
            return appointment;
        }

        public Appointment deleteAppointment(int id, SqlConnection connection)
        {
            string query = "DELETE FROM " +
                           "doctors_examinations " +
                           "WHERE id = @id";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                cmd.ExecuteNonQuery();
            }
            return getAppointmentById(id, connection);
        }
    }
}