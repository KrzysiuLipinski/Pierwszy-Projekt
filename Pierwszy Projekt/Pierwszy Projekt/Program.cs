using Pierwszy_Projekt;

Employee employee1 = new Employee("Kuba", "Błaszczykowski", 35);
Employee employee2 = new Employee("Łukasz", "Piszczek", 38);
Employee employee3 = new Employee("Robert", "Lewandowski", 37);

employee1.AddScore(5);
employee1.AddScore(7);
employee1.AddScore(9);
employee1.AddScore(11);
employee1.AddScore(13);

employee2.AddScore(2);
employee2.AddScore(5);
employee2.AddScore(9);
employee2.AddScore(2);
employee2.AddScore(1);

employee3.AddScore(2);
employee3.AddScore(4);
employee3.AddScore(6);
employee3.AddScore(8);
employee3.AddScore(10);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach(var employee in employees)
{
    if(employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}

Console.WriteLine($" Najlepszym piłkarzem/pracownikiem został: {employeeWithMaxResult.Name} {employeeWithMaxResult.Surname} lat {employeeWithMaxResult.Age} i zdobył: {employeeWithMaxResult.Result} punktów");
