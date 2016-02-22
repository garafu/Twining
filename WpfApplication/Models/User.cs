namespace WpfApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class User
    {
        public bool IsSelected { get; set; }

        public int Id { get; set; }

        public string DisplayName { get; set; }

        public int Age { get; set; }
    }
}
