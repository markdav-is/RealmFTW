using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using RealmFTW.Models;
using Newtonsoft.Json;

namespace RealmFTW.Services
{
    public class NetDataService
    {
        public IEnumerable<Repo> GetRepos(string url)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add("User-Agent: Other");
                var json =  wc.DownloadString(url);
                var list = JsonConvert.DeserializeObject<IEnumerable<Repo>>(json);
                return list;
            }
        }
    }
}
