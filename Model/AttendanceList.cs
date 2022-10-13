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
                Console.WriteLine("{0}{1} {2} \n Type : Current student \n Age : {3} \n Allergy : {4} \n Religion : {5} \n"
                , attendance.GetNamePrefix(), attendance.GetName(), attendance.GetSurname(), attendance.GetAge(), 
                attendance.GetAllergy(), attendance.GetReligion());
            } else if (attendance is Student){
                Console.WriteLine("{0}{1} {2} \n Type : Student \n Age : {3} \n Allergy : {4} \n Religion : {5} \n"
                , attendance.GetNamePrefix(), attendance.GetName(), attendance.GetSurname(), attendance.GetAge(), 
                attendance.GetAllergy(), attendance.GetReligion());
            } else if (attendance is Teacher){
                Console.WriteLine("{0}{1} {2} \n Type : Student \n Age : {3} \n Allergy : {4} \n Religion : {5} \n"
                , attendance.GetNamePrefix(), attendance.GetName(), attendance.GetSurname(), attendance.GetAge(), 
                attendance.GetAllergy(), attendance.GetReligion());
            }
        }
    }
}