Console.WriteLine("How many fibonacchi numbers do you want to calculate?");
int loops = int.Parse(Console.ReadLine());

//1 = first number, 1 = second, count = calculates next number x amount of times, but every loop decreases by one until 0
int RecursiveFibonacci(int first, int second, int count)
{
//Subtract 1 from count every loop until 0
    count--;
    
//Create "next" to find next number in calculation (first + second)
//"first" turns into second to reach next number for next loop
//"second" obtains value of "next". Upcoming loop has greater values to create next sequence number
    int next = first + second; 
        first = second;
        second = next;
    
//If count hits 0, output "next", which will be the last calculated number. 
    if(count == 0) {
        return next;
    }

//If count isn't 0, loop
    else {
        return RecursiveFibonacci(first, second, count);
    }
}

//Integer to output last requested sequence number in the equation
//1 = first number, 1 = second, loops = How many numbers it's supposed to calculate
int lastFibo = RecursiveFibonacci(1, 1, loops);
Console.WriteLine("Last fibo number was " + lastFibo);
Console.ReadLine(); 