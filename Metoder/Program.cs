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

int GetNumberInput()
{
    string input = Console.ReadLine();
    int number;
    while (!int.TryParse(input, out number))
    {
        System.Console.WriteLine("Skriv ett tal!!!!!");
        input = Console.ReadLine();
    }
    return number;
}
GetNumberInput();
