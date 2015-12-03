using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using ProctorUAPI.DO;

namespace ProctorUAPI.BL
{
    public class Schedule : BaseBL
    {
        public ScheduleInfoTermListResponseDO GetScheduleInfoTermList(Settings settings, ScheduleInfoTermListDO getScheduleInfoTermListDO)
        {
            settings.MethodName = "getScheduleInfoTermList";

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string jsonContent = Util.JsonSerializer<ScheduleInfoTermListDO>(getScheduleInfoTermListDO);

            string output = CallApi(settings, jsonContent);

            ScheduleInfoTermListResponseDO response = (ScheduleInfoTermListResponseDO)jss.Deserialize(output, typeof(ScheduleInfoTermListResponseDO));
            return response;
        }

        public ScheduleInfoExamListResponseDO GetScheduleInfoExamList(Settings settings, ScheduleInfoExamListDO getScheduleInfoExamListDO)
        {
            settings.MethodName = "getScheduleInfoExamList";

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string jsonContent = Util.JsonSerializer<ScheduleInfoExamListDO>(getScheduleInfoExamListDO);

            string output = CallApi(settings, jsonContent);

            ScheduleInfoExamListResponseDO response = (ScheduleInfoExamListResponseDO)jss.Deserialize(output, typeof(ScheduleInfoExamListResponseDO));
            return response;
        }

        public ScheduleInfoAvailableTimesListResponseDO GetScheduleInfoAvailableTimesList(Settings settings, ScheduleInfoAvailableTimesListDO getScheduleInfoAvailableTimesListDO)
        {
            settings.MethodName = "getScheduleInfoAvailableTimesList";

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string jsonContent = Util.JsonSerializer<ScheduleInfoAvailableTimesListDO>(getScheduleInfoAvailableTimesListDO);

            string output = CallApi(settings, jsonContent);

            ScheduleInfoAvailableTimesListResponseDO response = (ScheduleInfoAvailableTimesListResponseDO)jss.Deserialize(output, typeof(ScheduleInfoAvailableTimesListResponseDO));
            return response;
        }

        public ScheduleInfoAvailableTimesListWithoutExamResponseDO GetScheduleInfoAvailableTimesListWithoutExam(Settings settings, ScheduleInfoAvailableTimesListWithoutExamDO getScheduleInfoAvailableTimesListWithoutExamDO)
        {
            settings.MethodName = "getScheduleInfoAvailableTimesList";

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string jsonContent = Util.JsonSerializer<ScheduleInfoAvailableTimesListWithoutExamDO>(getScheduleInfoAvailableTimesListWithoutExamDO);

            string output = CallApi(settings, jsonContent);

            ScheduleInfoAvailableTimesListWithoutExamResponseDO response = (ScheduleInfoAvailableTimesListWithoutExamResponseDO)jss.Deserialize(output, typeof(ScheduleInfoAvailableTimesListWithoutExamResponseDO));
            return response;
        }

    }
}
