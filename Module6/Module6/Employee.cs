using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    public class Employee
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public Employee(int aId, string aFirstName, string aLastName)
        {
            Id = aId;
            FirstName = aFirstName;
            LastName = aLastName;
        }
     

        public static bool operator == (Employee Employee1, Employee Employee2)
        {
            if (Employee1.Id.Equals(Employee2.Id)) {
                return true;
            }
            return false;
        }
        public static bool operator != (Employee Employee1, Employee Employee2)
        {
            if (!Employee1.Id.Equals(Employee2.Id))
            {
                return true;
            }
            return false;
        }
    }
}
