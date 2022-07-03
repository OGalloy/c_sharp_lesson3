/*Задача 21
Напишите программу, 
котораѝ принимает на вход координаты двух точек 
и находит раѝѝтоѝние между ними в 3D проѝтранѝтве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

//declare two arrays,
int[] actualPoint1 = new int[3];
int[] actualPoint2 = new int[3];

Console.WriteLine("Calculation distance between two points.");

//initialize actualPoint1 
for (int i = 0; i < 3; i++){
    Console.Write("For point1: Enter coordinate {1}: ",1, Convert.ToChar(88+ i));
    actualPoint1[i] = Convert.ToInt32(Console.ReadLine());
}

//initialize actualPoint2
for (int i = 0; i < 3; i++){
    Console.Write("For point2: Enter coordinate {1}: ",1, Convert.ToChar(88+ i));
    actualPoint2[i] = Convert.ToInt32(Console.ReadLine());
}

//calculate distance between points
double actualDistance = calculateDistance(actualPoint1, actualPoint2);

//Console output
Console.WriteLine("Distance between two point equal: {0}", actualDistance);

//function for calculate distance between two points.
double calculateDistance(int[] point1, int[] point2)
{   
    double distance = Math.Sqrt(Math.Pow(point2[0] - point1[0], 2)+
                                Math.Pow(point2[1] - point1[1], 2)+
                                Math.Pow(point2[2] - point1[2], 2));
    return distance;
}
