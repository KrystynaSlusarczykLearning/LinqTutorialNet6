using System;

namespace LinqTutorial.DataTypes
{
    public class VeterinaryClinicAppointment
    {
        public int ClinicId { get; set; }
        public int PetId { get; }
        public DateTime Date { get; }

        public VeterinaryClinicAppointment(int clinicId, int petId, DateTime date)
        {
            ClinicId = clinicId;
            PetId = petId;
            Date = date;
        }
    }
}
