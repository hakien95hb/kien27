using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAAA.Entity
{
    class Class1
    {
        private long _studentid;
        private string _firstName;
        private string _lastName;
        private string _phoneNumber;
        private string _email;
        public long studentid { get => studentid; set => studentid = value; }
        public string firstName { get => firstName; set => firstName = value; }
        public string lastName { get => lastName; set => lastName = value; }
        public string phoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string email { get => _email; set => _email = value; }
    }
}
