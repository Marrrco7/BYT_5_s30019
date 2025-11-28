// In case you need some guidance: https://refactoring.guru/design-patterns/adapter
namespace DesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem _thirdPartyBillingSystem = new();

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            var employeesList = new List<Employee>();
            var rows = employeesArray.GetLength(0);

            for (var i = 0; i < rows; i++)
            {
                var idStr = employeesArray[i, 0];
                var name = employeesArray[i, 1];
                var designation = employeesArray[i, 2];
                var salaryStr = employeesArray[i, 3];

                var employee = new Employee(int.Parse(idStr), name, designation, decimal.Parse(salaryStr));
                employeesList.Add(employee);
            }
            _thirdPartyBillingSystem.ProcessSalary(employeesList);
        }
    }
}
