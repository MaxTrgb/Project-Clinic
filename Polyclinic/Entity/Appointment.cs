namespace Polyclinic.Entity
{
    public class Appointment
    {
        public Appointment(int appointmentId, string formattedDateTime, int doctorId, string doctorWard, int accountId)
        {
            id = appointmentId;
            date = formattedDateTime;
            doctor_id = doctorId;
            ward = doctorWard;
            account_id = accountId;
        }

        public int id { get; set; }
        public string date { get; set; }
        public int doctor_id { get; set; }
        public string ward { get; set; }
        public int account_id { get; set; }
    }
}