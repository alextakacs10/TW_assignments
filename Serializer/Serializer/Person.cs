using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializer
{
    [Serializable]
    class Person
    {
        public static int serial = 0;
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RecordTime { get; set; }
        [NonSerialized] public string serialNumber;

        public string SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }

        public Person()
        {

        }

        public Person(string name, string address, string phoneNumber, DateTime recordtime)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            RecordTime = recordtime;
            SerialNumber = (serial + 1).ToString();
        }
        
    }
}
