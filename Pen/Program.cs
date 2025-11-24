namespace Pen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pen myGreenPen = new Pen();
            Pen myRedPen = new Pen();

            myGreenPen.Click();
            myGreenPen.Click();

            myGreenPen.WriteLine("Hello world!");

            myRedPen.color = ConsoleColor.Red;
            myRedPen.WriteLine("Hello again!");
        }
    }
}
