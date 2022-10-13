public class Student : Attendance{
    private string level_of_education;
    private string school;

    public Student(string name, string level_of_education, string age, string allergy, string religion
    , string school) : base(name, age, allergy, religion) {
        this.level_of_education = level_of_education;
        this.school = school;
    }
}