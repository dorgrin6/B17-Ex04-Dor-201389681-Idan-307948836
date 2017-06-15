﻿using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    
    public class TestInterface : IActionObserver
    {
        Menu m_MainMenu;


        public void Run()
        {
            buildMenu();

            m_MainMenu.Show();
        }

        private void buildMenu()
        {
            Menu subMenuActionInfo, subMenuDateTime, subActions;
            m_MainMenu = new Menu("Main Menu", Menu.eMenuType.MainMenu, 2);
            subMenuActionInfo = createSubMenu("Actions and Info", 2, m_MainMenu);
            subMenuDateTime = createSubMenu("Show Date/Time", 2, m_MainMenu);
            createAction("Display Version", subMenuActionInfo);
            subActions = createSubMenu("Actions", 2, subMenuActionInfo);
            createAction("Count Spaces", subActions);
            createAction("Chars Count", subActions);
            createAction("Show Time", subMenuDateTime);
            createAction("Show Date", subMenuDateTime);
        }

        private void createAction(string i_Title, Menu i_ParentMenu)
        {
            MenuAction action = new MenuAction(i_Title);
            i_ParentMenu.AddMenuItem(action);
            action.AttachObserver(this as IActionObserver);
        }

        private Menu createSubMenu(string i_Title, int i_SubMenusAmount, Menu i_ParentMenu)
        {
            Menu sub = new Menu(i_Title, Menu.eMenuType.SubMenu, i_SubMenusAmount);
            i_ParentMenu.AddMenuItem(sub);
            return sub;
        }

        public void ReportExecutingAction(string i_ActionTitle)
        {
            Console.Clear();

            if (i_ActionTitle == "Display Version")
            {
                Actions.DisplayVersion();
            }
            else if (i_ActionTitle == "Count Spaces")
            {
                Actions.CountSpaces();
            }
            else if (i_ActionTitle == "Chars Count")
            {
                Actions.CharsCount();
            }
            else if (i_ActionTitle == "Show Time")
            {
                Actions.ShowTime();
            }
            else if (i_ActionTitle == "Show Date")
            {
                Actions.ShowDate();
            }
        }
    }
    


}
