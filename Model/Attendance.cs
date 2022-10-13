public abstract class Attendance{
    private string name;
    private string age;
    private string allergy;
    private string religion;

    public Attendance(string name, string age, string allergy, string religion){
        this.name = name;
        this.age = age;
        this.allergy = allergy;
        this.religion = religion;
    }

    public string GetName(){
        return this.name;
    }

    public string GetAge(){
        return this.age;
    }

    public string GetAllergy(){
        return this.allergy;
    }

    public string GetReligion(){
        return this.religion;
    }
}

