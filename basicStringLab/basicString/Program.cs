




bool userAnswer = false;


do
{
	Console.Write("Please enter a sentence: ");
	string userSentence = Console.ReadLine();
	string[] words = userSentence.Split(' ');

	for (int i = 0; i < words.Length; i++)
	{
		Console.WriteLine(words[i]);
	}
	


    Console.WriteLine("Would you like to continue enter \"Yes\" to try again or type any other key to exit ");
	string userInput = Console.ReadLine();
	string userInput2 = userInput.ToLower();
	if (userInput2 == "yes")
	{
		userAnswer = false;
	}
	else
	{
		Console.WriteLine("Goodbye");
		userAnswer = true;
	}

} while (userAnswer == false);

/*
 * 
 * 
 * 
 */

bool answer = false;


List<string> userSentence2 = new List<string>();

do
{
    
    Console.Write("Please enter some text: ");

	string userWord = Console.ReadLine();

	userSentence2.Add(userWord);

	Console.Write("You have entered: ");

	foreach (string  Words in userSentence2)
	{
		Console.Write($" {Words} " );
	}




    Console.WriteLine("\n Would you like to continue enter \"Yes\" to try again or type any other key to exit:");
    string userInput = Console.ReadLine();
    string userInput2 = userInput.ToLower();
    if (userInput2 == "yes")
    {
        answer = false;
    }
    else
    {
        Console.WriteLine("Goodbye");
        answer = true;
    }



} while (answer == false);
