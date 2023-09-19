using System;

namespace ProjetoSistemaEe.Entidades
{
    public class Person
    {
        private string name;
        private string martialStatus;
        private string phone;
        private string zipCode;
        private string city;
        private string district;
        private string street;
        private DateTime birthDate;
        private string gender;
        private string state;
        private string streetNumber;
        private string email;

        public string Name { get => name; set => name = value; }
        public string MartialStatus { get => martialStatus; set => martialStatus = value; }
        public string Phone { get => phone; set => phone = value; }
        public string ZipCode { get => zipCode; set => zipCode = value; }
        public string City { get => city; set => city = value; }
        public string District { get => district; set => district = value; }
        public string Street { get => street; set => street = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string Gender { get => gender; set => gender = value; }
        public string State { get => state; set => state = value; }
        public string StreetNumber { get => streetNumber; set => streetNumber = value; }
        public string Email { get => email; set => email = value; }
    }
}