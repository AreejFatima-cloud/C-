int firstValue = 500;
int secondValue = 600;
int largerValue;
// if(firstValue>secondValue){
//     largerValue = firstValue;
//     Console.WriteLine("The larger value is: " + largerValue);
// }
// else{
//     largerValue = secondValue;
//     Console.WriteLine("The larger value is: " + largerValue);
// }
// Use Math.Max() to find the larger of the two values
largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine("The larger value is: " + largerValue);
