enum Menu {
    RegistrationToCamp = 1, ShowAttendanceStatistics = 2, Login = 3
}

enum RegistrationType{
    CurrentStudent = 1, Student = 2, Teacher = 3
}

class Program {

    static void Main(string[] args) {

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

    static void ShowAttendanceScreen(){}

    static void ShowLoginScreen(){}

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
    }

    static void ShowRegistrationTeacherScreen(){
        Console.Clear();
    }

    static void PrintHeaderCurrentStudentRegistration(){
        Console.WriteLine(" Register new CurrentStudent ");
        Console.WriteLine("---------------------------------------------------");
    }

    static void InputNewCurrentStudent(){
        Console.Clear();
        PrintHeaderCurrentStudentRegistration();

        
    }
}



