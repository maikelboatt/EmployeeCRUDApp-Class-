using EmployeeComponent.Data;

namespace EmployeeComponent.Views
{
	public class EmployeeDeleteView
	{
		Employees _employees = null;

		public EmployeeDeleteView( Employees employees )
		{
			_employees = employees;
		}

		public void RunDeleteView()
		{
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Please enter the ID of the employee you wish to delete.");

			int id = Convert.ToInt32(Console.ReadLine());

			Console.Clear();

			Console.WriteLine(EmployeeCommonOutputText.GetApplicationHeading());

			int index = _employees.Find(id);

			if (index != -1)
			{

				Employee employee = _employees[index];
				Console.WriteLine($"Are you sure you want to delete employee with Id {employee.Id}? (Y/N)");

				ConsoleKey consoleKey = Console.ReadKey().Key;

				if (consoleKey == ConsoleKey.Y)
				{
					_employees.Delete(index);
				}
			}
			else
			{
				Console.Clear();
				Console.WriteLine(EmployeeCommonOutputText.GetApplicationHeading());
				Console.WriteLine(EmployeeCommonOutputText.GetEmployeeNotFoundMessage(id));
				Console.ReadKey();
			}
		}
	}
}
