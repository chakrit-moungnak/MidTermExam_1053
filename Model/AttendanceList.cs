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
            if (attendance is Attendance){
                Console.WriteLine("{0}"
                , attendance.GetName());
            } else if (attendance is Student){
                Console.WriteLine("{0}"
                , attendance.GetName());
            } else if (attendance is Teacher){
                Console.WriteLine("{0}"
                , attendance.GetName());
            }
        }
    }
}