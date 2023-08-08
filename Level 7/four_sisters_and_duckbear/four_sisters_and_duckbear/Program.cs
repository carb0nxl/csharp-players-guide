// Level 7: The four sisters and the duckbear

/*
 * Four (4) sisters have a chocolate farm with chocolate eggs laid by chocolate chickens daily.
 * Each sister get an equal amount and the remainder is given to their pet duckbear.
 * 
 * Create a program that lets the user enter the number of chocolate eggs gathered that day.
 * Using / and %, computer how many eggs each sister should get and how many are
 * left over for the duckbear.
 *
 * Answer this question: What are three total egg counts where the duckbear gets more than
 * each sister does?
*/

Console.WriteLine("How many eggs were gathered today?");
var totalEggsGathered = int.Parse(Console.ReadLine());

// The amount of eggs each sister should receive:
int numberEggsEach = totalEggsGathered / 4;

// The remainder that goes to the duckbear:
int remainderEggs = totalEggsGathered % 4;

Console.WriteLine("Each sister will receive " + numberEggsEach + 
                  " and the duckbear will receive " + remainderEggs);



// If there is less than four eggs, the sisters will get 0.
// So a total count of 1, 2, or 3 would each give the duckbear more than the sisters.
// But 6 will give each sister 1 and the duckbear 2, 7 gives each
// sister 1 and the duckbear 3, and 11 gives each sister 2 and the duckbear 3.
