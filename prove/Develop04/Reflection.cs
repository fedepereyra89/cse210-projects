using System;

public class Reflection : Activity
{
    public Reflection(string name, string description) : base(name, description)
    {
        name = "";
        description = "";
    }

    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "What's a goal you want to accomplish and why?",
        "How do you put yourself first without feeling guilty?",
        "How do you stay focused and steer clear of distractions?",
        "How do you set boundaries and avoid absorbing someone else's emotions and stress?",
        "What made this time different than other times when you were not as successful?",
        "What can you do today that you didn’t think you could do a year ago?",
        "What could you learn from this experience that applies to other situations?",
        "What's a choice you can make this week based on your needs?",
        "What makes you feel powerful?",
        " What makes you feel calm?"
    };

    private List<int> _availableIndexPrompts = new List<int>();

    private List<int> _availableIndexQuestions = new List<int>();

    public List<int> PopulateIndexesPrompts()
    {
        for (int i = 0; i < _prompts.Count; i++)
        {
            _availableIndexPrompts.Add(i);
        }
        return _availableIndexPrompts;
    }

    public List<int> PopulateIndexesQuestions()
    {
        for (int i = 0; i < _questions.Count; i++)
        {
            _availableIndexQuestions.Add(i);
        }
        return _availableIndexQuestions;
    }

    public void DisplayPrompt()
    {
        if (_availableIndexPrompts.Count != 0)
        {
            Console.WriteLine("Consider the following prompt: \n");

            Random rnd = new Random();
            int rndindex = rnd.Next(_availableIndexPrompts.Count);
            int index = _availableIndexPrompts[rndindex];

            Console.WriteLine($"--- {_prompts[index]} ---\n");
            _availableIndexPrompts.RemoveAt(rndindex);
        }
        else
        {
            Console.WriteLine("There are not more prompts!");
            Environment.Exit(1);
        }
    }

    public void Instructions()
    {
        Console.Write("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Now ponder on each of the following questions as they related this experience.");
    }

    public void DisplayQuestions()
    {
        Random rnd = new Random();
        int rndindex = rnd.Next(_availableIndexQuestions.Count);
        int index = _availableIndexQuestions[rndindex];

        Console.Write($"> {_questions[index]} ");
        _availableIndexQuestions.RemoveAt(rndindex);
    }
}