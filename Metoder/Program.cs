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

float RightTriangleArea(float num1, float num2){
    return num1 *num2 / 2;
}

float area = RightTriangleArea(2,5);
System.Console.WriteLine(area);
Console.ReadLine();