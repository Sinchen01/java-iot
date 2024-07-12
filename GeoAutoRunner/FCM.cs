using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace GeoAutoRunner
{
    class FCM
    {
        public static void Send(string deviceId, string notificationtitle , string gps , string message)
        {
            string serverApiKey = "AIzaSyDNmfAYnsmJDn6Bb0QIIzMvfciEume8oWY";
            string senderId = "notification-40514";
            try
            {
                string url = @"https://fcm.googleapis.com/fcm/send";
                WebRequest tRequest = WebRequest.Create(url);
                tRequest.Method = "post";
                tRequest.ContentType = "application/json";

                //string postData = "collapse_key=score_update&time_to_live=108&delay_while_idle=1&data.message=" + message + "&data.time=" + System.DateTime.Now.ToString() + "&registration_id=" + deviceId + "";

                // actionid : 1   turn off gas yes or not   actionid : 2 only notification about leakage
                var data = new
                {
                    to = deviceId,
                    data = new
                    {
                        title = notificationtitle,
                        body=message,
                        type="image/location",
                        location=gps,
                        image=""
                    }
                };
                string jsonss = Newtonsoft.Json.JsonConvert.SerializeObject(data);

                Byte[] byteArray = Encoding.UTF8.GetBytes(jsonss);
                tRequest.Headers.Add(string.Format("Authorization: key={0}", serverApiKey));
                tRequest.Headers.Add(string.Format("Sender: id={0}", senderId));
                tRequest.ContentLength = byteArray.Length;
                tRequest.ContentType = "application/json";
                using (Stream dataStream = tRequest.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);

                    using (WebResponse tResponse = tRequest.GetResponse())
                    {
                        using (Stream dataStreamResponse = tResponse.GetResponseStream())
                        {
                            using (StreamReader tReader = new StreamReader(dataStreamResponse))
                            {
                                String sResponseFromServer = tReader.ReadToEnd();
                                Console.Write(sResponseFromServer);
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Console.Write(ex.Message);
                {
                    var sss = ex.Message;
                    if (ex.InnerException != null)
                    {
                        var ss = ex.InnerException;
                    }
                }
            }
        }
    }     
}
