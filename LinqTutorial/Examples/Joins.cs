using System.Linq;
using Utilities;

namespace LinqTutorial.MethodSyntax
{
    static class Join
    {
        //System.Linq.Enumerable.Join
        public static void Run()
        {
            //Join correlates the elements of two sequences based on matching keys

            //let's Join the Pets data with Pets' Appointments data 
            //to print full information about the appointments
            //the Join key will be the PetId, which is present in both collections
            var petsAppointmentsBasicInfo = Data.VeterinaryClinicAppointments.Join(
                Data.Pets,
                appointment => appointment.PetId,
                pet => pet.Id,
                (appointment, pet) => $"Pet name: {pet.Name}, appointment date: {appointment.Date}");
            Printer.Print(petsAppointmentsBasicInfo, nameof(petsAppointmentsBasicInfo));

            //we performed an Inner Join
            //Inner Join returns records that have matching values in both tables
            //for inner joins it doesn't matter which collection is the "outer", and which is "inner"
            //below we do the same as above, but we switch the order of the collections
            //and we get the same result (although the order of the result will be different)
            var petsAppointmentsBasicInfo2 = Data.Pets.Join(
                Data.VeterinaryClinicAppointments,
                pet => pet.Id,
                appointmet => appointmet.PetId,
                (pet, appointment) => $"Pet name: {pet.Name}, appointment date: {appointment.Date}");
            Printer.Print(petsAppointmentsBasicInfo2, nameof(petsAppointmentsBasicInfo2));

            //Now, let's try to join 3 tables together
            //Join supports joining 2 collections only,
            //so we must create an intermediate collection of results
            //that contain the result of joining two first collections
            var petsAppointmentsFullInfo = Data.Pets.Join(
                Data.VeterinaryClinicAppointments,
                pet => pet.Id,
                appointmet => appointmet.PetId,
                (pet, appointment) => new { Pet = pet, Appointment = appointment })
                .Join(
                Data.VeterinaryClinics,
                petAppointmentPair => petAppointmentPair.Appointment.ClinicId,
                clinic => clinic.Id,
                (petAppointmentPair, clinic) => $"Pet name: {petAppointmentPair.Pet.Name}," +
                $" appointment date: {petAppointmentPair.Appointment.Date}, " +
                $"at clinic {clinic.Name}");
            
            Printer.Print(petsAppointmentsFullInfo, nameof(petsAppointmentsFullInfo));
        }

        public static class QuerySyntax
        {
            public static void Run()
            {
                //Join correlates the elements of two sequences based on matching keys

                //let's Join the Pets data with Pets' Appointments data 
                //to print full information about the appointments
                //the Join key will be the PetId, which is present in both collections
                var petsAppointmentsBasicInfo = 
                    from appointment in Data.VeterinaryClinicAppointments
                    join pet in Data.Pets 
                        on appointment.PetId equals pet.Id
                    select $"Pet name: {pet.Name}, appointment date: {appointment.Date}";

                Printer.Print(petsAppointmentsBasicInfo, nameof(petsAppointmentsBasicInfo));

                //Now, let's try to join 3 tables together
                var petsAppointmentsFullInfo =
                    from appointment in Data.VeterinaryClinicAppointments
                    join pet in Data.Pets 
                        on appointment.PetId equals pet.Id
                    join clinic in Data.VeterinaryClinics 
                        on appointment.ClinicId equals clinic.Id
                    select $"Pet name: {pet.Name}," +
                           $" appointment date: {appointment.Date}, " +
                           $"at clinic {clinic.Name}";

                Printer.Print(petsAppointmentsFullInfo, nameof(petsAppointmentsFullInfo));

                //we performed an Inner Join
                //Inner Join returns records that have matching values in both tables
                //for inner joins it doesn't matter which collection is the "outer", and which is "inner"
                //below we do the same as above, but we switch the order of the collections
                //and we get the same result (although the order of the result will be different)
                var petsAppointmentsFullInfo2 =
                    from pet in Data.Pets 
                    join appointment in Data.VeterinaryClinicAppointments 
                        on pet.Id equals appointment.PetId
                    select $"Pet name: {pet.Name}, appointment date: {appointment.Date}";
                Printer.Print(petsAppointmentsFullInfo2, nameof(petsAppointmentsFullInfo2));

                //Left joins

                //now let's perform Left Join
                //Left Join returns all records from the left table,
                //and the matched records from the right table
                //in this case we want to print all Pet's data,
                //even if they don't have an appointment planned
                var leftJoin = 
                    from pet in Data.Pets
                    join appointment in Data.VeterinaryClinicAppointments
                    on pet.Id equals appointment.PetId into petsAppointments
                    from appointment in petsAppointments.DefaultIfEmpty()
                    select $"Pet name: {pet.Name}, appointment date: {appointment?.Date}";

                Printer.Print(leftJoin, nameof(leftJoin));

                //mow let's print something like this:
                //Owner1 - PetName1 - appointmentDate1, appointmentDate2
                //Owner2 - PetName2 - appointmentDate3
                //Owner3 - PetName3 - appointmentDate4, appointmentDate5
                var ownersAppointments = 
                    from person in Data.People
                    from pet in person.Pets
                    join appointment in Data.VeterinaryClinicAppointments
                    on pet.Id equals appointment.PetId into petsAppointments
                    select $"Owner: {person.Name}, " +
                    $"Pet: {pet.Name}, " +
                    $"appointment dates: " +
                    $"{string.Join(", ", petsAppointments.Select(a => a.Date))}";

                Printer.Print(ownersAppointments, nameof(ownersAppointments));
            }
        }
    }
}

