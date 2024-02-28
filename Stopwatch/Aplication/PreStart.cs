namespace Aplication
{
    internal class PreStart
    {
        public void Execute(int time)
        {
            Start start = new Start();  
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);

            Console.WriteLine("Set...");
            Thread.Sleep(1000);

            Console.WriteLine("Go!!");
            Thread.Sleep(1000);

            start.Execute(time);
        }
    }
}
