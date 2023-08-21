// level 13 challenge: countdown

// pick a number to count down from
CountDown(10);


// make a method enter recursion, counting down from 10 to 1
void CountDown(int number)
{
    // when the number equals 0, return and stop the function program
    if (number == 0) return; 
    // output the number at current state/iteration
    Console.WriteLine(number);
    // call itself again, but with number minus 1 in recursion
    CountDown(number - 1);
}
