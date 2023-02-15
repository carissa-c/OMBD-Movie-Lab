using System;
using Newtonsoft.Json;
using System.Net;

namespace Searching_OMBD_Lab.Models
{
	public class MoviesDAL
	{
        public static Movies GetMovie(string input)//adjust here
        {
            //Adjust here
            //Setup
            string url = $"https://www.omdbapi.com/?t={input}&apikey={Secret.key}";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Convert it to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //Adjust here
            //Convert to C#
            Movies result = JsonConvert.DeserializeObject<Movies> (JSON);
            return result;
        }
    }
}

