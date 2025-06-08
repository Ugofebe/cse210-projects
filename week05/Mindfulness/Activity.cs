using System;
// using System.Threading;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void Run()
    {
        DisplayStartingMessage();
        PrepareToBegin();
        ExecuteActivity();
        DisplayEndingMessage();
    }

    protected virtual void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name}");
        Console.WriteLine(_description);
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }

    protected virtual void PrepareToBegin()
    {
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    protected abstract void ExecuteActivity();

    protected virtual void DisplayEndingMessage()
    {
        Console.WriteLine("Good job!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    public static void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds * 2; i++)
        {
            Console.Write("/"); Thread.Sleep(250);
            Console.Write("\b \b"); Console.Write("-"); Thread.Sleep(250);
            Console.Write("\b \b"); Console.Write("\\"); Thread.Sleep(250);
            Console.Write("\b \b"); Console.Write("|"); Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public static void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b\b \b");
        }
        Console.WriteLine();
    }
}