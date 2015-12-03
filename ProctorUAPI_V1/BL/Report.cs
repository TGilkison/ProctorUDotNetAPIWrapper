using ProctorUAPI.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ProctorUAPI.BL
{
    public class Report : BaseBL
    {
        public ClientActivityReportResponseDO getClientActivityReport(Settings settings, ClientActivityReportDO clientActivityReportDO)
        {
            settings.MethodName = "clientActivityReport";

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string jsonContent = Util.JsonSerializer<ClientActivityReportDO>(clientActivityReportDO);

            string output = CallApi(settings, jsonContent);

            ClientActivityReportResponseDO response = (ClientActivityReportResponseDO)jss.Deserialize(output, typeof(ClientActivityReportResponseDO));
            return response;
        }
    }
}
