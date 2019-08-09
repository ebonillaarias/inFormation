using IInFormation.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using IInFormation.DAL;

namespace InFormation.BLL
{
    public class Menu : IInFormation.BLL.IMenu
    {
        private IInFormation.DAL.IMenu _dal;

        public Menu(IInFormation.DAL.IMenu dal)
        {
            this._dal = dal;
        }

        public string getMenu()
        {
            return _dal.getMenu();
        }
    }
}
