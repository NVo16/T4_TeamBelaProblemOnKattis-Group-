/* 
    Programmers: Alpha Team
    Project: Team Bela Problem on Kattis
    Description: This C# Console application code demonstrates the use of iterative statements 
    and Boolean expressions to solve the problem on Kattis.
*/

using System;

namespace T4_TeamBelaProblemOnKattis_Group_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Use the try-catch block to validate user input so the catch block will handle 
                the error and display the message if user enters inappropriate input
             */
            try
            {
                // Declare the array and add the values of suit to the array
                string[] suit = new string[] { "S", "H", "D", "C" };
                // Declare the array and add the values of number to the array
                string[] number = new string[] { "A", "K", "Q", "J", "T", "9", "8", "7" };
                // Declare the array and add the values of dominant suit
                int[] dominant = new int[] { 11, 4, 3, 20, 10, 14, 0 };
                // Declare the array and add the values of non-dominant suit
                int[] notDominant = new int[] { 11, 4, 3, 2, 10, 0 };
                // Declare the constant variables for the number of cards per hand, minimum and maximum number of hands
                const int CARDS_PER_HAND = 4;
                const int MIN_HAND = 1;
                const int MAX_HAND = 100;
                // Get the input of hand and suit value from the user
                Console.Write("Please Enter the the number of hands and the value of suit: ");
                // Declare the variale to get the input, which is shown in uppercase, from the user
                string input = Console.ReadLine().ToUpper();
                // Declare the variale for the space in the user input
                int spaceIndex = input.IndexOf(' ');
                // Declare the variables to get the value of hands and suit and be parsed as integer literal from the input
                int inputHand = int.Parse(input.Substring(0, spaceIndex));
                string inputSuit = input.Substring(spaceIndex + 1);
                /*
                    Use the conditional if/else statement to check the value that user enters.
                    If the value of hand that user enters is between 1 and 100, check the condition of the suit value.
                    If not, the user is asked to exit the program and try again.
                */
                if ((inputHand >= MIN_HAND) && (inputHand <= MAX_HAND))
                {
                    // Declare the variable to get the index of the entered suit from the suit array.
                    int indexSuit = Array.IndexOf(suit, inputSuit);
                    /*
                        Use the conditional if/else statement to check if the entered suit is appropriate.
                        If the value of suit is in the suit array, execute the While loop.
                        If not, the user is asked to exit the program and try again.
                    */
                    if (indexSuit != -1)
                    {
                        /*
                            Declare variable for the total number of cards and calculate it by multiplying the number of
                            cards per hand to the number of hand
                        */
                        int totalCard = CARDS_PER_HAND * inputHand;
                        // Declare variable to perform the iterative statement
                        int numberOfCard = 0;
                        // Declare variale to calculate the total points
                        int totalScore = 0;
                        /*
                            Use the While loop to calculate the total points if the entered number of cards is smaller
                            than the total number of cards.
                        */
                        while (numberOfCard < totalCard)
                        {
                            // Get the card description from user
                            // Console.Write("Please Enter the Card Description: ");
                            // Declare variable to get the card description from the user
                            string inputCard = Console.ReadLine().ToUpper();
                            /*
                                Use the conditional if/else statement to check if the user enters two-character 
                                card description. If the user enters two-charater description, check if the 
                                entered value is in the suit and number array. If not, the user is asked to exit 
                                the program and try again.
                            */
                            if (inputCard.Length == 2)
                            {
                                // Declare the variables to get the number value and suit value from the input
                                char cardNumber = inputCard[0];
                                char cardSuit = inputCard[1];
                                // Declare the variable to convert the number value and suit value to string literals
                                string numberInCard = cardNumber.ToString();
                                string suitInCard = cardSuit.ToString();
                                /*
                                    Declare the variable to get the index of the number value and suit value from the
                                    number array and suit array
                                */
                                int indexCardNumber = Array.IndexOf(number, numberInCard);
                                int indexCardSuit = Array.IndexOf(suit, suitInCard);
                                /*
                                    Use the conditional if/else statement to check if the entered number value and suit 
                                    value is in the suit and number array. If the user enters appropriate value, check 
                                    if the suit value is dominant suit. If not, the user is asked to exit the program 
                                    and try again.
                                */
                                if ((indexCardNumber != -1) && (indexCardSuit != -1))
                                {
                                    /*
                                        Use the conditional if/else statement to check if the entered suit value is 
                                        dominant suit. If the user enters dominant suit, calculate the total score
                                        with dominant array. If not, calculate with non-dominant array.
                                    */
                                    if (suitInCard == inputSuit)
                                    {
                                        /*
                                            Use the conditional if/else statement to check the entered number value. 
                                            Depending on the number value, the suitable points will be added to the
                                            total score. The total score will be added 11, 4, 3, 20, 10, 14 if it is
                                            A, K, Q, J, T, 9 and added nothing if being 8 and 7. 
                                        */
                                        if (numberInCard == number[0])
                                        {
                                            totalScore = totalScore + dominant[0];
                                            // Increase the entered number of card by 1
                                            numberOfCard++;
                                        } // End of if
                                        else if (numberInCard == number[1])
                                        {
                                            totalScore = totalScore + dominant[1];
                                            // Increase the entered number of card by 1
                                            numberOfCard++;
                                        } // End of else if
                                        else if (numberInCard == number[2])
                                        {
                                            totalScore = totalScore + dominant[2];
                                            // Increase the entered number of card by 1
                                            numberOfCard++;
                                        } // End of else if
                                        else if (numberInCard == number[3])
                                        {
                                            totalScore = totalScore + dominant[3];
                                            // Increase the entered number of card by 1
                                            numberOfCard++;
                                        } // End of else if
                                        else if (numberInCard == number[4])
                                        {
                                            totalScore = totalScore + dominant[4];
                                            // Increase the entered number of card by 1
                                            numberOfCard++;
                                        } // End of else if
                                        else if (numberInCard == number[5])
                                        {
                                            totalScore = totalScore + dominant[5];
                                            // Increase the entered number of card by 1
                                            numberOfCard++;
                                        } // End of else if
                                        else
                                        {
                                            totalScore = totalScore + dominant[6];
                                            // Increase the entered number of card by 1
                                            numberOfCard++;
                                        } // End of else
                                    } // End of if
                                    else
                                    {
                                        /*
                                            Use the conditional if/else statement to check the entered number value. 
                                            Depending on the number value, the suitable points will be added to the
                                            total score. The total score will be added 11, 4, 3, 2, 10 if it is
                                            A, K, Q, J, T and added nothing if being 9, 8 and 7. 
                                        */
                                        if (numberInCard == number[0])
                                        {
                                            totalScore = totalScore + notDominant[0];
                                            // Increase the entered number of card by 1
                                            numberOfCard++;
                                        } // End of if
                                        else if (numberInCard == number[1])
                                        {
                                            totalScore = totalScore + notDominant[1];
                                            // Increase the entered number of card by 1
                                            numberOfCard++;
                                        } // End of else if
                                        else if (numberInCard == number[2])
                                        {
                                            totalScore = totalScore + notDominant[2];
                                            // Increase the entered number of card by 1
                                            numberOfCard++;
                                        } // End of else if
                                        else if (numberInCard == number[3])
                                        {
                                            totalScore = totalScore + notDominant[3];
                                            // Increase the entered number of card by 1
                                            numberOfCard++;
                                        } // End of else if
                                        else if (numberInCard == number[4])
                                        {
                                            totalScore = totalScore + notDominant[4];
                                            // Increase the entered number of card by 1
                                            numberOfCard++;
                                        } // End of else if
                                        else
                                        {
                                            totalScore = totalScore + notDominant[5];
                                            // Increase the entered number of card by 1
                                            numberOfCard++;
                                        } // End of else
                                    } // End of else
                                } // End of if
                                else
                                {
                                    // Display the message asking for the card description to be entered appropriately
                                    Console.WriteLine("Please Enter The Appropriate Card Description");
                                    // Display the message asking to exit and try again
                                    Console.WriteLine("Please Try Running The Program Again");
                                    Console.WriteLine("Press Any Key To Exit The Program and Try Again");
                                    // Pause for user to press any key
                                    Console.ReadKey(true);
                                    // Use break statement to terminate the loop
                                    break;
                                } // End of else
                            } // End of if
                            else
                            {
                                // Display the message asking for the card description to be written as two characters
                                Console.WriteLine("Please Enter The Appropriate The Two-Character Card Description");
                                // Display the message asking to exit and try again
                                Console.WriteLine("Please Try Running The Program Again");
                                Console.WriteLine("Press Any Key To Exit The Program and Try Again");
                                // Pause for user to press any key
                                Console.ReadKey(true);
                                // Use break statement to terminate the loop
                                break;
                            } // End of else
                        }
                        Console.WriteLine(totalScore);
                    } // End of if
                    else
                    {
                        // Display the message asking for the entered value of suit to be S, H, D, or C.
                        Console.WriteLine("Please Enter The Appropriate Suit (S,H,D,C)");
                        // Display the message asking to exit and try again
                        Console.WriteLine("Please Try Running The Program Again");
                        Console.WriteLine("Press Any Key To Exit The Program and Try Again");
                        // Pause for user to press any key
                        Console.ReadKey(true);
                    } // End of else
                } // End of if
                else
                {
                    // Display the message asking for the entered value of hand to be between 1 and 100.
                    Console.WriteLine("Please Enter The Number Of Hand Between {0} And {1}.", MIN_HAND, MAX_HAND);
                    // Display the message asking to exit and try again
                    Console.WriteLine("Please Try Running The Program Again");
                    Console.WriteLine("Press Any Key To Exit The Program and Try Again");
                    // Pause for user to press any key
                    Console.ReadKey(true);
                } // End of else
            } // End of try
            catch
            {
                // Display the message asking for the appropriate input and asking the user to try again
                Console.WriteLine("Please Enter Both Integer Value For Hand And String Value for Suit.");
                Console.WriteLine("Please Try Running The Program Again.");
                Console.WriteLine("Press Any Key To Exit The Program and Try Again");
                // Pause for user to press any key
                Console.ReadKey(true);
            } // End of catch
        }
    }
}