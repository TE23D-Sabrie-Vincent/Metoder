// static void hello(){
//     for (int i = 0; i < 32; i++){
//     System.Console.WriteLine("Hello world");
//     }
//     Console.ReadLine();
// }

// hello();

// void kvadrat(int num){
// num = num*num;
//  System.Console.WriteLine(num); 
//  Console.ReadLine();
// } 
// kvadrat(2);

// void multi(float num1,float num2){
// System.Console.WriteLine(num1*num2);
// }
// multi(9,2);
// Console.ReadLine();

// float RightTriangleArea(float num1, float num2){
//     return num1 *num2 / 2;
// }

// float area = RightTriangleArea(2,5);
// System.Console.WriteLine(area);
// Console.ReadLine();


// float CircleArea(float radius){
//     return radius * radius * MathF.PI;
// }
// // Detta ovanför är för övning 5

// // float area = CircleArea(5);
// // System.Console.WriteLine(area);
// // Console.ReadLine();
// // Detta kan du ignorera

// int GetNumberInput()
// {
//     string input = Console.ReadLine();
//     int number;
//     while (!int.TryParse(input, out number))
//     {
//         System.Console.WriteLine("Skriv ett tal!!!!!");
//         input = Console.ReadLine();
//     }
//     return number;
// }
// GetNumberInput();

string GetChoice(string val1, string val2, string val3)
{
    System.Console.WriteLine("DU har 3 val, snygging (med rizz :D)");
    System.Console.WriteLine(val1);
    System.Console.WriteLine(val2);
    System.Console.WriteLine(val3);
    string choice = Console.ReadLine();
    int number;
    while (true)
    {


        while (!int.TryParse(choice, out number))
        {
            System.Console.WriteLine("Skriv ett nummer!");
            choice = Console.ReadLine();
        }
        if (number < 1)
        {
            System.Console.WriteLine("Det finns ingen fråga under 1");
        }
        else if (number > 3)
        {
            System.Console.WriteLine("Det finns ingen fråga över 3");
        }
        else
        {
            return choice;
        }
    }

}

GetChoice("Bli freaky med Simon", "Städa Simons toalett efter ha haft taco tallrik", "Bli en tomte");