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
    public class BaseBL
    {
        public string CallApi(Settings settings, string jsonContent)
        {
            string message = String.Empty;
            string output = String.Empty;
            string sURL = settings.ApiMethodUrl;

            message += " API URL: " + sURL;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(sURL);
            message += " Request Created ";
            request.Method = "POST";
            request.Headers.Add("Authorization-Token", settings.AuthorizationToken);
            request.ContentLength = jsonContent.Length;
            request.ContentType = @"application/json";

            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            Byte[] byteArray = encoding.GetBytes(jsonContent);
            message += " ByteArray Encoded ";

            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
                message += " DataStream Written ";
            }
            try
            {

                Stream oStream = request.GetResponse().GetResponseStream();
                StreamReader oReader = new StreamReader(oStream);
                output = oReader.ReadToEnd();
                message += " Output: " + output;
            }
            catch (WebException WebEx)
            {
                throw new Exception("WebEx Error: Unable to access ProctorU API: " + WebEx.Message, WebEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to access ProctorU API: " + ex.Message, ex);
            }

            return output;
        }
    }
}
