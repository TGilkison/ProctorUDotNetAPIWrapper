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
    public class Data : BaseBL
    {
        public TimeZoneResponseDO GetTimeZoneList(Settings settings)
        {
            List<string> timeZoneList = new List<string>();
            TimeZoneDO timeZoneDO = new TimeZoneDO();

            settings.MethodName = "getTimeZoneList";

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string jsonContent = Util.JsonSerializer<TimeZoneDO>(timeZoneDO);

            string output = CallApi(settings, jsonContent);

            object response = jss.Deserialize(output, typeof(TimeZoneResponseDO));
            TimeZoneResponseDO timeZoneResponse = (TimeZoneResponseDO)response;

            // *** TODO: Convert Message to List

            return timeZoneResponse;
        }
    }
}
