using System;

namespace ProjetoSistemaEe.Entidades
{
    public class Student : Person
    {
        private int ra;
        private string period;
        private string shift;
        private Course course;

        public Student()
        {
        }

        public Student(int ra, string name, Course course, string period, string martialStatus, string gender, DateTime birthDate, string email, string shift, string phone, string zipCode, string city, string state, string district, string street, string streetNumber)
        {
            this.ra = ra;
            Name = name;
            this.Course = course;
            this.period = period;
            MartialStatus = martialStatus;
            Gender = gender;
            BirthDate = birthDate;
            Email = email;
            this.shift = shift;
            Phone = phone;
            ZipCode = zipCode;
            City = city;
            State = state;
            District = district;
            Street = street;
            StreetNumber = streetNumber;
        }

        public int RA { get => Ra; set => Ra = value; }
        public int Ra { get => ra; set => ra = value; }
        public string Period { get => period; set => period = value; }
        public string Shift { get => shift; set => shift = value; }
        public Course Course { get => course; set => course = value; }
    }
}