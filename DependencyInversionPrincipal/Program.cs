// See https://aka.ms/new-console-template for more information

using DependencyInversionPrincipal;

Student st = new Student(IstudentRepositoryFactory.GetStudentRepository());

Console.WriteLine("Hello, World!");
