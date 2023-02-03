namespace Rest_Api.DAL;
using Rest_Api.Models;

public static class  HRManager{

  public static List<Employee> Get()
  {
      List<Employee> emplist= new List<Employee>();
      emplist.Add(new Employee(){Empid=101,Ename="Utkarsh",Job="Programmer",Deptno=10});
      emplist.Add(new Employee(){Empid=102,Ename="Harshad",Job="Analyst",Deptno=20});
      emplist.Add(new Employee(){Empid=103,Ename="Vishal",Job="Programmer",Deptno=40});
      emplist.Add(new Employee(){Empid=104,Ename="Shubham",Job="Manager",Deptno=30});
      return emplist;
  }

  public static Employee GetById(int id)
  {
    return (new Employee(){Empid=id, Ename="Rahul", Job="Coder",Deptno=20});
  }

  public static bool AddEmployee(Employee e)
  {
       System.Console.WriteLine(e.Empid+" "+ e.Ename);
       bool status= true;
       return status;
  }

  public static bool DeleteEmp(int id)
  {
     bool status=true;
    System.Console.WriteLine( $"Deleting Emp :{id}");
   
    return true;
  }
}