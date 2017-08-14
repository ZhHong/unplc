using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.Collections.Generic;
using System;

namespace http_service.httpd
{
    public class httpd {

        public  static IEnumerator Get(string host, int port, string path, string data) {
            string uri = "http://" + host + ":" + port + path;
            using (UnityWebRequest www = UnityWebRequest.Get(uri))
            {
                yield return www.Send();
                if (www.isNetworkError)
                {
                    Debug.Log(www.error);
                }
                else
                {
                    Debug.Log(www.downloadHandler.text);
                    JSONObject js = new JSONObject(www.downloadHandler.text);

                    Debug.Log("json file:" + js.GetField("errorcode") + "-----" + js.GetField("msg"));
                }
            }
        }

        public static IEnumerator Get(string url,string data){
            string uri = url;
            using (UnityWebRequest www = UnityWebRequest.Get(uri))
            {
                yield return www.Send();
                if (www.isNetworkError)
                {
                    Debug.Log(www.error);
                }
                else
                {
                    Debug.Log(www.downloadHandler.text);
                }
            }
        }

        public static IEnumerator Gets(string host,int port,string path,string data)
        {
            string uri = "http://" + host + ":" + port + path;
            using(UnityWebRequest www = UnityWebRequest.Get(uri))
            {
                yield return www.Send();
                if (www.isNetworkError)
                {
                    Debug.Log(www.error);
                }else
                {
                    Debug.Log(www.downloadHandler.text);
                    byte[] results = www.downloadHandler.data;
                }
            }
        }

        public static IEnumerator Gets(string url,string data)
        {
            string uri = url;
            using(UnityWebRequest www = UnityWebRequest.Get(uri))
            {
                yield return www.Send();
                if (www.isNetworkError)
                {
                    Debug.Log(www.error);
                }
                else
                {
                    Debug.Log(www.downloadHandler.text);
                    byte[] results = www.downloadHandler.data;
                }
            }
        }

        public static IEnumerator Post(string host,int port,string path,string data)
        {
            string uri = "http://" + host + ":" + port + path;
            WWWForm form = new WWWForm();
            form.AddField("myfiled", "mydata");
            using(UnityWebRequest www = UnityWebRequest.Post(uri, form))
            {
                yield return www.Send();
                if (www.isNetworkError)
                {
                    Debug.Log(www.error);
                }else
                {
                    Debug.Log("post complete.");
                }
            }
        }

        public static IEnumerator Post(string url,string data)
        {
            string uri = url;
            WWWForm form = new WWWForm();
            form.AddField("myfiled", "mydata");
            using (UnityWebRequest www = UnityWebRequest.Post(uri, form))
            {
                yield return www.Send();
                if (www.isNetworkError)
                {
                    Debug.Log(www.error);
                }
                else
                {
                    Debug.Log("post complete.");
                }
            }
        }

        public static IEnumerator Posts(string host,int port,string path,string data)
        {
            string uri = "http://" + host + ":" + port + path;
            WWWForm form = new WWWForm();
            form.AddField("myfiled", "mydata");
            using (UnityWebRequest www = UnityWebRequest.Post(uri, form))
            {
                yield return www.Send();
                if (www.isNetworkError)
                {
                    Debug.Log(www.error);
                }
                else
                {
                    Debug.Log("post complete.");
                }
            }
        }

        public static IEnumerator Posts(string url,string data)
        {
            string uri = url;
            WWWForm form = new WWWForm();
            form.AddField("myfiled", "mydata");
            using (UnityWebRequest www = UnityWebRequest.Post(uri, form))
            {
                yield return www.Send();
                if (www.isNetworkError)
                {
                    Debug.Log(www.error);
                }
                else
                {
                    Debug.Log("post complete.");
                }
            }
        }
        /// <summary>
        /// 生成http请求签名
        /// </summary>
        /// <param name="data"></param>
        /// <returns>带签名的query_string</returns>
        public static string make_sign(JSONObject json)
        {
            var query_string = "";
            //json.AddField("time", utils.TimeHelp.GetTimeStamp(DateTime.Now, 10));
            json.AddField("time", "123456");

            var args_str = raw_args(json);

            Debug.Log(args_str);
            var sign = encryto_sign_string(args_str);

            json.AddField("sign", sign);

            foreach(var key in json.keys)
            {
                query_string += key + "=" + json[key] + "&";
            }
            query_string = "?" + query_string;
            query_string = query_string.Substring(0,query_string.Length-2);
            return query_string;
        }
        /// <summary>
        /// 检测http response签名
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool check_sign(JSONObject json)
        {
            var data = json.ToDictionary();
            if (data.ContainsKey("sign"))
            {
                var old_sign = data["sign"];
                data.Remove("sign");
                
            }
            return false;
        }

        /// <summary>
        /// 生成签名需要的STRING
        /// </summary>
        /// <returns></returns>
        private static string raw_args(JSONObject json)
        {
            List<string> tmp = new List<string>();
            foreach(var k in json.keys)
            {
                tmp.Add(k);
            }
            tmp.Sort();

            var sign_str = "";
            foreach(var k in tmp)
            {
                var kk = k.ToUpper();
                var value = json.GetField(k);
                if (value.isContainer)
                {
                    sign_str = String.Concat(sign_str, "&" , kk , "?" , value.ToString());
                }
                else
                {
                    sign_str = String.Concat(sign_str, "&", kk, "?", value.ToString().Replace("\"",""));
                }

            }
            return sign_str.Substring(1);
        }

        /// <summary>
        /// 加密签名字符串
        /// </summary>
        /// <returns></returns>
       private static string encryto_sign_string(string args_str)
        {
            var length = args_str.Length;
            var code_string = "";
            for(var i = 0; i < length; ++i)
            {
                code_string += Convert.ToChar(Convert.ToByte(args_str[i]) ^ (i % 256));
            }
            return utils.CryptoHelp.md5_16(code_string);
        }

    }
}
