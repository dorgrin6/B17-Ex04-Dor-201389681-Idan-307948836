/* Interfaces and Delegates
 * 
 * 
 * First Student Details.: 201389681- Dor Grinshpan
 * Second Student Details: 307948836- Idan Goor
 * Delivery Date.........: 17 - June - 2017
 * */

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            TestInterface mainMenuInterface = new TestInterface();
            mainMenuInterface.Run();

            TestDelegates mainMenuDelegates = new TestDelegates();
            mainMenuDelegates.Run();
        }
    }
}