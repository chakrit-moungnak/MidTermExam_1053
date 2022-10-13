public class Teacher : Attendance{
    private string position;
    private string car_registration;
    private string teacheremail;
    private string teacherpassword;

    public string GetTeacherEmail(){
        return this.teacheremail;
    }

    public Teacher(string name_prefix, string name, string surname, string age, string position, string allergy, string religion
    , string car_registration, string admin_position, string teacheremail, string teacherpassword) : base(name_prefix, name, surname, age, allergy, religion) {
        this.position = position;
        this.car_registration = car_registration;
        this.teacheremail = teacheremail;
        this.teacherpassword = teacherpassword;
    }
}