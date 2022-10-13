public class Teacher : Attendance{
    private string position;
    private string teacheremail;
    private string teacherpassword;

    public Teacher(string name, string age, string position, string allergy, string religion
    , string teacheremail, string teacherpassword) : base(name, age, allergy, religion) {
        this.position = position;
        this.teacheremail = teacheremail;
        this.teacherpassword = teacherpassword;
    }
}