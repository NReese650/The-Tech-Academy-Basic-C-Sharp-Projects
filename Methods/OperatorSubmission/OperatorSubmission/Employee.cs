using System;

namespace OperatorSubmission
{
    public class Employee
    {
        // Properties of the Employee class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overloading the "==" operator to compare Employee objects based on their Id property
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                return true;
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            return emp1.Id == emp2.Id;
        }

        // Overloading the "!=" operator by negating the result of the "=="
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }
    }
}
