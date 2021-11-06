using System;
using System.IO;
using System.Net;

namespace teamseasapi
{
    class TeamSeasAPI
    {
        public static string GetTotalDonated(bool formatted)
        {
            string url = "https://tscache.com/donation_total.json";

            HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(url); //request
            HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse(); //response

            string result = "";
            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd(); //gets the raw website content (currently '{"count":"12959075"}' )
            }

            result = result.Substring(10).Split('\"')[0]; //to remove the {"count":" and "}

            if(formatted)
            {
                bool done = false;
                int index = 3;
                while(!done) //repeats until finished
                {
                    try
                    {
                        result = result.Insert(result.Length - index, ","); //inserts a comma where it should be (index)
                        index += 4;
                    }
                    catch(Exception e) //in a try catch so when it fails it doesn't crash and instead finishes
                    {
                        done = true;
                    }
                }
            }

            return result; //returns the final result
        }
    }
}
