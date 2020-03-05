using System;
using System.IO;
using System.Net;

namespace baconipsum
{
    public static class BaconIpsum
    {
        public static string CallBacon(int paras, int sentences)
        {
            string urlParas = "";

            if (paras > 0)
            {
                urlParas = "paras=" + paras;
            }

            if (sentences > 0)
            {
                urlParas = "sentences=" + sentences;
            }

            string html = string.Empty;
            string url = @"http://baconipsum.com/api/?type=all-meat&" + urlParas + "&start-with-lorem=0&format=text";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            return html;
        }
    }
}