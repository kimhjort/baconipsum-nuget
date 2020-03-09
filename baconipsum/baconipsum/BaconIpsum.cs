using System;
using System.IO;
using System.Net;

namespace baconipsum
{
    public static class BaconIpsum
    {
        public static string MakeBacon()
        {
            string urlParas = "paras=1";

            return MakeBacon(urlParas);
        }

        public static string MakeBacon(int paras)
        {
            string urlParas = "";

            if (paras > 0)
            {
                urlParas = "paras=" + paras;
            }

            return MakeBacon(urlParas);
        }

        public static string MakeBacon(int paras, int sentences)
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

            return MakeBacon(urlParas);
        }

        private static string MakeBacon(string urlParas)
        {
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

        public static string Baconmockup(int width, int height)
        {
            return "https://baconmockup.com/" + width.ToString() + "/" + height.ToString();
        }
    }
}