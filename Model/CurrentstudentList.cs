using System.Collections.Generic;
using System;

class CurrentStudentList {
    public List<CurrentStudent> currentstudentlist;

    public CurrentStudentList(){
        this.currentstudentlist = new List<CurrentStudent>();
    }

    public void AddNewCurrentStudentList(CurrentStudent currentstudent){
        this.currentstudentlist.Add(currentstudent);
    }

    public void FetchCurrentStudentList(){
        Console.WriteLine(" List CurrentStudentList ");
        Console.WriteLine("---------------------------------------------------");

        foreach(CurrentStudent currentstudent in this.currentstudentlist){
            if (currentstudent is CurrentStudent){
                Console.WriteLine("{0} {1}"
                , currentstudent.GetName(), currentstudent.GetSurName());
            }
        }
    }

    public void ShowTotalCurrentStudent(){
        int currentstudentcount = currentstudentlist.Count;
        Console.WriteLine("Total currentstudentlist in the camp : {0}", currentstudentcount.ToString());
        Console.ReadLine();
    }
}