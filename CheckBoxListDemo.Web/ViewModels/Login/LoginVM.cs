using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CheckBoxListDemo.Web.ViewModels.Login
{
    public class LoginVM
    {
        [DisplayName("Username:")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("Password:")]
        public string Password { get; set; }
    }
}
