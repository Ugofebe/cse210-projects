public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    // This method enables us overide the already existing method in the base(Activity)
    // The protected helps create access between base and derived classes as seen in other derived(child) cclasses in this program
    // void simply means it makes certain changes but does not return nothing and does not have parameters jusst performs action
    // Note abstract means you cannot instantiate and It establishes a contract that all activities must follow.
    protected override void ExecuteActivity()
    {
        int cycles = _duration / 6; // Each breath in/out cycle is 6 seconds
        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
        }
    }
}
// Note: this is a child class and it is derived from the base Activity. It is built in a way that all the values here can work hand in hand with the base