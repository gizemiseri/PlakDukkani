using PlakDukkani.BLL.Concrete.ResultServiceBLL;
using PlakDukkani.Model.Entities;
using PlakDukkani.ViewModel.UserViewModels;

namespace PlakDukkani.BLL.Abstract
{
    public interface IUserBLL : IBaseBLL<User>
    {
        ResultService<UserCreateVM> Insert(UserCreateVM user);
    }
}
