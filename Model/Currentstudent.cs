public class Currentstudent : Attendance{
    private string studentID;

    private string admin_position;
    private string currentstudentemail;
    private string currentstudentpassword;

    public Currentstudent(string name_prefix, string name, string surname, string studentID, string age, string allergy, string religion
    , string admin_position, string currentstudentemail, string currentstudentpassword) : base(name_prefix, name, surname, age, allergy, religion) {
        this.studentID = studentID;
        this.admin_position = admin_position;
        this.currentstudentemail = currentstudentemail;
        this.currentstudentpassword = currentstudentpassword;
    }
}