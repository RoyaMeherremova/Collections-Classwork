

using Collections.Models;
using System.Collections;

//Employee employee1=new Employee();
//employee1.Name = "Roya";
//employee1.Id= 1;
//employee1.Age = 26;


//Employee employee2=new Employee();

//employee2.Name = "Gunel";
//employee2.Id= 2;
//employee2.Age = 27;


//var result = employee1 > employee2;
//Console.WriteLine(result);

//Hashtable datas = new Hashtable();
//datas.Add(1, "Mirze");
//datas.Add(2, "Cavid");
//datas.Add(3, "Cinare");
//foreach (DictionaryEntry item in datas)
//{
//	if ((int)item.Key==1)
//	{
//        Console.WriteLine(item.Value);
//  }

//}

//SortedList datas1 = new SortedList();
//datas1.Add(1, "Mirze");
//datas1.Add(2, "Cavid");
//datas1.Add(3, "Cinare");
////foreach (DictionaryEntry item in datas1)
////{	
////		Console.WriteLine(item.Key+"-"+item.Value);	
////}

ArrayList datas2 = new ArrayList();
//datas2.Add("Salam");
//datas2.Add(2);
//datas2.Add(true);

//foreach (var item in datas2)
//{
//    Console.WriteLine(item);
//}

//List<int> datas3 = new List<int>();
//datas3.Add(1);
//datas3.Add(2);
//datas3.Add(3);
//datas3.Sort();
//datas3.Reverse();
//datas3.Remove(1);
//datas3.RemoveAll(m => m > 3);

//foreach (var item in datas3 )
//{
//    Console.WriteLine(item);
//}

//List<string> datas4 = new List<string>() { "Cavid", "Mirze", "Aqsin", "Elcan" };

//Console.WriteLine(datas4.Count);
//for (int i = 0; i < datas4.Count; i++)
//{
//    Console.WriteLine(datas4[i]);
//}

//var result = datas4.Find(m => m == "Cavid");
//Console.WriteLine(result);
//var result1 = datas4.FindAll(m => m == "Cavid").Count;
//Console.WriteLine(result1);
////foreach (var item in datas4)
////{
////    Console.WriteLine(item);
////}

//List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 78, 6 };
//Console.WriteLine(numbers.Sum(m=> m));
//Console.WriteLine(numbers.FindAll(m => m % 2 == 0).Sum(m=>m));


//List<Student> student = new();
//List<Student> students1 = new();
//Student student1 = new()
//{
//    Id = 1,
//    FullName = "Roya Meherremova",
//    Age = 26,
//    Address = "Sumqayit"
//};
//Student student2 = new()
//{
//    Id = 2,
//    FullName = "Gunel Meherremova",
//    Age = 28,
//    Address = "Baku"
//};
//Student student3 = new()
//{
//    Id = 3,
//    FullName = "Sebnem Meherremova",
//    Age = 25,
//    Address = "Sumqayit"
//};
//Student student4 = new()
//{
//    Id = 4,
//    FullName = "Zeyneb Meherremova",
//    Age = 23,
//    Address = "Xetai"
//};
//student.Add(student1);
//student.Add(student2);
//student.Add(student3);
//student.Add(student4);
//student.AddRange(students1);

////foreach (var item in student)
////{
////    Console.WriteLine(item.FullName);
////}

//static void AddStudent(Student studenst)
//{
//    List<Student> student = new();
//    student.Add(studenst);
//}

//static List<Student> GetAllStudents()
//{
//    List<Student> student = new();
//    Student student1 = new()
//    {
//        Id = 1,
//        FullName = "Roya Meherremova",
//        Age = 26,
//        Address = "Sumqayit"
//    };
//    Student student2 = new()
//    {
//        Id = 2,
//        FullName = "Gunel Meherremova",
//        Age = 28,
//        Address = "Baku"
//    };
//    Student student3 = new()
//    {
//        Id = 3,
//        FullName = "Sebnem Meherremova",
//        Age = 25,
//        Address = "Sumqayit"
//    };
//    Student student4 = new()
//    {
//        Id = 4,
//        FullName = "Zeyneb Meherremova",
//        Age = 23,
//        Address = "Xetai"
//    };
//    student.Add(student1);
//    student.Add(student2);
//    student.Add(student3);
//    student.Add(student4);
//    return student;


//}

//Console.WriteLine("Add fullname:");
//string fullName=Console.ReadLine();
//Console.WriteLine("Add address:");
//string address=Console.ReadLine();
//Console.WriteLine("Add age:");
//int age=int.Parse(Console.ReadLine());

//Student student5 = new Student()
//{
//    Id = 5,
//    FullName = fullName,
//    Address = address,
//    Age = age
//};

//AddStudent(student5);


//static int GetStudentsCount()
//{
//    var result=GetAllStudents();
//    return result.Count;
//}

//static int GetSameNameCount()
//{
//    string text = "Cavid";
//    var result=GetAllStudents();
//    return result.FindAll(m => m.FullName.Contains(text)).Count();

//}
//Console.WriteLine(GetSameNameCount());


//SortedList<int,string> datas= new SortedList<int,string>();
//datas.Add(1, "Pervin");
//datas.Add(2, "Lale");
//datas.Add(3, "Gunel");
//foreach (KeyValuePair<int,string> item in datas)
//{
//    Console.WriteLine(item.Key +" "+ item.Value);
//}

//HashSet<int> data = new HashSet<int>();
//data.Add(1);
//data.Add(2);
//data.Add(3);
//foreach (var item in data)
//{
//    Console.WriteLine(item);
//}


//Stack<string> stack = new Stack<string>();
//stack.Push("Sagol");
//stack.Push("Salam");
//stack.Push("XXX");
//foreach (var item in stack)
//{
//    Console.WriteLine(item);
//}
//Queue<string> queue= new Queue<string>();
//queue.Enqueue("salam");
//queue.Enqueue("sagol");
//queue.Enqueue("XXX");
//foreach (var item in queue)
//{
//    Console.WriteLine(item);
//}

//Dictionary<string,string> datas2=new Dictionary<string,string>();

//datas2.Add("Admin", "Mirze");
//datas2.Add("Member", "Anar");
//datas2.Add("SuperAdmin", "Azer");
//foreach (KeyValuePair <string,string>item in datas2)
//{ 
//    if (item.Key=="Admin")
//    {
//        Console.WriteLine(item.Value);
//    }

//}

