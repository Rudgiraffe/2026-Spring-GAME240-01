// sorry this is technically two hours late. I was writing a scipt for a screen writing class and only just got to this at 2am.
// I figured you probably weren't going to mark this between 12am and 2am, but if I was wrong I do apologise.
// also, I did get help from a friend with this, I was a little confused, especially on the extra credit bits, but I think I get it now.
// I also hope this was ok.
double lastAnswer = 0;
        bool hasAnswer = false;

        while (true)
        {
            Console.WriteLine("\nThis calculator can perform 5 operations: addition (+), subtraction (-), multiplication (*), division (/), and modulus (%).");
            Console.WriteLine("Please type a mathematical expression, or type \"quit\" to shut down the calculator.");

            string input = Console.ReadLine();

            // Quit
            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Goodbye.");
                break;
            }

            // Number stuff
            string[] parts = input.Split(' ');

            if (parts.Length != 3)
            {
                Console.WriteLine("I do not know how to do that.");
                continue;
            }

            string leftPart = parts[0];
            string op = parts[1];
            string rightPart = parts[2];

            double num1, num2;
            
            if (leftPart.ToLower() == "answer")
            {
                if (!hasAnswer)
                {
                    Console.WriteLine("No previous answer exists.");
                    continue;
                }
                num1 = lastAnswer;
            }
            else if (!double.TryParse(leftPart, out num1))
            {
                Console.WriteLine("I do not know how to do that.");
                continue;
            }
            
            if (rightPart.ToLower() == "answer")
            {
                if (!hasAnswer)
                {
                    Console.WriteLine("No previous answer exists.");
                    continue;
                }
                num2 = lastAnswer;
            }
            else if (!double.TryParse(rightPart, out num2))
            {
                Console.WriteLine("I do not know how to do that.");
                continue;
            }

            double result;

            // actually calculating
            if (op == "+")
            {
                result = num1 + num2;
            }
            else if (op == "-")
            {
                result = num1 - num2;
            }
            else if (op == "*")
            {
                result = num1 * num2;
            }
            else if (op == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Division by 0 is not allowed.");
                    continue;
                }
                result = num1 / num2;
            }
            else if (op == "%")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Modulus by 0 is not allowed.");
                    continue;
                }
                result = num1 % num2;
            }
            else
            {
                Console.WriteLine("I do not know how to do that.");
                continue;
            }

            // Save answer
            lastAnswer = result;
            hasAnswer = true;

            // Output 
            Console.WriteLine(num1 + " " + op + " " + num2 + " is " + result + ".");
        }