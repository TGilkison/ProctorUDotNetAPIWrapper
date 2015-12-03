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
    public class Exam : BaseBL
    {
        public BlueBirdExamResponseDO AddBlueBirdExam(Settings settings, BlueBirdExamDO exam)
        {
            settings.MethodName = "addbluebirdexam";

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string jsonContent = Util.JsonSerializer<BlueBirdExamDO>(exam);

            string output = CallApi(settings, jsonContent);

            object response = jss.Deserialize(output, typeof(BlueBirdExamResponseDO));
            return (BlueBirdExamResponseDO)response;
        }

        public ProcessResponseDO AddProcess(Settings settings, ProcessDO process)
        {
            settings.MethodName = "addProcess";
            if (String.IsNullOrEmpty(process.reservation_no))
            {
                process.reservation_no = "0";
            }

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string jsonContent = Util.JsonSerializer<ProcessDO>(process);

            string output = CallApi(settings, jsonContent);

            object response = jss.Deserialize(output, typeof(ProcessResponseDO));
            return (ProcessResponseDO)response;
        }

        public AdHocProcessResponseDO AddAdHocProcess(Settings settings, AdHocProcessDO adHocProcess)
        {
            settings.MethodName = "addAdHocProcess";
            if (String.IsNullOrEmpty(adHocProcess.reservation_no))
            {
                adHocProcess.reservation_no = "0";
            }

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string jsonContent = Util.JsonSerializer<AdHocProcessDO>(adHocProcess);

            string output = CallApi(settings, jsonContent);

            object response = jss.Deserialize(output, typeof(AdHocProcessResponseDO));
            return (AdHocProcessResponseDO)response;
        }

        public TermExamResponseDO EditTermExam(Settings settings, TermExamDO termExam)
        {
            settings.MethodName = "editTermExam";

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string jsonContent = Util.JsonSerializer<TermExamDO>(termExam);

            string output = CallApi(settings, jsonContent);

            object response = jss.Deserialize(output, typeof(TermExamResponseDO));
            return (TermExamResponseDO)response;
        }
        
    }
}
