namespace Ex04.Menus.Interfaces
{
    public abstract class Action :  MenuItem, IAction
    {
        public abstract void DoAction();
    }
}
