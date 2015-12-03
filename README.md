# ProctorUDotNetAPIWrapper
A .NET API Wrapper for ProctorU's API

Create a Settings Object and Populate with ProctorU Settings

        public Settings GetProctorUSettings()
        {
            Settings settings = new Settings();
            settings.AuthorizationToken = proctorUAuthorizationToken;
            settings.ApiRootUrl = proctorUApiRootUrl;
            return settings;
        }

Create a DataObject from the /DO folder and Set Parameter:

    StudentProfileDO studentProfileDO = new StudentProfileDO();
    studentProfileDO.student_id = participant.Participant_Name;


Call the ProctorU Wrapper Method and set the output equal to the ResponseDO object in the /DO folder

    StudentProfileResponseDO studentProfile = puProfile.GetStudentProfile(config.GetProctorUSettings(), studentProfileDO);