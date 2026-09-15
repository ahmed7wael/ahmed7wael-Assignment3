using System.Reflection.Metadata.Ecma335;

namespace CSharpBasicsAssignment;

struct Point
{
    public int x;
    public int y;
}
internal class Program
{
    private static string name = "wael";

    static void Main(string[] args)
    {
        #region Part A — Project & Structure
        //Part A — Project & Structure
        //================================
        //role of files in a C# project
        // 1. .csproj:
        // 1. بيعرفنا نوع البروجيكت اللي شغالين عليه والاعدادات بتاعته 
        // 2. بيعرفنا اصدار ال .NET اللي شغالين عليه 
        // 3. وايه ال packages اللي محتاجينها

        // 2. program.cs:
        //The entery point of the application , where code ececution starts from the Main method

        //3. bin/:(Build Output) 
        //لما بنعمل كومبيل للكود الناتج بيتحط في الملف ده
        //holding Final Output of the project after compilation and build process

        //4. obj/:(Intermediate Output)
        //holding temporary files generated during the build process


        /*  csproj file
         *   <PropertyGroup>
            <OutputType>Exe</OutputType>
            <TargetFramework>net10.0</TargetFramework>
            <ImplicitUsings>enable</ImplicitUsings>
            <Nullable>enable</Nullable>
          </PropertyGroup>
         */

        // File-Scoped Namespace:
        // Using file-scoped namespace reduces unnecessary indentation across the entire file.
        // why? عشان ; معناها ان ملف ال namespce بيمتد علي الملف كله


        // Solution Format:
        // My project uses the classic .sln format. 
        // .slnx: cleaner, using XML-based structure which makes Git merges easier.

        // ========== part A Completed ==========
        #endregion

        #region PART B — Variables, Types & Casting
        //// PART B — Variables, Types & Casting
        //RunTypesDemo();

        //static void RunTypesDemo()
        //{
        //    //1 Declare variables
        //    int myInt = 42;
        //    long myLong = 10000000000;
        //    double myDouble = 3.14159;
        //    decimal myDecimal = 99.99m;
        //    bool myBool = true;
        //    char myChar = 'A';
        //    string myString = "Hello C#";
        //    var myVar = "Var Type";

        //    Console.WriteLine($"int: {myInt} - Type: {myInt.GetType()}");
        //    Console.WriteLine($"long: {myLong} - Type: {myLong.GetType()}");
        //    Console.WriteLine($"double: {myDouble} - Type: {myDouble.GetType()}");
        //    Console.WriteLine($"decimal: {myDecimal} - Type: {myDecimal.GetType()}");
        //    Console.WriteLine($"bool: {myBool} - Type: {myBool.GetType()}");
        //    Console.WriteLine($"char: {myChar} - Type: {myChar.GetType()}");
        //    Console.WriteLine($"string: {myString} - Type: {myString.GetType()}");
        //    Console.WriteLine($"var: {myVar} - Type: {myVar.GetType()}\n");



        //    //2 implict casting
        //    int val = 10;
        //    long intToLong = val; //int to long
        //    Console.WriteLine($"implicit Casting : Long = {intToLong}");
        //    //long > int that's why we use implicit casting

        //    char charVal = 'A';
        //    int charToInt = charVal; //char to int
        //    Console.WriteLine($"implicit Casting : Int = {charToInt}\n");
        //    //int > char that's why we use implicit casting (pring uniCode) "



        //    //3 explicit casting
        //    double doubleVal = 3.8;
        //    int doubleToInt = (int)doubleVal; //explicit casting: double to int
        //    Console.WriteLine($"explicit Casting : Int = {doubleToInt}");
        //    //int < double that's why we use explicit casting and cuts the decimal part

        //    int convertToInt = Convert.ToInt32(doubleToInt);
        //    Console.WriteLine($"explicit Casting : Int = {convertToInt}\n");



        //    //4 Integer Devision
        //    int intRes = 5 / 2;
        //    double doubleRes = 5.0 / 2;

        //    Console.WriteLine($"Integer Division: 5 / 2 = {intRes}");
        //    Console.WriteLine($"Double Division: 5.0 / 2 = {doubleRes}\n");
        //    //int cuts the the decimal part and Double keeps the decimal part



        //    //5 Boxing and Unboxing
        //    int number = 10;
        //    object boxed = number; // Boxing convert Value type to reference type
        //    int unboxed = (int)boxed; // Unboxing convert Reference type to value type

        //    Console.WriteLine($"Boxing: {number} -> {boxed}");
        //    Console.WriteLine($"Unboxing: {boxed} -> {unboxed}\n");



        //    //6 parse and TryParse
        //    string value = "42";
        //    int parseInt = int.Parse(value);
        //    Console.WriteLine($"Result : {parseInt.GetType()} : {parseInt}"); //Parse

        //    string value2 = "abc";
        //    bool isSuccessed = int.TryParse(value2, out int res);
        //    if (isSuccessed)
        //        Console.WriteLine($"TryParse is Successed -> {res}\n");
        //    else
        //        Console.WriteLine("TryParse is Faild\n");


        //    //7 float and deciaml 
        //    float floatValue = 5.58f;

        //    decimal decimalValue = (decimal)floatValue;
        //    Console.WriteLine($"casting Float to Deciaml : {decimalValue}\n");
        //    //implicit here is wrong(error) because float uses binary system and decimal uses decimal system. 

        //}


        #endregion

        #region Part C — Value vs. Reference Types
        ////Experiment 1 — struct copy semantics

        //RunValueVsReferenceDemo();

        //static void RunValueVsReferenceDemo()
        //{
        //    Point p1 = new Point { x = 1, y = 2 };
        //    Point p2 = p1;
        //    p2.x = 99;

        //    Console.WriteLine($"p1.x: {p1.x} Do not change ");
        //    Console.WriteLine($"p2.x: {p2.x} (Copied)\n");

        //}

        ////Experiment 2 — class reference semantics (Order class)
        //Order o1 = new Order
        //{
        //    OrderId = 10,
        //    CustomerName = "Wael",
        //    Quantity = 2,
        //    UnitPrice = 50.0m,
        //    IsPaid = false,
        //    DiscountPercent = 10.0,
        //    ShippingCity = "Cairo",
        //    Priority = 'M',
        //    ItemCode = 9876543210L
        //};
        //o1.CalculateTotal();

        //Order o2 = o1;
        //o2.IsPaid = true;

        //Console.WriteLine($"o1.IsPaid: {o1.IsPaid}");
        //Console.WriteLine($"o2.IsPaid: {o2.IsPaid}");
        ////change in o1 and o2 , ليه بقي عشان الاتنين بقي شايلين نفس المكان محنا ساويناهم ببعض فا بقوا شايلين نفس العنوان 

        //object boxed = o1; //no Boxing - object is Parent of everyThing and reference type
        //Order o3 = (Order)boxed;  //the same 

        //o2.PrintSummary();
        //o1.PrintSummary(); //the same 

        ////value type : is store in Stack (Struct and Enum) int , double , decimal , long 
        //// is value type because build above struct.
        ////reference type : is sore in heap but the address in stack (Class and Interface)
        ////assigning one reference variable to another does not create a new object; both variables point to the same object.
        #endregion

        #region Part D — Scope & Operators
        ////D1 — Scope
        //MethodSpcoe();
        //test();
        //static void MethodSpcoe()
        //{
        //    Console.WriteLine($"Field Scope : {name}");

        //    int myAge = 22;
        //    Console.WriteLine(myAge);
        //    for (int i = 0; i < 2; i++)
        //    {
        //        string job = "Backend";
        //        Console.WriteLine(job);
        //    }
        //}
        //static void test()
        //{
        //    Console.WriteLine($"Field Scope : {name}\n");
        //    // Console.WriteLine(myAge); wrong x
        //    // Console.WriteLine(job); wrong x
        //}

        ////D2 — Composite (compound assignment) operators
        //int total = 10;
        //Console.WriteLine($"The original Total is : {total}");
        //total += 10; //total = total + 10 
        //Console.WriteLine($"Total is : {total}"); //20
        //total -= 10; //total = total - 10 
        //Console.WriteLine($"Total is : {total}"); //10
        //total *= 10; //total = total * 10 
        //Console.WriteLine($"Total is : {total}"); //100
        //total /= 10; //total = total / 10 
        //Console.WriteLine($"Total is : {total}"); //10
        //total %= 2; //total = total % 2
        //Console.WriteLine($"Total is : {total}"); //0
        //Console.WriteLine();

        ////D3 — Bitwise operators (not logical operators)
        //int a = 12, b = 10;
        //// a = 1100      b = 1010 
        //int andRes = a & b; // Decimal 8
        //Console.WriteLine($"a & b = {andRes}");

        //int orRes = a | b; // Decimal 14
        //Console.WriteLine($"a | b = {orRes}");

        //int xorRes = a ^ b; // Decimal 6
        //Console.WriteLine($"a ^ b = {xorRes}");

        ////Logical operators (&&, || , !) -> works on Conditions and Boolean
        ////Bitwise operators (&, |, ^) -> works on bits and integers
        #endregion

        #region Part F — LeetCode Problem
        //int[] test1 = { 4, 1, 2, 1, 2 }; //4 
        //int[] test2 = { 4, 5, 6, 5, 4 }; //3
        //FindSingleNumber(test1);
        //FindSingleNumber(test2);

        //static void FindSingleNumber(int[] nums)
        //{
        //    int result = 0;
        //    foreach (int num in nums)
        //    {
        //        result ^= num;
        //    }
        //    Console.WriteLine($"The single number is: {result}");
        //}
        // why Xor ? بص هي بتمشي حرفيا علي ال  bits متفين ب 0 مختلفين ب 1 
        //فا بنمشي بقي علي كل رقم ونقارنه ولو الرقم اتكرر مرتين بيحذف نفسه عشان بيبقي في اختلاف فا كانه مجاش اصلا لكن مرة واحدة هيفضل موجود
        #endregion
    }

}


