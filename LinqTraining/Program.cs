// See https://aka.ms/new-console-template for more information
using LinqTraining;
using System.Collections;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");
//// Data source
//string[] names = { "Bill", "Steve", "James", "Mohan" };

//// LINQ Query 
//var myLinqQuery = from name in names
//                  where name.Contains('a')
//                  select name;

//// Query execution
//foreach (var name in myLinqQuery)
//    Console.Write(name + " ");



///syntax
///
IList<string> stringList = new List<string>() {
    "C# Tutorials",
    "VB.NET Tutorials",
    "Learn C++",
    "MVC Tutorials" ,
    "Java"
};

Console.WriteLine("Query syntax");

var myLinqQuery = from language in stringList
                  where language.Contains("Tuto")
                  select language;


foreach (var name in myLinqQuery)
    Console.WriteLine(name + " ");



//select object 
// Student collection


IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 20 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
    };


//var students = from s in studentList
//               where s.Age > 12 && s.Age < 19
//               select s;//new { s.StudentName};

//var students = studentList.Where(s=> s.Age > 12 && s.Age < 19);

///studentList.Select(s=> { Console.WriteLine(s.StudentName);return true; });


//var students = studentList.Where((s,i)=> i%2==0?true:false).ToList();

//var students = studentList.Where((s, i) => {
//    if (i % 2 == 0)
//        return true;
//        return false;
//});
//int adult= 18;
//var students = studentList.Where((s,adult)=>s.Age>=adult);
//foreach (var item in students)
//{
//    Console.WriteLine(item.StudentName);
//}

/////oftype
/////

//IList mixedList = new ArrayList();
//mixedList.Add(0);
//mixedList.Add("One");
//mixedList.Add("Two");
//mixedList.Add(3);
//mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

//var strList = mixedList.OfType<string>();


//foreach (var item in strList)
//{
//    Console.WriteLine(item);
//}



//var orderByResult = from s in studentList
//                    orderby s.Age descending
//                    select s;

//var orderByResult = studentList.OrderByDescending(x=> x.Age);


//order thenby or in the query we use only comma between fields

//var orderByResult = studentList.OrderBy(x => x.Age).ThenByDescending(x=>x.StudentName);


//foreach (var item in orderByResult)
//{
//    Console.WriteLine(item.Age + " "+item.StudentName);
//}



//IList<Student> studentListG = new List<Student>() {
//        new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
//        new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
//        new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
//        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
//        new Student() { StudentID = 5, StudentName = "Abram" , Age = 21 }
//    };

////var groupedResult = from s in studentListG
////                    orderby s.Age
////                    group s by s.Age;

////var groupedResult = studentListG.GroupBy(x=>x.Age);

//var groupedResult = studentListG.ToLookup(x=>x.Age);

//foreach (var grp in groupedResult)
//{
//    Console.WriteLine($"the Key is {grp.Key}");
//    foreach (var item in grp)
//    {
//        Console.WriteLine($"name: {item.StudentName}");
//    }

//}

IList<Student> studentListJoin = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
    new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
    new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
    new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
    new Student() { StudentID = 5, StudentName = "Ron"  }
};

IList<Standard> standardList = new List<Standard>() {
    new Standard(){ StandardID = 1, StandardName="Standard 1"},
    new Standard(){ StandardID = 2, StandardName="Standard 2"},
    new Standard(){ StandardID = 3, StandardName="Standard 3"}
};


var innerjoin = studentListJoin.Join(
    standardList,
    student=>student.StandardID,
    standard => standard.StandardID,
    (student, standard) => new {
        StudentID = student.StudentID,
        StandardID= standard.StandardID

    }
    
    );

foreach (var item in innerjoin)
{
    Console.WriteLine($"{item.StudentID} {item.StandardID}");
}




Console.ReadKey();