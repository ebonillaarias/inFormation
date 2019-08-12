using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace inFormation.Utility
{
    public class HelperWebService<T>
    {
        public static string GetInvokeString(string str_Url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(str_Url);
            request.ContentType = "application/json";
            request.Method = "GET";
            //request.ContinueTimeout = 200000;
            request.Proxy = null;

            string result = string.Empty;
            try
            {
                var response = request.GetResponseAsync().Result;
                var respStream = response.GetResponseStream();
                respStream.Flush();
                using (StreamReader sr = new StreamReader(respStream))
                {
                    string strContent = sr.ReadToEnd();
                    respStream = null;
                    result = strContent;//JsonConvert.DeserializeObject<string>(strContent);
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;

            }
            return result;
        }

        public static string GetInvokeStringDeserialize(string str_Url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(str_Url);
            request.ContentType = "application/json";
            request.Method = "GET";
            //request.ContinueTimeout = 200000;
            request.Proxy = null;

            string result = string.Empty;
            try
            {
                var response = request.GetResponseAsync().Result;
                var respStream = response.GetResponseStream();
                respStream.Flush();
                using (StreamReader sr = new StreamReader(respStream))
                {
                    string strContent = sr.ReadToEnd();
                    respStream = null;
                    result = JsonConvert.DeserializeObject<string>(strContent);
                }
            }
            catch (Exception)
            {
                return null;
            }
            return result;
        }

        public static string GetInvokeStringXML(string str_Url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(str_Url);
            request.ContentType = "application/json";
            request.Method = "GET";
            //request.ContinueTimeout = 200000;
            request.Proxy = null;

            int res = 0;
            string result = string.Empty;
            try
            {
                var response = request.GetResponseAsync().Result;
                var respStream = response.GetResponseStream();
                respStream.Flush();
                using (StreamReader sr = new StreamReader(respStream))
                {
                    string strContent = sr.ReadToEnd();
                    respStream = null;
                    var serializer = new XmlSerializer(typeof(int), "http://schemas.microsoft.com/2003/10/Serialization/");
                    using (var reader = new StringReader(strContent))
                    {
                        res = (int)serializer.Deserialize(reader);
                    }
                    result = Convert.ToString(res);// JsonConvert.DeserializeObject<string>(strContent);
                }
            }
            catch (Exception)
            {
                return null;
            }
            return result;
        }

        public static List<T> GetInvoke(string str_Url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(str_Url);
            request.ContentType = "application/json";
            request.Method = "GET";
            //request.ContinueTimeout = 200000;
            request.Proxy = null;

            List<T> result = new List<T>();
            try
            {
                var response = request.GetResponseAsync().Result;
                var respStream = response.GetResponseStream();
                respStream.Flush();
                using (StreamReader sr = new StreamReader(respStream))
                {
                    string strContent = sr.ReadToEnd();
                    respStream = null;
                    result = JsonConvert.DeserializeObject<List<T>>(strContent);
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return null;
            }
            return result;
        }

        public static List<T> FLPostInvoke(string str_Url, object obj_Parameter)
        {
            List<T> result = new List<T>();
            try
            {
                HttpClient client = new HttpClient();
                client.Timeout = TimeSpan.FromSeconds(200000);
                string jsonData = JsonConvert.SerializeObject(obj_Parameter);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = client.PostAsync(str_Url, content).Result;

                var strContent = response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<List<T>>(strContent.Result);
            }
            catch (Exception)
            {
                return null;
            }
            return result;
        }

        public static String PostInvokeString(string str_Url, object obj_Parameter)
        {
            string result = "";
            try
            {
                HttpClient client = new HttpClient();
                client.Timeout = TimeSpan.FromSeconds(200000);
                string jsonData = JsonConvert.SerializeObject(obj_Parameter);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = client.PostAsync(str_Url, content).Result;

                var strContent = response.Content.ReadAsStringAsync();
                result = strContent.Result;
            }
            catch (Exception)
            {
                return null;
            }
            return result;
        }

        public static String PostInvokeStringAWS(string str_Url, object obj_Parameter)
        {
            string result = "";
            try
            {
                HttpClient client = new HttpClient();
                client.Timeout = TimeSpan.FromSeconds(200000);
                string jsonData = JsonConvert.SerializeObject(obj_Parameter);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = client.PostAsync(str_Url, content).Result;

                var strContent = response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<string>(strContent.Result);
            }
            catch (Exception)
            {
                return null;
            }
            return result;
        }

        public static T GetObjectInvoke(string str_Url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(str_Url);
            request.ContentType = "application/json";
            request.Method = "GET";
            //request.ContinueTimeout = 200000;
            request.Proxy = null;

            WebResponse response;
            response = null;
            try
            {
                response = request.GetResponseAsync().Result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            var respStream = response.GetResponseStream();
            respStream.Flush();

            using (StreamReader sr = new StreamReader(respStream))
            {
                string strContent = sr.ReadToEnd();
                respStream = null;
                T result = JsonConvert.DeserializeObject<T>(strContent);
                return result;
            }
        }

        public static T PostItemsInvoke(string str_Url, List<T> obj_Parameter)
        {
            HttpClient client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(200000);
            string jsonData = JsonConvert.SerializeObject(obj_Parameter);

            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            HttpResponseMessage response;
            response = null;
            try
            {
                response = client.PostAsync(str_Url, content).Result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            var strContent = response.Content.ReadAsStringAsync();
            T result = JsonConvert.DeserializeObject<T>(strContent.Result);
            return result;
        }

        public static T FPostInvoke(string str_Url, object obj_Parameter)
        {

            try
            {
                HttpClient client = new HttpClient();
                client.Timeout = TimeSpan.FromSeconds(200000);
                string jsonData = JsonConvert.SerializeObject(obj_Parameter);

                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                HttpResponseMessage response;
                response = null;

                response = client.PostAsync(str_Url, content).Result;

                var strContent = response.Content.ReadAsStringAsync();

                if (strContent.Result.Contains("ExceptionMessage"))
                {
                    throw new Exception(strContent.Result);
                }
                else
                {
                    T result = JsonConvert.DeserializeObject<T>(strContent.Result);
                    return result;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

    }
}
