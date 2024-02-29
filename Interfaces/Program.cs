//IPersonManager personManager = new CustomerManager();

//IPersonManager employeeManager = new EmployeeManager();

ProjectManager projectManager = new ProjectManager();
projectManager.Update(new InternManager());

interface IPersonManager
{
	//Unimplemented Operation
	void Add();
	void Update();

}
//inherits - class ---------- implements-interface
class CustomerManager : IPersonManager
{
	public void Add()
	{
        Console.WriteLine("Customer added!");
    }

	public void Update()
	{
		Console.WriteLine("Customer updated");
	}
}
class EmployeeManager : IPersonManager
{
	public void Add()
	{
        Console.WriteLine("Employee added!");
    }

	public void Update()
	{
		Console.WriteLine("Employe updated!");
	}
}
class InternManager : IPersonManager
{
	public void Add()
	{
        Console.WriteLine("Intern added!");
    }

	public void Update()
	{
        Console.WriteLine("Intern updated!");
    }
}



class ProjectManager
{
	public void Add(IPersonManager personManager)
	{
		personManager.Add();
	}
	public void Update(IPersonManager personManager)
	{
		personManager.Update();
	}
}