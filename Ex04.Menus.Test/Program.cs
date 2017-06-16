namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            TestInterface MainMenuInterface = new TestInterface();
            MainMenuInterface.Run();

            TestDelegates mainMenuDelegates = new TestDelegates();
            mainMenuDelegates.Run();
        }
    }
}