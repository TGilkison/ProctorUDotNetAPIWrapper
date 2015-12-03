using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using ProctorUAPI.DO;

namespace ProctorUAPI.BL
{
    public class Profile : BaseBL
    {
        public StudentProfileResponseDO GetStudentProfile(Settings settings, StudentProfileDO studentProfileDO)
        {
            settings.MethodName = "getStudentProfile";

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string jsonContent = Util.JsonSerializer<StudentProfileDO>(studentProfileDO);

            string output = CallApi(settings, jsonContent);

            StudentProfileResponseDO response = (StudentProfileResponseDO)jss.Deserialize(output, typeof(StudentProfileResponseDO));
            return response;
        }

        public EditStudentResponseDO EditStudentProfile(Settings settings, EditStudentDO editStudentDO)
        {
            string message = String.Empty;
            EditStudentResponseDO response = new EditStudentResponseDO();

            try
            {
                settings.MethodName = "editStudent";

                JavaScriptSerializer jss = new JavaScriptSerializer();
                string jsonContent = Util.JsonSerializer<EditStudentDO>(editStudentDO);

                message += " Calling EditStudent API";
                string output = CallApi(settings, jsonContent);
                message += " API Output: " + output;

                response = (EditStudentResponseDO)jss.Deserialize(output, typeof(EditStudentResponseDO));
                message += " " + response.message;
            }
            catch (Exception ex)
            {
                throw new Exception(message, ex);
            }
            return response;
        }

        public EmailExistResponseDO EmailExist(Settings settings, EmailExistDO emailExistDO)
        {
            settings.MethodName = "getEmailExist";

            JavaScriptSerializer jss = new JavaScriptSerializer();
            string jsonContent = Util.JsonSerializer<EmailExistDO>(emailExistDO);

            string output = CallApi(settings, jsonContent);

            EmailExistResponseDO response = (EmailExistResponseDO)jss.Deserialize(output, typeof(EmailExistResponseDO));
            return response;
        }

        public EditStudentDO ConvertProfileToEdit(StudentProfileResponseDO profile)
        {
            EditStudentDO editStudent = new EditStudentDO();

            editStudent.address1 = profile.data.address1;
            editStudent.address2 = profile.data.address2;
            editStudent.city = profile.data.city;
            editStudent.computertype = profile.data.computertype;
            editStudent.country = profile.data.country;
            editStudent.email = profile.data.email;
            editStudent.first_name = profile.data.first_name;
            editStudent.last_name = profile.data.last_name;
            editStudent.phone1 = profile.data.phone1;
            editStudent.phone2 = profile.data.phone2;
            editStudent.phone3 = profile.data.phone3;
            editStudent.state = profile.data.state;
            editStudent.student_id = profile.data.student_id;
            editStudent.time_zone_id = profile.data.time_zone_id;
            editStudent.user_id = profile.data.user_id;
            editStudent.zipcode = profile.data.zipcode;

            return editStudent;
        }
    }
}
