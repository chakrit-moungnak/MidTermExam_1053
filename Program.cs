enum Menu {
    RegistrationToCamp = 1, ShowAttendanceStatistics = 2, Login = 3
}

enum RegistrationType{
    CurrentStudent = 1, Student = 2, Teacher = 3
}

enum NamePrefix{
    Mr = 1, Mrs = 2, Miss = 3
}

enum Religion{
    Buddhism = 1, Christianity = 2, Islam = 3, Other = 4
}

enum Car{
    Yes = 1, No = 2
}

enum Admin{
    Yes = 1, No = 2
}

class Program {

    static AttendanceList attendancelist;

    static void Main(string[] args) {
        AddAttendanceListWhenProgramIsLoad();
        PrintMenuScreen();
    }

    static void PrintMenuScreen() {
        Console.Clear();

        PrintMenu();
        InputSelectedMenu();
    }

    static void PrintMenu(){
        Console.WriteLine(" Welcome into the Idia camp 2022 ");
        Console.WriteLine("------------- What do you want to do? -------------");
        Console.WriteLine(" 1.Registration into the camp ");
        Console.WriteLine(" 2.Show attendance statistics ");
        Console.WriteLine(" 3.Login ");
        Console.WriteLine("---------------------------------------------------");
    }

    static void InputSelectedMenu(){
        Console.Write("Please input selected menu : ");
        Menu menu = (Menu)(int.Parse(Console.ReadLine()));

        SelectMenu(menu);
    }

    static void SelectMenu(Menu menu){
        switch(menu) {
            case Menu.RegistrationToCamp : ShowRegistrationScreen();
                break;
            case Menu.ShowAttendanceStatistics : ShowAttendanceScreen();
                break;
            case Menu.Login : ShowLoginScreen();
                break;
            default :
                break; 
        }
    }

    static void ShowRegistrationScreen(){
        Console.Clear();

        PrintHeaderRegistration();

        InputNewAttendance();
    }

    static void ShowAttendanceScreen(){
        Console.Clear();
    }

    static void ShowLoginScreen(){
        Console.Clear();
    }

    static void PrintHeaderRegistration(){
        Console.WriteLine(" Register new attendance ");
        Console.WriteLine("---------------------------------------------------");
    }

    static void InputNewAttendance(){
        Console.Clear();
        PrintHeaderRegistration();

        PrintRegisterType();
        InputSelectedType();
    }

    static void PrintRegisterType(){
        Console.WriteLine(" Please Select register type ");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine(" 1.Current student ");
        Console.WriteLine(" 2.Student ");
        Console.WriteLine(" 3.Teacher ");
        Console.WriteLine("---------------------------------------------------");
    }

    static void InputSelectedType(){
        Console.Write("Please input selected menu : ");
        RegistrationType type = (RegistrationType)(int.Parse(Console.ReadLine()));

        SelectType(type);
    }

    static void SelectType(RegistrationType type){
        switch(type) {
            case RegistrationType.CurrentStudent : ShowRegistrationCurrentStudentScreen();
                break;
            case RegistrationType.Student : ShowRegistrationStudentScreen();
                break;
            case RegistrationType.Teacher : ShowRegistrationTeacherScreen();
                break;
            default :
                break; 
        }
    }

    static void ShowRegistrationCurrentStudentScreen(){
        Console.Clear();

        PrintHeaderCurrentStudentRegistration();

        InputNewCurrentStudent();
    }

    static void ShowRegistrationStudentScreen(){
        Console.Clear();

        PrintHeaderStudentRegistration();

        InputNewStudent();
    }

    static void ShowRegistrationTeacherScreen(){
        Console.Clear();

        PrintHeaderTeacherRegistration();

        InputNewTeacher();
    }

    static void PrintHeaderCurrentStudentRegistration(){
        Console.WriteLine(" Register : Current student ");
        Console.WriteLine("---------------------------------------------------");
    }

    static void PrintHeaderStudentRegistration(){
        Console.WriteLine(" Register : Student ");
        Console.WriteLine("---------------------------------------------------");
    }

    static void PrintHeaderTeacherRegistration(){
        Console.WriteLine(" Register : Teacher ");
        Console.WriteLine("---------------------------------------------------");
    }

    static void InputNewCurrentStudent(){
        Console.Clear();
        PrintHeaderCurrentStudentRegistration();

        Currentstudent currentstudent = new Currentstudent(InputSurname(), InputStudentID(), InputAge(),
         InputAllergy(), InputReligion(), InputAdmin(), InputEmail(), InputPassword());
        
        BackToMainMenu();
    }

    static void InputNewStudent(){
        Console.Clear();
        PrintHeaderStudentRegistration();

        Student student = new Student(InputSurname(), InputAge(),InputLevelOfEducation(),
         InputAllergy(), InputReligion(), InputSchool());

        BackToMainMenu();
    }

