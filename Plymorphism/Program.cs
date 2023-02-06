// See https://aka.ms/new-console-template for more information
using Plymorphism;

Console.WriteLine("Hello, World!");

//Person per1 = new Person();
//per1.Id = 1; //valid
//per1.FirstName = "James"; //valid
//per1.LastName = "Bond"; //valid

////per1.CompanyName; // not supported
////per1.Salary;  // not supported

//Person per2 = new Employee();
//per2.Id = 2; //valid
//per2.FirstName = "Bill"; //valid
//per2.LastName = "Gates"; //valid

////per2.CompanyName; // not supported
////per2.Salary;  // not supported

//Employee emp = new Employee();
//emp.Id = 1; //valid
//emp.FirstName = "Steve";//valid
//emp.LastName = "Jobs";//valid
//emp.CompanyName = "XYZ"; //valid
//emp.Salary = 10000; //valid 

////invalid, can't assign base type to derived type
////Employee emp = new Person();
///


Person p1 = new Person();
p1.Greet();



Person p2 = new Employee();
p2.Id = 2; //valid
p2.FirstName = "Bill"; //valid
p2.LastName = "Gates"; //valid

//per2.CompanyName; // not supported
//per2.Salary;  // not supported
p2.Greet();

Employee emp = new Employee();
emp.Greet();

Console.ReadKey();