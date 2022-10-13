public class Teacher : Attendance{
    private string position;
    private string car_registration;
    private string teacheremail;
    private string teacherpassword;

    public Teacher(string name, string age, string position, string allergy, string religion
    , string car_registration, string admin_position, string teacheremail, string teacherpassword) : base(name, age, allergy, religion) {
        this.position = position;
        this.car_registration = car_registration;
        this.teacheremail = teacheremail;
        this.teacherpassword = teacherpassword;
    }
}