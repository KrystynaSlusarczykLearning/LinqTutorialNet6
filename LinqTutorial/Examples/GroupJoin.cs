using System.Linq;
using Utilities;

namespace LinqTutorial.MethodSyntax
{
    static class GroupJoin
    {
        //System.Linq.Enumerable.GroupJoin
        public static void Run()
        {
            //GroupJoin method correlates the elements of two collections
            //based on some key, and groups the results

            //let's print something like this:
            //PetName1 - appointmentDate1, appointmentDate2
            //PetName2 - appointmentDate3
            //PetName3 - appointmentDate4, appointmentDate5
            var petsGroupedAppointments = Data.Pets
                .GroupJoin(
                    Data.VeterinaryClinicAppointments,
                    pet => pet.Id,
                    appointmet => appointmet.PetId,
                    (pet, appointments) =>
                    $"Pet: {pet.Name}, " +
                    $"appointment dates: {string.Join(", ", appointments.Select(a => a.Date))}");

            Printer.Print(petsGroupedAppointments, nameof(petsGroupedAppointments));

            //now let's perform Left Join
            //Left Join returns all records from the left table,
            //and the matched records from the right table
            //in this case we want to print all Pet's data,
            //even if they don't have an appointment planned
            var leftJoin = Data.Pets.GroupJoin(
                Data.VeterinaryClinicAppointments,
                pet => pet.Id,
                appointmet => appointmet.PetId,
                (pet, appointments) => new { Pet = pet, Appointments = appointments })
                //there can be zero or more appointments in the "petAppointments" collection
                .SelectMany(petAppointments => petAppointments.Appointments.DefaultIfEmpty(),
                //without DefaultOrEmpty there would be no appointments for a given pet
                //so it wouldn't be included in results from SelectMany method
                  (petAppointment, appointment) =>
                  $"Pet name: {petAppointment.Pet.Name}, appointment date: {appointment?.Date}");
            Printer.Print(leftJoin, nameof(leftJoin));
        }
    }
}

