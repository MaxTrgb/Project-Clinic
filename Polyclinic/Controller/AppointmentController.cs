using Polyclinic.Entity;
using Polyclinic.Service;
using System;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Polyclinic.Controller
{

    public class AppointmentController
    {
        private AppointmentService appointmentService = new AppointmentService();

        public Response<int> makeAppointment(string formattedDateTime, int doctorId, string doctorWard, int accountId)
        {
            Response<int> responseAppointment = new Response<int>();

            try
            {
                responseAppointment.Obj = appointmentService.makeAppointment(formattedDateTime, doctorId, doctorWard, accountId);
            }
            catch (Exception ex)
            {
                responseAppointment.errorMessage = ex.Message;
            }
            return responseAppointment;

        }
        public Response<List<Appointment>> loadAppointmentsById(int id)
        {
            Response<List<Appointment>> reponseAppointments = new Response<List<Appointment>>();
            try
            {
                reponseAppointments.Obj = appointmentService.loadAppointmentsById(id);
            }
            catch (Exception ex)
            {
                reponseAppointments.errorMessage = ex.Message;
            }
            return reponseAppointments;

        }
        public Response<List<Appointment>> loadAppointments()
        {
            Response<List<Appointment>> reponseAppointments = new Response<List<Appointment>>();
            try
            {
                reponseAppointments.Obj = appointmentService.loadAppointments();
            }
            catch (Exception ex)
            {
                reponseAppointments.errorMessage = ex.Message;
            }
            return reponseAppointments;
        }

        public Response<Appointment> getAppointmentById(int id)
        {
            Response<Appointment> reponseAppointment = new Response<Appointment>();
            try
            {
                reponseAppointment.Obj = appointmentService.getAppointmentById(id);
            }
            catch (Exception ex)
            {
                reponseAppointment.errorMessage = ex.Message;
            }
            return reponseAppointment;
        }

        public Response<Appointment> deleteAppointment(int id)
        {
            Response<Appointment> responseAppointment = new Response<Appointment>();
            try
            {
                responseAppointment.Obj = appointmentService.deleteAppointment(id);
            }
            catch (Exception ex)
            {
                responseAppointment.errorMessage = ex.Message;
            }
            return responseAppointment;
        }
        public Response<int> createAccountAndAppointment(string formattedDateTime, int doctorId, string doctorWard, string name, string email, string password)
        {
            Response<int> responseAppointment = new Response<int>();

            try
            {
                responseAppointment.Obj = appointmentService.createAccountAndAppointment(formattedDateTime, doctorId, doctorWard, name, email, password);
            }
            catch (Exception ex)
            {
                responseAppointment.errorMessage = ex.Message;
            }
            return responseAppointment;

        }
    }
}