using System.Collections.Generic;
using System;

class AttendanceList {
    private List<Attendance> attendancelist;

    public AttendanceList(){
        this.attendancelist = new List<Attendance>();
    }

    public void AddNewAttendance(Attendance attendance){
        this.attendancelist.Add(attendance);
    }

    public void FetchAttendanceList(){
        Console.WriteLine(" List attendance ");
        Console.WriteLine("---------------------------------------------------");

        foreach(Attendance attendance in this.attendancelist){
            if (attendance is Currentstudent){
                Console.WriteLine("{0} \n Type : Current student \n Age : {1} \n Allergy : {2} \n Religion : {3} \n"
                , attendance.GetName(), attendance.GetAge(), 
                attendance.GetAllergy(), attendance.GetReligion());
            } else if (attendance is Student){
                Console.WriteLine("{0} \n Type : Student \n Age : {1} \n Allergy : {2} \n Religion : {3} \n"
                , attendance.GetName(), attendance.GetAge(), 
                attendance.GetAllergy(), attendance.GetReligion());
            } else if (attendance is Teacher){
                Console.WriteLine("{0} \n Type : Student \n Age : {1} \n Allergy : {2} \n Religion : {3} \n"
                , attendance.GetName(), attendance.GetAge(), 
                attendance.GetAllergy(), attendance.GetReligion());
            }
        }
    }
}