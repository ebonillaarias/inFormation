using InFormation.ENT;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IInFormation.DAL
{
    public interface IMenu_DAL
    {
        Task<IEnumerable<Menu>> getMenu();
    }
}
