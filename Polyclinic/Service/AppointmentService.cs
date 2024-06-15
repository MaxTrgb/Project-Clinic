using Polyclinic.Entity;
using Polyclinic.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Polyclinic.Service
{
    public class AppointmentService
    {
        string connectionString = System.Configuration.ConfigurationManager.
                                  ConnectionStrings["Polyclinic.Properties.Settings." +
                                  "my_databaseConnectionString"].ConnectionString;


        private AccountService accountService = new AccountService();

        private AppointmentRepository appointmentRepository = new AppointmentRepository();

        private DoctorService doctorService = new DoctorService();

        private AccountRepository accountRepository = new AccountRepository();


        public int makeAppointment(string formattedDateTime, int doctorId, string doctorWard, int accountId)
        {
            accountService.getAccountById(accountId);

            doctorService.getDoctorById(doctorId);

            Appointment appointment = null;

            int id = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    appointment = appointmentRepository.getAppointmentByDate(connection, formattedDateTime);

                }
                catch (Exception)
                {
                    throw new Exception("Internal server error");
                }
                if (appointment != null)
                {
                    throw new Exception("Date is taken");
                }
                try
                {
                    id = appointmentRepository.makeAppointment(formattedDateTime, doctorId, doctorWard, accountId, connection);

                }
                catch (Exception)
                {
                    throw new Exception("Internal server error");
                }
            }
            return id;
        }
        public List<Appointment> loadAppointmentsById(int id)
        {
            List<Appointment> appointments = new List<Appointment>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    appointments = appointmentRepository.loadAppointmentsById(id, connection);
                }
                catch (Exception)
                {
                    throw new Exception("Internal server error");
                }

                if (appointments != null)
                {
                    return appointments;
                }
                else
                {
                    throw new Exception("Internal server error");
                }
            }
        }
        public List<Appointment> loadAppointments()
        {
            List<Appointment> appointments = new List<Appointment>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    appointments = appointmentRepository.loadAppointments(connection);
                }
                catch (Exception)
                {
                    throw new Exception("Internal server error");
                }

                if (appointments != null)
                {
                    return appointments;
                }
                else
                {
                    throw new Exception("Internal server error");
                }
            }
        }

        public Appointment getAppointmentById(int id)
        {
            Appointment appointment = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    appointment = appointmentRepository.getAppointmentById(id, connection);
                }
                catch (Exception)
                {
                    throw new Exception("Internal server error");
                }

                if (appointment != null)
                {
                    return appointment;
                }
                else
                {
                    throw new Exception("Password or login incorrect");
                }
            }
        }
        public Appointment deleteAppointment(int id)
        {
            Appointment appointment = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    appointment = appointmentRepository.deleteAppointment(id, connection);
                }
                catch (Exception)
                {
                    throw new Exception("Internal server error");
                }
                if (appointment == null)
                {
                    return appointment;
                }
                else
                {
                    throw new Exception("Internal server error");
                }
            }
        }

        public int createAccountAndAppointment(string formattedDateTime, int doctorId, string doctorWard, string name, string email, string password)
        {
            int id = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlTransaction transaction = null;
                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

                    try
                    {
                        id = accountRepository.createNewAccountWithTransaction(connection, transaction, name, email, password);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    if (id == 0)
                    {
                        throw new Exception("Internal server error");

                    }
                    try
                    {
                        id = appointmentRepository.makeAppointmentWithTransaction(formattedDateTime, doctorId, doctorWard, id, connection, transaction);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    transaction.Commit();
                    return id;
                }
                catch (Exception ex)
                {
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }
                    throw new Exception(ex.Message);
                }

            }


        }
    }
}