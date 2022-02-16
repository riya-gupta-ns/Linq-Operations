using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public int Id{get;set;}
    public string ? Name{get;set;}
    public string ? Department{get;set;}
    public int Age{get;set;}
}
public class Standard
{
    public int StandardID{get;set;}
    public string ? StandardName{get;set;}
}

public class EmployeeData
{
    public IList<Employee> GetEmployees(){
        return new List<Employee>() { 
        new Employee() { Id = 1, Name = "John", Department = "Dotnet", Age = 23} ,
        new Employee() { Id = 2, Name = "Moin", Department = "HR", Age = 21 } ,
        new Employee() { Id = 3, Name = "Bill", Department = "Dotnet", Age = 28 } ,
        new Employee() { Id = 4, Name = "Ram" , Department = "HR", Age = 20} ,
        new Employee() { Id = 5, Name = "Ron" , Department = "Dotnet", Age = 25 },
        new Employee() { Id = 6, Name = "Karan", Department = "Dotnet", Age = 23} ,
        new Employee() { Id = 7, Name = "Vikas", Department = "HR", Age = 21 } ,
        new Employee() { Id = 8, Name = "Kiran", Department = "Dotnet", Age = 18 } ,
        new Employee() { Id = 9, Name = "Rohan" , Department = "HR", Age = 22} ,
        new Employee() { Id = 10, Name = "Ron" , Department = "Dotnet", Age = 35 } 
        };      
    }

    public IList<Standard> GetStandard(){
        return new List<Standard>() { 
        new Standard() { StandardID = 1, StandardName = "Standard1"} ,
        new Standard() { StandardID = 2, StandardName = "Standard2"} ,
        new Standard() { StandardID = 3, StandardName = "Standard3"} ,
        };      
    }

    IList<string> strList = new List<string>() { 
                                            "One", 
                                            "Two", 
                                            "Three", 
                                            "Four", 
                                            "Five", 
                                            "Six"  };
    public void DisplayLinqQueries(){
       
// var oldest = GetEmployees().Max(s => s.Age);

// Console.WriteLine("Oldest Student Age: {0}", oldest);

// var orderByResult = from s in GetEmployees()
//                    orderby s.Name 
//                    select s;

//var studentsInAscOrder = GetEmployees().OrderBy(s => s.Name);
/* var orderByResult = from s in GetEmployees()
                   orderby s.Name, s.Age 
                   select new { s.Name, s.Age };
 */
 /* var innerJoin = GetEmployees().Join(// outer sequence 
                      GetStandard(),  // inner sequence 
                      student => student.Id,    // outerKeySelector
                      standard => standard.StandardID,  // innerKeySelector
                      (student, standard) => new  // result selector
                                    {
                                        StudentName = student.Name,
                                        StandardName = standard.StandardName
                                    }); */


//                                     var innerJoin = from s in GetEmployees() // outer sequence
//                       join st in GetStandard() //inner sequence 
//                       on s.Id equals st.StandardID // key selector 
//                       select new { // result selector 
//                                     StudentName = s.Name, 
//                                     StandardName = st.StandardName 
//                                 };
//  foreach(var employee in innerJoin)
//         {
//             Console.WriteLine(employee.StudentName);
//         }


/* var groupJoin = GetStandard().GroupJoin(GetEmployees(),  //inner sequence
                                std => std.StandardID, //outerKeySelector 
                                s => s.Id,     //innerKeySelector
                                (std, studentsGroup) => new // resultSelector 
                                {
                                    Students = studentsGroup,
                                    StandarFulldName = std.StandardName
                                });

foreach (var item in groupJoin)
{ 
    Console.WriteLine(item.StandarFulldName );

    foreach(var stud in item.Students)
        Console.WriteLine(stud.Name);
}
 */    
 /* var groupJoin = from std in GetStandard() 
                    join s in GetEmployees() 
                    on std.StandardID equals s.Id
                    into studentGroup
                    select new { 
                              Students = studentGroup , 
                              StandardName = std.StandardName 
                          };

foreach (var item in groupJoin)
{ 
                    Console.WriteLine(item.StandardName );

                    foreach(var stud in item.Students)
                    Console.WriteLine(stud.Name);
} */

// Employee std = new Employee(){ Id =3, Name = "Bill"};
// bool result = GetEmployees().Contains(std); //returns false 

// string commaSeparatedStudentNames = GetEmployees().Aggregate<Employee, string>(
//                                         "Student Names: ",  // seed value
//                                         (str, s) => str += s.Name + "," ); 
/* int SumOfStudentsAge = GetEmployees().Aggregate<Employee, int>(0, 
                                                (totalAge, s) => totalAge += s.Age  );
Console.WriteLine(SumOfStudentsAge); */

// var avgAge = GetEmployees().Average(s => s.Age);

// Console.WriteLine("Average Age of Student: {0}", avgAge);

// var totalStudents = GetEmployees().Count();

// Console.WriteLine("Total Students: {0}", totalStudents);

// var adultStudents = GetEmployees().Count(s => s.Age >= 18);

// Console.WriteLine("Number of Adult Students: {0}", adultStudents );

/* var studentWithLongName = GetEmployees().Max();

        Console.WriteLine("Student ID: {0}, Student Name: {1}", 
                                         studentWithLongName.Name); */

                                         /* var sumOfAge = GetEmployees().Sum(s => s.Age);

Console.WriteLine("Sum of all student's age: {0}", sumOfAge);
		
var numOfAdults = GetEmployees().Sum(s => {
			
	if(s.Age >= 18)
	    return 1;
	else
	    return 0;
});
 
Console.WriteLine("Total Adult Students: {0}", numOfAdults); */


/* var resultList = strList.SkipWhile(s => s.Length < 4);

foreach(string str in resultList)
        Console.WriteLine(str); */

 var newList = strList.Take(2);

foreach(var str in newList)
    Console.WriteLine(str);
    }
}