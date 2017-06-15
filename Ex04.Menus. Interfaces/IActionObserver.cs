namespace Ex04.Menus.Interfaces
{
    public interface IActionObserver
    {
        //void ReportExecutingAction(string i_ActionTitle);

        void ReportExecutingAction(IAction i_Action);
    }
}