
//using NullablePractice;
//#region Nullable


//string name = null;
//int? num = null;

//if (name == null)
//{
//    Console.WriteLine("dsdsd");
//}

//int? m = 5;

//GetPersonById(m);

//static void GetPersonById(string id)
//{
//    if (id == null)
//    {
//        Console.WriteLine("Notfound");
//    }
//}
//#endregion





//PracticeDelegate calculate = new PracticeDelegate();
//calculate.CheckDelegate();
//calculate.CheckWord();
//calculate.ShowString();






//int m = 5;
//int n = 0;

//var res = m / n;






//Divide(5, 1);

//static void Divide(int n, int m)
//{
//    bool isSuccess = false;
//    try
//    {
//        int[] arr = { 1, 2, 3 };
//        arr[5] = 100;
//        var result = n / m;
//        Console.WriteLine(result);
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//        isSuccess = false;

//    }
//    finally
//    {
//        string message = string.Empty;
//        if (isSuccess)
//        {
//            message = "Register is ok";
//        }
//        else
//        {
//            message = "Something is wrong";
//        }
//        SendEmail(message);
//    }
//}

//static void SendEmail(string message)
//{
//    Console.WriteLine(message);
//}

//Login("pervin123", "pervin12345");

//static void Login(string username, string password)
//{
//    try
//    {
//        if (username == "pervin123" && password == "pervin12345")
//        {
//            Console.WriteLine("Login is success");
//        }
//        else
//        {
//            throw new InvalidCastException(ExceptionsMessages.InvalidLogin);
//        }

//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);

//    }


//    IEmployeeService service = new EmployeeService();
//    Console.WriteLine(service.GetCountByAge(26));