    static void InputNewTeacher(){
        Console.Clear();
        PrintHeaderTeacherRegistration();

        Teacher teacher = new Teacher(InputSurname(), InputAge(), InputPosition(),
         InputAllergy(), InputReligion(), InputCarRegistration(), InputAdmin(), InputEmail(), InputPassword());

        BackToMainMenu();
    }

    static void BackToMainMenu(){
        Console.Clear();
        PrintMenu();
        InputSelectedMenu();
    }

    static void AddAttendanceListWhenProgramIsLoad(){
        Program.attendancelist = new AttendanceList();
    }

    static void InputNamePrefix(){
        Console.Write(" Please select name prefix (1.Mr, 2.Mrs, 3.Miss): ");
        NamePrefix prefix = (NamePrefix)(int.Parse(Console.ReadLine()));

        SelectNamePrefix(prefix);
    }

    static void SelectNamePrefix(NamePrefix prefix){
        switch(prefix) {
            case NamePrefix.Mr : Console.Write("Name : Mr.");
                break;
            case NamePrefix.Mrs : Console.Write("Name : Mrs. ");
                break;
            case NamePrefix.Miss : Console.Write("Name : Miss. ");
                break;
            default :
                break; 
        }
    }


    static string InputSurname(){
        InputNamePrefix();
        InputName();
        Console.Write("Surname : ");

        return Console.ReadLine();
    }

    static string InputName(){
        return Console.ReadLine();
    }

    static string InputStudentID(){
        Console.Write("StudentID : ");

        return Console.ReadLine();
    }

    static int InputLevelOfEducation(){
        Console.Write("Level of education (4-6):");

        return int.Parse(Console.ReadLine());
    }

    static string InputAge(){
        Console.Write("Age : ");

        return Console.ReadLine();
    }

    static string InputPosition(){
        Console.Write("Position : ");

        return Console.ReadLine();
    }

    static string InputAllergy(){
        Console.Write("Are you allergic to something? (Input allergic or none): ");

        return Console.ReadLine();
    }

    static string InputReligion(){
        ChoseReligion();
        Console.Write("More details(Optional):");

        return Console.ReadLine();
    }
    static void ChoseReligion(){
        Console.Write("Please select Religion (1.Buddhism, 2.christianity, 3.islam, 4.Other) : ");
        Religion religion = (Religion)(int.Parse(Console.ReadLine()));

        SelectReligion(religion);
    }

    static void SelectReligion(Religion religion){
        switch(religion) {
            case Religion.Buddhism : Console.WriteLine("Religion : Buddhism ");
                break;
            case Religion.Christianity : Console.WriteLine("Religion : Christianity ");
                break;
            case Religion.Islam : Console.WriteLine("Religion : Islam ");
                break;
            case Religion.Other : InputReligionInfo();
                break;
            default :
                break; 
        }
    }

    static string InputReligionInfo(){
        Console.Write("Please input your religion : ");

        return Console.ReadLine();
    }

    static string InputSchool(){
        Console.Write("School :");

        return Console.ReadLine();
    }

    static string InputCarRegistration(){
        Carconfirm();

        Console.WriteLine("Car registration (If you have a car):");

        return Console.ReadLine();
    }

    static void Carconfirm(){
        Console.Write("Are you bring a car to join the camp? (1.Yes, 2.No): ");
         Car car = (Car)(int.Parse(Console.ReadLine()));

        BringCarConfirm(car);
    }

    static void BringCarConfirm(Car car){
        switch(car) {
            case Car.Yes : Console.WriteLine("Bring a car : Yes I do ");
                break;
            case Car.No : Console.WriteLine("Bring a car : No ");
                break;
            default :
                break; 
        }
    }

    static string InputAdmin(){
        AdminConfirm();
        Console.WriteLine("More details (Optional):");

        return Console.ReadLine();
    }

    static void AdminConfirm(){
        Console.Write("Are you an administrator? (1.Yes, 2.No): ");
        Admin admin = (Admin)(int.Parse(Console.ReadLine()));

        AdministratorConfirm(admin);
    }

    static void AdministratorConfirm(Admin admin){
        switch(admin) {
            case Admin.Yes : Console.WriteLine("Admin position : Yes I am ");
                break;
            case Admin.No : Console.WriteLine("Admin position : No ");
                break;
            default :
                break; 
        }
    }

    static string InputEmail(){
        Console.Write("Please input your Email (If you an administrator): ");

        return Console.ReadLine();
    }

    static string InputPassword(){
        Console.Write("Please input your password (If you an administrator): ");

        return Console.ReadLine();
    }
}