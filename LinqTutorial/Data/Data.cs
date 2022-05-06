using LinqTutorial.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorial
{
    public static class Data
    {
        public static IEnumerable<Pet> Pets =
            new[]
            {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                new Pet(2, "Anthony", PetType.Cat, 2f),
                new Pet(3, "Ed", PetType.Cat, 0.7f),
                new Pet(4, "Taiga", PetType.Dog, 35f),
                new Pet(5, "Rex", PetType.Dog, 40f),
                new Pet(6, "Lucky", PetType.Dog, 5f),
                new Pet(7, "Storm", PetType.Cat, 0.9f),
                new Pet(8, "Nyan", PetType.Cat, 2.2f)
            };

        public static IEnumerable<VeterinaryClinicAppointment> VeterinaryClinicAppointments =
            new[]
            {
                new VeterinaryClinicAppointment(clinicId:2, petId:1, new DateTime(2021, 10, 1, 12, 0, 0)),
                new VeterinaryClinicAppointment(clinicId:3, petId:3, new DateTime(2021, 10, 1, 12, 30, 0)),
                new VeterinaryClinicAppointment(clinicId:1, petId:4, new DateTime(2021, 10, 2, 13, 30, 0)),
                new VeterinaryClinicAppointment(clinicId:2, petId:1, new DateTime(2021, 11, 1, 12, 0, 0))
            };

        public static IEnumerable<VeterinaryClinic> VeterinaryClinics = new[]
        {
            new VeterinaryClinic(id: 1, name: "Happy Paws Clinic"),
            new VeterinaryClinic(id: 2, name: "Fish Doctor"),
            new VeterinaryClinic(id: 3, name: "Pure Purr Clinic")
        };


        public static IEnumerable<PetOwner> People =
           new[]
           {
               new PetOwner(1, "John", new [] {
                   Pets.ElementAt(0),
                   Pets.ElementAt(1),
               }),
               new PetOwner(2, "Jack", new [] {
                   Pets.ElementAt(2)
               }),
               new PetOwner(3, "Stephanie", new [] {
                   Pets.ElementAt(3),
                   Pets.ElementAt(4),
                   Pets.ElementAt(5)
               })
           };
    }
}
