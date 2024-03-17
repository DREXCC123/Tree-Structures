using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";
        bool exit = false;

    Home:
        if (!exit)
        {
            Console.WriteLine("Home");
            Console.WriteLine("a. Machine Learning Algorithms");
            Console.WriteLine("b. Software Testing Methods");
            Console.WriteLine("c. Close");
            Console.Write("Enter your choice (a/b/c): ");
            userChoice = Console.ReadLine().ToLower();

            if (userChoice == "a")
            {
                goto MachineLearningAlgorithms;
            }
            else if (userChoice == "b")
            {
                goto SoftwareTestingMethods;
            }
            else if (userChoice == "c")
            {
                exit = true;
                goto End;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                goto Home;
            }

            Console.WriteLine();
        }

    MachineLearningAlgorithms:
        Console.WriteLine("Machine Learning Algorithms");
        Console.WriteLine("a. Supervised Learning");
        Console.WriteLine("b. Unsupervised Learning");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            goto SupervisedLearning;
        }
        else if (userChoice == "b")
        {
            goto UnsupervisedLearning;
        }
        else if (userChoice == "c")
        {
            goto Home;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto MachineLearningAlgorithms;
        }

    SupervisedLearning:
        Console.WriteLine("Supervised Learning");
        Console.WriteLine("a. Regression");
        Console.WriteLine("b. Classification");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            Console.WriteLine("Regression");
        }
        else if (userChoice == "b")
        {
            Console.WriteLine("Classification");
        }
        else if (userChoice == "c")
        {
            goto MachineLearningAlgorithms;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto SupervisedLearning;
        }
        Console.WriteLine();
        goto SupervisedLearning;

    UnsupervisedLearning:
        Console.WriteLine("Unsupervised Learning");
        Console.WriteLine("a. Clustering");
        Console.WriteLine("b. Dimensionality Reduction");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            Console.WriteLine("Clustering");
        }
        else if (userChoice == "b")
        {
            Console.WriteLine("Dimensionality Reduction");
        }
        else if (userChoice == "c")
        {
            goto MachineLearningAlgorithms;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto UnsupervisedLearning;
        }
        Console.WriteLine();
        goto UnsupervisedLearning;

    SoftwareTestingMethods:
        Console.WriteLine("Software Testing Methods");
        Console.WriteLine("a. Manual");
        Console.WriteLine("b. Automated");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            goto ManualTesting;
        }
        else if (userChoice == "b")
        {
            goto AutomatedTesting;
        }
        else if (userChoice == "c")
        {
            goto Home;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto SoftwareTestingMethods;
        }

    ManualTesting:
        Console.WriteLine("Manual");
        Console.WriteLine("a. Exploratory Testing");
        Console.WriteLine("b. Ad-hoc Testing");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            Console.WriteLine("Exploratory Testing");
        }
        else if (userChoice == "b")
        {
            Console.WriteLine("Ad-hoc Testing");
        }
        else if (userChoice == "c")
        {
            goto SoftwareTestingMethods;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto ManualTesting;
        }
        Console.WriteLine();
        goto ManualTesting;

    AutomatedTesting:
        Console.WriteLine("Automated");
        Console.WriteLine("a. Unit Testing");
        Console.WriteLine("b. Integration Testing");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            Console.WriteLine("Unit Testing");
        }
        else if (userChoice == "b")
        {
            Console.WriteLine("Integration Testing");
        }
        else if (userChoice == "c")
        {
            goto SoftwareTestingMethods;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto AutomatedTesting;
        }
        Console.WriteLine();
        goto AutomatedTesting;

    End:
        Console.WriteLine("Closing the program...");
    }
}