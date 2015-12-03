# ProctorU DotNet API Wrappers
<b>.NET API Wrappers for ProctorU's API</b>

*  ProctorUAPI_V1 is for the old version of the API
*  ProctorUArchimedesAPIWrapper is for the version released 01/31/2016


Create a Settings Object and Populate with ProctorU Settings.  The Settings object is located in the ROOT of the Wrapper.

        public Settings GetProctorUSettings()
        {
            Settings settings = new Settings();
            settings.AuthorizationToken = proctorUAuthorizationToken;
            settings.ApiRootUrl = proctorUApiRootUrl;
            return settings;
        }

Create a DataObject from the /DO folder and Set Parameter to pass to the API:

    StudentProfileDO studentProfileDO = new StudentProfileDO();
    studentProfileDO.student_id = participant.Participant_Name;


Call the ProctorU Wrapper Method and set the output equal to the ResponseDO object from the /DO folder

    StudentProfileResponseDO studentProfile = puProfile.GetStudentProfile(config.GetProctorUSettings(), studentProfileDO);
