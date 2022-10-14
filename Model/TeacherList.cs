using System.Collections.Generic;
using System;

class TeacherList {
    private List<Teacher> teacherlist;

    public TeacherList(){
        this.teacherlist = new List<Teacher>();
    }

    public void AddNewTeacherList(Teacher teacher){
        this.teacherlist.Add(teacher);
    }

    public void FetchTeacherList(){
        Console.WriteLine(" List TeacherList ");
        Console.WriteLine("---------------------------------------------------");

        foreach(Teacher teacher in this.teacherlist){
            if (teacher is Teacher){
                Console.WriteLine("{0} {1}"
                , teacher.GetName(), teacher.GetSurName());
            }
        }
         Console.ReadLine();
    }

    public void ShowTotalTeacher(){
        int teachercount = teacherlist.Count;
        Console.WriteLine("Total teacherlist in the camp : {0}", teachercount.ToString());
        Console.ReadLine();
    }
}