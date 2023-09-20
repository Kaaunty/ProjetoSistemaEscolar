using System;
using System.Collections.Generic;
using System.Windows.Documents;
using System.Windows.Forms;

namespace ProjetoSistemaEe.Entidades
{
    public class Professor : Person
    {
        private string salary;
        private int id;

        private List<Subjects> subjects = new List<Subjects>();

        public Professor()
        {
        }

        public Professor(string name, List<Subjects> subjects, string salary, string martialStatus, string gender, DateTime birchDate, string email, string phone, string zipCode, string city, string state, string district, string street, string streetNumber)
        {
            Name = name;
            this.subjects = subjects;
            this.salary = salary;
            MaritalStatus = martialStatus;
            Gender = gender;
            BirthDate = birchDate;
            Email = email;
            Phone = phone;
            ZipCode = zipCode;
            City = city;
            State = state;
            District = district;
            Street = street;
            StreetNumber = streetNumber;
        }

        public Professor(int id, string name, List<Subjects> subjects, string salary, string martialStatus, string gender, DateTime birthDate, string email, string phone, string zipCode, string city, string state, string district, string street, string streetNumber)
        {
            this.id = id;
            Name = name;
            this.subjects = subjects;
            this.salary = salary;
            MaritalStatus = martialStatus;
            Gender = gender;
            BirthDate = birthDate;
            Email = email;
            Phone = phone;
            ZipCode = zipCode;
            City = city;
            State = state;
            District = district;
            Street = street;
            StreetNumber = streetNumber;
        }

        public string Salary { get => salary; set => salary = value; }
        public int Id { get => id; set => id = value; }
        public List<Subjects> Subjects { get => subjects; set => subjects = value; }

        public override string ToString()
        {
            return Name;
        }
    }
}