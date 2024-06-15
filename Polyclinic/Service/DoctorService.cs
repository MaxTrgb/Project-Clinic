using Polyclinic.Entity;
using Polyclinic.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Polyclinic.Service
{
    public class DoctorService
    {
        string connectionString = System.Configuration.ConfigurationManager.
                                  ConnectionStrings["Polyclinic.Properties.Settings." +
                                  "my_databaseConnectionString"].ConnectionString;

        private DoctorRepository doctorRepository = new DoctorRepository();

        public List<Doctor> loadDoctors()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return doctorRepository.loadDoctors(connection);
                }
                catch (Exception)
                {
                    throw new Exception("Internal server error");
                }
            }
        }

        public Doctor changeWard(string newDoctorWard, int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return doctorRepository.changeWard(connection, newDoctorWard, id);
                }
                catch (Exception)
                {
                    throw new Exception("Internal server error");
                }
            }
        }

        public Doctor changeName(string newDoctorName, int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return doctorRepository.changeName(connection, newDoctorName, id);
                }
                catch (Exception)
                {
                    throw new Exception("Internal server error");
                }
            }
        }

        public Doctor changeSalary(decimal newDoctorSalary, int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return doctorRepository.changeSalary(connection, newDoctorSalary, id);
                }
                catch (Exception)
                {
                    throw new Exception("Internal server error");
                }
            }
        }

        public Doctor changePosition(int newPositionId, int docId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return doctorRepository.changePosition(connection, newPositionId, docId);
                }
                catch (Exception)
                {
                    throw new Exception("Internal server error");
                }
            }
        }

        public Doctor getDoctorById(int id)
        {
            Doctor doctor = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    doctor = doctorRepository.getDoctorById(connection, id);
                }
                catch (Exception)
                {
                    throw new Exception("Internal server error");
                }
            }
            if (doctor == null)
            {
                throw new Exception("Doctor " + id + " not found!");
            }
            return doctor;
        }

        public List<Doctor> loadDoctorsByPosition(string position)
        {
            List<Doctor> doctors = new List<Doctor>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    doctors = doctorRepository.loadDoctorsByPosition(connection, position);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

                if (doctors != null)
                {
                    return doctors;
                }
                else
                {
                    throw new Exception("Password or login incorrect");
                }
            }
        }
        public Doctor deleteDoctor(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return doctorRepository.deleteDoctor(connection, id);
                }
                catch (Exception)
                {
                    throw new Exception("Internal server error");
                }
            }
        }

        public Doctor addDoctor(string name, int position_id, string salary, string ward)
        {
            Doctor doctor = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    doctor = doctorRepository.getDoctorByName(connection, name);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw new Exception("Internal server error");
                }
                if (doctor != null)
                {
                    throw new Exception("Account already exists!");
                }

                try
                {
                    return doctorRepository.addDoctor(connection, name, position_id, salary, ward);
                }
                catch
                {
                    Console.WriteLine("Internal server error");
                }

            }
            return doctor;
        }

        public List<Position> loadPositions()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return doctorRepository.loadPositions(connection);
                }
                catch (Exception)
                {
                    throw new Exception("Internal server error");
                }
            }
        }
    }
}