public abstract class Attendance{
    private string name_prefix;
    private string name;
    private string surname;
    private string age;
    private string allergy;
    private string religion;

    public Attendance(string name_prefix, string name, string surname, string age, string allergy, string religion){
        this.name_prefix = name_prefix;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.allergy = allergy;
        this.religion = religion;
    }

    public string GetNamePrefix(){
        return this.name_prefix;
    }

    public string GetName(){
        return this.name;
    }

    public string GetSurName(){
        return this.surname;
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

