namespace Ex04.Menus.Test
{
    using System;

    using Ex04.Menus.Interfaces;

    public class CountSpaces : IAction
    {
        public void DoAction()
        {
            int result;

            result = Actions.GetUserInput().Split(' ').Length - 1;
            Console.WriteLine("Your sentence contains {0} spaces.", result);
        }
    }
}