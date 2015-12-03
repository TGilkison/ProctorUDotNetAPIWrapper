using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using ProctorUAPI.DO;

namespace ProctorUAPI.BL
{
    public class Authentication : BaseBL
    {
        public LoginResponseDO Login(Settings settings, LoginDO login)
        {
            settings.MethodName = "autoLogin";

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string jsonContent = Util.JsonSerializer<LoginDO>(login);

            string output = CallApi(settings, jsonContent);

            object response = jss.Deserialize(output, typeof(LoginResponseDO));
            return (LoginResponseDO)response;
        }
    }
}
