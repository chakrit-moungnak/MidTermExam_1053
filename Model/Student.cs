public class Student : Attendance{
    private string level_of_education;
    private string school;

    public Student(string name_prefix, string name, string surname, string level_of_education, string age, string allergy, string religion
    , string school) : base(name_prefix, name, surname, age, allergy, religion) {
        this.level_of_education = level_of_education;
        this.school = school;
    }
}