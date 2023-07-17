using MargaretShop.HR;
namespace MargaretShop.Tests

{
    public class EmployeeTests
    {
        [Fact]
        public void PerformWork_Adds_NumberOfHours()
        {
            Employee employee = new Employee("Margaret", "Winters", "margaret@mail.com", new DateTime(1990, 1, 16), 25);

            int numberOfHours = 3;
            employee.PerformWork(numberOfHours);

            Assert.Equal(numberOfHours, employee.NumberOfHoursWorked);
        }

        [Fact]
        public void PerformWork_Adds_DefaultNumberOfHours_IfNoValueSpecified()
        {
            Employee employee = new Employee("Margaret", "Winters", "margaret@mail.com", new DateTime(1990, 1, 16), 25);

            employee.PerformWork();

            Assert.Equal(1, employee.NumberOfHoursWorked);
        }
    }
}