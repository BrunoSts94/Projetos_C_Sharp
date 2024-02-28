namespace Aplication
{
    public class Start
    {
        public void Execute(int time)
        {

            int currentTime = 0;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Cronometro finalizado!");
            Thread.Sleep(2500);
        }
    }
}
