using System;
using System.Data;
using System.Net;
using System.Text;
using System.Configuration;

namespace PCMS
{
    class SmsNotificaton
    {
        static public int SendSms(string Recipient, string Message)
        {
            WebClient wc = new WebClient();
            string sRequestURL, sRequestData;

            sRequestURL = "http://www.redoxygen.net/sms.dll?Action=SendSMS";

            sRequestData = "AccountID=" + ConfigurationManager.AppSettings["AccountID"]
                + "&Email=" + System.Web.HttpUtility.UrlEncode(ConfigurationManager.AppSettings["UserID"])
                + "&Password=" + System.Web.HttpUtility.UrlEncode(EncryptionHelper.Decrypt(ConfigurationManager.AppSettings["SmsPassword"]))
                + "&Recipient=" + System.Web.HttpUtility.UrlEncode(Recipient)
                + "&Message=" + System.Web.HttpUtility.UrlEncode(Message);

            byte[] postData = Encoding.ASCII.GetBytes(sRequestData);
            byte[] response = wc.UploadData(sRequestURL, postData);

            string sResult = Encoding.ASCII.GetString(response);

            int result = System.Convert.ToInt32(sResult.Substring(0, 4));

            return result;
        }
    }
}
