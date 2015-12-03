using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProctorUAPI.BL
{
    public class Settings
    {
        private string _method_name = String.Empty;

        public string MethodName
        {
            get 
            {
                return _method_name;
            }
            set
            {
                 _method_name = value;
            }
        }

        public string ApiRootUrl { get; set; }

        public string ApiMethodUrl 
        {
            get
            {
                return Path.Combine(ApiRootUrl, MethodName);
            }
        }

        public string AuthorizationToken { get; set; }
    }
}
