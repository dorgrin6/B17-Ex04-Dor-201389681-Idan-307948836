namespace Ex04.Menus.Test
{
    using System;

    using Ex04.Menus.Interfaces;

    public class CharsCount : IAction
    {
        public void DoAction()
        {
            int result;

            result = Actions.GetUserInput().Length;
            Console.WriteLine("Your sentence have {0} chars.", result);
        }
    }
}