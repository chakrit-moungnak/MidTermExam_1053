using System.Collections.Generic;
using System;

class StudentList {
    private List<Student> studentlist;

    public StudentList(){
        this.studentlist = new List<Student>();
    }

    public void AddNewStudentList(Student student){
        this.studentlist.Add(student);
    }

    public void FetchStudentList(){
        Console.WriteLine(" List CurrentStudentList ");
        Console.WriteLine("---------------------------------------------------");

        foreach(Student student in this.studentlist){
            if (student is Student){
                Console.WriteLine("{0} {1}"
                , student.GetName(), student.GetSurName());
            }
        }
    }

    public void ShowTotalStudent(){
        int studentcount = studentlist.Count;
        Console.WriteLine("Total studentlist in the camp : {0}", studentcount.ToString());
        Console.ReadLine();
    }
}