using IInFormation.BLL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InFormation.BLL
{
    public class Menu_BLL: IMenu_BLL
    {
        private IInFormation.DAL.IMenu_DAL _dal;

        public Menu_BLL(IInFormation.DAL.IMenu_DAL dal)
        {
            this._dal = dal;
        }

        async Task<IEnumerable<ENT.Menu>> IMenu_BLL.getMenu()
        {
            return await _dal.getMenu();
        }
    }
}
