using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Realms;
using RealmFTW.Models;

namespace RealmFTW.Services
{
    class RealmService
    {
        public Repo GetRepo(string name) {
            var realm = Realm.GetInstance();
            var repo = realm.All<Repo>().Where(r => r.Name == name).FirstOrDefault();
            return repo;
        }

        public IEnumerable<Repo> GetRepos()
        {
            var realm = Realm.GetInstance();
            var repos = realm.All<Repo>();
            return repos;
        }

        public void WriteRepos(IEnumerable<Repo> repos)
        {
            var realm = Realm.GetInstance();
            realm.Write(() =>
            {
                foreach (var repo in repos)
                {
                    realm.Add(repo);
                }
            });
        }
    }
}
