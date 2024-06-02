using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sada.Core.Domain.Models
{
    public class Person
    {
        public required long NationalCode { get; set; }
        public required int Serial { get; set; }
        public required string Name { get; set; }
        public required string FatherName { get; set; }
        public required ShamsiDate BirthDate { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Address { get; set; }
        public Person(long nationalCode, int serial, string name, string fatherName, ShamsiDate birthDate, string phoneNumber, string address)
        {
            NationalCode = nationalCode;
            Serial = serial;
            Name = name;
            FatherName = fatherName;
            BirthDate = birthDate;
            PhoneNumber = phoneNumber;
            Address = address;
        }
    }
}
