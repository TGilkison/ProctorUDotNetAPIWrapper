using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using ProctorUAPI.DO;

namespace ProctorUAPI.BL
{
    public class TermsOfService : BaseBL
    {
        public TermsOfServiceResponseDO GetTermsOfService(Settings settings, TermsOfServiceDO getTermsOfServiceDO)
        {
            settings.MethodName = "getTOS";

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string jsonContent = Util.JsonSerializer<TermsOfServiceDO>(getTermsOfServiceDO);

            string output = CallApi(settings, jsonContent);

            TermsOfServiceResponseDO response = (TermsOfServiceResponseDO)jss.Deserialize(output, typeof(TermsOfServiceResponseDO));
            return response;
        }

        public AgreeToTermsOfServiceResponseDO AgreeToTermsOfService(Settings settings, AgreeToTermsOfServiceDO agreeToTermsOfServiceDO)
        {
            settings.MethodName = "agreeToTOS";

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string jsonContent = Util.JsonSerializer<AgreeToTermsOfServiceDO>(agreeToTermsOfServiceDO);

            string output = CallApi(settings, jsonContent);

            AgreeToTermsOfServiceResponseDO response = (AgreeToTermsOfServiceResponseDO)jss.Deserialize(output, typeof(AgreeToTermsOfServiceResponseDO));
            return response;
        }
    }
}
