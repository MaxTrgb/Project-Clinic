using Polyclinic.Entity;
using Polyclinic.Service;
using System;
using System.Collections.Generic;

namespace Polyclinic.Controller
{
    public class DoctorController
    {
        private DoctorService doctorService = new DoctorService();

        public Response<List<Doctor>> loadDoctors()
        {
            Response<List<Doctor>> responseDoctors = new Response<List<Doctor>>();
            try
            {
                responseDoctors.Obj = doctorService.loadDoctors();
            }
            catch (Exception ex)
            {
                responseDoctors.errorMessage = ex.Message;
            }
            return responseDoctors;
        }
        public Response<Doctor> changeName(string newDoctorName, int id)
        {
            Response<Doctor> responseDoctor = new Response<Doctor>();

            try
            {
                responseDoctor.Obj = doctorService.changeName(newDoctorName, id);
            }
            catch (Exception ex)
            {
                responseDoctor.errorMessage = ex.Message;
            }
            return responseDoctor;
        }

        public Response<Doctor> changeSalary(decimal newDoctorSalary, int id)
        {
            Response<Doctor> responseDoctor = new Response<Doctor>();

            try
            {
                responseDoctor.Obj = doctorService.changeSalary(newDoctorSalary, id);
            }
            catch (Exception ex)
            {
                responseDoctor.errorMessage = ex.Message;
            }
            return responseDoctor;
        }

        public Response<Doctor> changePosition(int newPositionId, int docId)
        {
            Response<Doctor> responseDoctor = new Response<Doctor>();

            try
            {
                responseDoctor.Obj = doctorService.changePosition(newPositionId, docId);
            }
            catch (Exception ex)
            {
                responseDoctor.errorMessage = ex.Message;
            }
            return responseDoctor;
        }
        public Response<Doctor> changeWard(string newDoctorWard, int id)
        {
            Response<Doctor> responseDoctor = new Response<Doctor>();

            try
            {
                responseDoctor.Obj = doctorService.changeWard(newDoctorWard, id);
            }
            catch (Exception ex)
            {
                responseDoctor.errorMessage = ex.Message;
            }
            return responseDoctor;
        }

        public Response<Doctor> getDoctorById(int id)
        {
            Response<Doctor> responseDoctor = new Response<Doctor>();
            try
            {
                responseDoctor.Obj = doctorService.getDoctorById(id);
            }
            catch (Exception ex)
            {
                responseDoctor.errorMessage = ex.Message;
            }
            return responseDoctor;

        }

        public Response<List<Doctor>> loadDoctorsByPosition(string position)
        {
            Response<List<Doctor>> reponseDoctors = new Response<List<Doctor>>();
            try
            {
                reponseDoctors.Obj = doctorService.loadDoctorsByPosition(position);
            }
            catch (Exception ex)
            {
                reponseDoctors.errorMessage = ex.Message;
            }
            return reponseDoctors;

        }

        public Response<Doctor> deleteDoctor(int id)
        {
            Response<Doctor> responseDoctor = new Response<Doctor>();

            try
            {
                responseDoctor.Obj = doctorService.deleteDoctor(id);
            }
            catch (Exception ex)
            {
                responseDoctor.errorMessage = ex.Message;
            }
            return responseDoctor;
        }

        public Response<Doctor> addDoctor(string name, int position_id, string salary, string ward)
        {
            Response<Doctor> responseDoctor = new Response<Doctor>();

            try
            {
                responseDoctor.Obj = doctorService.addDoctor(name, position_id, salary, ward);
            }
            catch (Exception ex)
            {
                responseDoctor.errorMessage = ex.Message;
            }
            return responseDoctor;
        }

        public Response<List<Position>> loadPositions()
        {
            Response<List<Position>> reponsePositions = new Response<List<Position>>();
            try
            {
                reponsePositions.Obj = doctorService.loadPositions();
            }
            catch (Exception ex)
            {
                reponsePositions.errorMessage = ex.Message;
            }
            return reponsePositions;
        }
    }
}