using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using ProctorUAPI.DO;

namespace ProctorUAPI.BL
{
    public class Reservation : BaseBL
    {
        public StudentReservationListResponseDO GetStudentReservationList(Settings settings, StudentReservationListDO studentReservationListDO)
        {
            settings.MethodName = "getStudentReservationList";

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string jsonContent = Util.JsonSerializer<StudentReservationListDO>(studentReservationListDO);

            string output = CallApi(settings, jsonContent);
            Object test = jss.DeserializeObject(output);

            StudentReservationListResponseDO response = (StudentReservationListResponseDO)jss.Deserialize(output, typeof(StudentReservationListResponseDO));
            return response;
        }

        public BeginReservationResponseDO BeginReservation(Settings settings, BeginReservationDO beginReservationDO)
        {
            settings.MethodName = "beginReservation";

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string jsonContent = Util.JsonSerializer<BeginReservationDO>(beginReservationDO);

            string output = CallApi(settings, jsonContent);

            BeginReservationResponseDO response = (BeginReservationResponseDO)jss.Deserialize(output, typeof(BeginReservationResponseDO));
            return response;
        }

        public RemoveReservationResponseDO RemoveReservation(Settings settings, RemoveReservationDO RemoveReservationDO)
        {
            settings.MethodName = "removeReservation";

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string jsonContent = Util.JsonSerializer<RemoveReservationDO>(RemoveReservationDO);

            string output = CallApi(settings, jsonContent);

            RemoveReservationResponseDO response = (RemoveReservationResponseDO)jss.Deserialize(output, typeof(RemoveReservationResponseDO));
            return response;
        }


    }
}
