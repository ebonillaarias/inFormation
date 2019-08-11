using InFormation.ENT;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IInFormation.BLL
{
    public interface IMenu_BLL
    {
        Task<IEnumerable<Menu>> getMenu();
    }
}
