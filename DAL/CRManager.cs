namespace Rest_Api.DAL;
using Rest_Api.Models;

public static class  CRManager{

  public static List<Customer> Get()
  {
      List<Customer> clist= new List<Customer>();
      clist.Add(new Customer(){Cid=101,Fname="Utkarsh",Lname="Pawar",Mono="988568985"});
      clist.Add(new Customer(){Cid=102,Fname="Harshad",Lname="Ghongade",Mono="988568985"});
      clist.Add(new Customer(){Cid=103,Fname="Vishal",Lname="Devanae",Mono="988568985"});
      clist.Add(new Customer(){Cid=104,Fname="Shubham",Lname="Mhaske",Mono="988568985"});
      return clist;
  }

  public static Customer GetById(int cid)
  {
    return (new Customer(){Cid=cid, Fname="Rahul", Lname="Thakare",Mono="98654852"});
  }

  public static bool Insert(Customer c)
  {
       System.Console.WriteLine(c.Cid+" "+ c.Fname);
       bool status= true;
       return status;
  }

  public static bool DeleteCust(int cid)
  {
     bool status=true;
    System.Console.WriteLine( $"Deleting Customer :{cid}");
   
    return true;
  }

  public static bool Update( int cid ,Customer c)
  {
    bool status =true;

    System.Console.WriteLine($"Updating {c.Fname} with {cid}... " );
    return true;
  }
}