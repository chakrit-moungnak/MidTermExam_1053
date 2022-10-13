public class Student : Attendance{
    private int level_of_education;
    private string school;

    public Student(string name, string age, int level_of_education, string allergy, string religion
    , string school) : base(name, age, allergy, religion) {
        this.level_of_education = level_of_education;
        this.school = school;
    }
}