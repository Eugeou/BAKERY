using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class AccountLogin
    {
        public string Name { get; set; }
        public string Id { get; set; }    
        public AccountLogin()
        {

        }
        public AccountLogin(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
