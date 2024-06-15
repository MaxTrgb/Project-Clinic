using Polyclinic.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Polyclinic.Repository
{
    public class DoctorRepository
    {
        public List<Doctor> loadDoctors(SqlConnection connection)
        {
            string query = "SELECT * FROM doctors";
            List<Doctor> doctors = new List<Doctor>();

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Doctor doctor = new Doctor(
                            Convert.ToInt32(reader["id"]),
                            Convert.ToString(reader["name"]),
                            Convert.ToString(reader["salary"]),
                            Convert.ToInt32(reader["position_id"]),
                            Convert.ToString(reader["ward"])
                        );
                        doctors.Add(doctor);
                    }
                }
            }
            return doctors;
        }
        public Doctor changeName(SqlConnection connection, string newDoctorName, int id)
        {
            string query = @"UPDATE doctors 
                           SET name = @newDoctorName 
                           WHERE id = @id";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@newDoctorName", System.Data.SqlDbType.NVarChar).Value = newDoctorName;
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
            }

            return getDoctorById(connection, id);
        }
        public Doctor changeWard(SqlConnection connection, string newDoctorWard, int id)
        {
            string updateQuery = "UPDATE doctors " +
                                 "SET ward = @newDoctorWard" +
                                 "WHERE id = @currentId";

            string selectQuery = "SELECT * " +
                                 "FROM doctors " +
                                 "WHERE id = @id";

            using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
            {
                updateCmd.Parameters.Add("@newDoctorWard", SqlDbType.NVarChar).Value = newDoctorWard;
                updateCmd.Parameters.Add("@currentId", SqlDbType.Int).Value = id;
                updateCmd.ExecuteNonQuery();
            }

            using (SqlCommand selectCmd = new SqlCommand(selectQuery, connection))
            {
                selectCmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                using (SqlDataReader reader = selectCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Doctor(
                            Convert.ToInt32(reader["id"]),
                            Convert.ToString(reader["name"]),
                            Convert.ToString(reader["salary"]),
                            Convert.ToInt32(reader["position_id"]),
                            Convert.ToString(reader["ward"])
                        );
                    }
                }
            }
            return null;
        }

        public Doctor changeSalary(SqlConnection connection, decimal newDoctorSalary, int id)
        {
            string updateQuery = "UPDATE doctors " +
                                 "SET salary = @newDoctorSalary " +
                                 "WHERE id = @currentId";
            string selectQuery = "SELECT * " +
                                 "FROM doctors " +
                                 "WHERE id = @id";

            using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
            {
                updateCmd.Parameters.Add("@newDoctorSalary", SqlDbType.Money).Value = newDoctorSalary;
                updateCmd.Parameters.Add("@currentId", SqlDbType.Int).Value = id;
                updateCmd.ExecuteNonQuery();
            }

            using (SqlCommand selectCmd = new SqlCommand(selectQuery, connection))
            {
                selectCmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                using (SqlDataReader reader = selectCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Doctor(
                            Convert.ToInt32(reader["id"]),
                            Convert.ToString(reader["name"]),
                            Convert.ToString(reader["salary"]),
                            Convert.ToInt32(reader["position_id"]),
                            Convert.ToString(reader["ward"])
                        );
                    }
                }
            }
            return null;
        }
        public Doctor changePosition(SqlConnection connection, int newPositionId, int docId)
        {
            string updateQuery = $"UPDATE doctors " +
                                 $"SET position_id = @newPositionId " +
                                 $"WHERE id = @currentId";

            string selectQuery = @"SELECT * FROM doctors 
                                 WHERE id = @id";

            using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
            {
                cmd.Parameters.Add("@newPositionId", System.Data.SqlDbType.Int).Value = newPositionId;
                cmd.Parameters.Add("@currentId", System.Data.SqlDbType.Int).Value = docId;
                cmd.ExecuteNonQuery();
            }
            using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
            {
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = docId;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Doctor(
                            Convert.ToInt32(reader["id"]),
                            Convert.ToString(reader["name"]),
                            Convert.ToString(reader["salary"]),
                            Convert.ToInt32(reader["position_id"]),
                            Convert.ToString(reader["ward"])
                        );
                    }
                }
            }
            return null;
        }

        public Doctor getDoctorById(SqlConnection connection, int id)
        {
            string query = $"SELECT * FROM doctors " +
                           $"WHERE id = @id";

            Doctor doctor = null;

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        doctor = new Doctor(
                            Convert.ToInt32(reader["id"]),
                            Convert.ToString(reader["name"]),
                            Convert.ToString(reader["salary"]),
                            Convert.ToInt32(reader["position_id"]),
                            Convert.ToString(reader["ward"])
                            );
                    }
                }
            }
            return doctor;
        }
        public Doctor getDoctorByName(SqlConnection connection, string name)
        {
            string query = $"SELECT * FROM doctors " +
                           $"WHERE name = @name";

            Doctor doctor = null;

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        doctor = new Doctor(
                            Convert.ToInt32(reader["id"]),
                            Convert.ToString(reader["name"]),
                            Convert.ToString(reader["salary"]),
                            Convert.ToInt32(reader["position_id"]),
                            Convert.ToString(reader["ward"])
                            );
                    }
                }
            }
            return doctor;
        }

        public List<Doctor> loadDoctorsByPosition(SqlConnection connection, string position)
        {
            string query = @"SELECT d.id, d.name, d.salary, d.ward, d.position_id 
                           FROM doctors d
                           JOIN positions p ON d.position_id = p.id
                           WHERE p.name = @position";

            List<Doctor> doctors = new List<Doctor>();

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@position", System.Data.SqlDbType.NVarChar).Value = position;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Doctor doctor = new Doctor(
                            Convert.ToInt32(reader["id"]),
                            Convert.ToString(reader["name"]),
                            Convert.ToString(reader["salary"]),
                            Convert.ToInt32(reader["position_id"]),
                            Convert.ToString(reader["ward"])
                        );

                        doctors.Add(doctor);
                    }
                }
            }
            return doctors;
        }

        public Doctor deleteDoctor(SqlConnection connection, int id)
        {
            string query = $"DELETE FROM doctors" +
                           $" WHERE id = @id";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@id", System.Data.SqlDbType.NVarChar).Value = id;

                cmd.ExecuteNonQuery();
            }
            return null;
        }

        public Doctor addDoctor(SqlConnection connection, string name, int position_id, string salary, string ward)
        {
            string query = $"INSERT INTO doctors " +
                           $"(name, position_id, salary, ward)" +
                           $"VALUES (@name, @position_id, @salary, @ward)";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@position_id", System.Data.SqlDbType.Int).Value = position_id;
                cmd.Parameters.Add("@salary", System.Data.SqlDbType.NVarChar).Value = salary;
                cmd.Parameters.Add("@ward", System.Data.SqlDbType.NVarChar).Value = ward;
                cmd.ExecuteNonQuery();
            }

            return getDoctorByName(connection, name);
        }

        public List<Position> loadPositions(SqlConnection connection)
        {

            string query = "SELECT * FROM positions";
            List<Position> positions = new List<Position>();

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Position position = new Position(
                        Convert.ToInt32(reader["id"]),
                        Convert.ToString(reader["name"])
                        );
                        positions.Add(position);
                    }
                }
            }
            return positions;
        }
    }
}