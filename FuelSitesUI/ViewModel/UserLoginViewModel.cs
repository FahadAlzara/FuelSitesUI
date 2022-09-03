using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FuelSitesUI.Models;
using FuelSitesUI.Services;

namespace FuelSitesUI.ViewModel
{
    public partial class UserLoginViewModel : BaseViewModel
    {
        [ObservableProperty]
        string username;

        [ObservableProperty]
        string password;

        UserLoginServices _userLoginServices;

        public UserLoginViewModel(UserLoginServices userLoginServices)
        {
            _userLoginServices = userLoginServices;
        }


        [RelayCommandAttribute]
        async Task Login()
        {
            UserLoginDTO user = new UserLoginDTO();
            user.UserName = username;
            user.Password = password;

            await _userLoginServices.Login(user);
            
        }





        //UserLoginServices userLoginServices;

        //public ICommand Login { get; private set; }

        //public bool LoginStatus { get; set; }
        //public UserLoginViewModel(UserLoginServices userLoginServices)
        //{
        //    Title = "User Login";
        //    this.userLoginServices = userLoginServices;

        //    Login = new Command(() =>
        //        LoginStatus = userLoginServices.Login(new()).Result);
        //}



        //async Task Login()
        //{
        //    if (IsBusy)
        //    {
        //        return;
        //    }

        //    var login = await userLoginServices.Login(new());
        //}
    }
}
