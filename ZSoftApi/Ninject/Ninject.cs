using DataLayer.Interfaces;
using DataLayer.Repositories;
using Ninject.Modules;

namespace ZSoftApi.Ninject
{
    public class Ninject : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IUserRepository>().To<UserRepository>();
        }
    }
}
