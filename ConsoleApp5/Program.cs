namespace D_OOP
{
    class Programm
    {
        static void Main(string[] arg)
        {
            Character d = new Character();
            d.Hit(56);
            Console.WriteLine("здоровье " + d.Health );
        }
    }
}
