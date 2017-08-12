using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace UppEx
{
    class Servicio
    {
        private string url { get; set; }
        private HttpWebRequest httpRequest { get; set; }
        private HttpWebResponse httpResponse { get; set; }
        private StreamWriter streamWriter { get; set; }
        private StreamReader streamReader { get; set; }
        private string body { get; set; }
        private string results { get; set; }

        public Servicio()
        {
            //url = "http://localhost/UppEx/";
            //url = "http://192.168.43.95:8080/webServicePaqueteria/";

            url = "http://192.168.43.246/webServicePaqueteria/";
            httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.ContentType = "application/json";
            httpRequest.Method = "POST";
            streamWriter = new StreamWriter(httpRequest.GetRequestStream());
        }

        public string llamarServicio(string parametros)
        {
            body = parametros;
            streamWriter.InitializeLifetimeService();
            streamWriter.Write(body);
            streamWriter.Flush();
            
            httpResponse = (HttpWebResponse)httpRequest.GetResponse();

            using (streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                results = streamReader.ReadToEnd();
            }
            return results;
        }
    };
}
