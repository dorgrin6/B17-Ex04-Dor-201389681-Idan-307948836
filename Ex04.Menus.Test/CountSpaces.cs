using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountSpaces : IAction
    {
        public void DoAction()
        {
            int result;

            result = Actions.GetUserInput().Split(' ').Length - 1;
            Console.WriteLine("Your sentence contains {0} spaces", result);
        }
    }
}