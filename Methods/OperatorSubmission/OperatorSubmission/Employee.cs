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
            if (emp1 is null || emp2 is null)
                return false;

            return emp1.Id == emp2.Id;
        }

        // Overloading the "!=" operator by negating the result of the "=="
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // If either emp1 or emp2 is null, return true
            if(emp1 is null || emp2 is null)
                return true;

            return emp1.Id != emp2.Id;
        }
    }
}
