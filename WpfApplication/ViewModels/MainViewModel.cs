namespace WpfApplication.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WpfApplication.Models;

    public class MainViewModel
    {
        public List<User> UserList { get; set; }

        public MainViewModel()
        {
            this.UserList = new List<User>()
            {
                new User(){Id = 1, DisplayName = "Tsuyoshi Tanaka", Age = 28},
                new User(){Id = 2, DisplayName = "Onishi Kenji", Age = 24},
                new User(){Id = 3, DisplayName = "Suzuki Shyun", Age = 25}
            };
        }
    
    }
}
