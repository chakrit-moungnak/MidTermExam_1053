public class Teacher : Attendance{
    private string position;
    private string teacheremail;
    private string teacherpassword;

    public Teacher(string name_prefix, string name, string surname, string age, string position, string allergy, string religion
    , string teacheremail, string teacherpassword) : base(name_prefix, name, surname, age, allergy, religion) {
        this.position = position;
        this.teacheremail = teacheremail;
        this.teacherpassword = teacherpassword;
    }
}