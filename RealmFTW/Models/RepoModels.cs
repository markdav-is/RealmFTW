using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Realms;

namespace RealmFTW.Models
{

    public class Repo : RealmObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public Owner Owner { get; set; }
        public License License { get; set; }
    }

    public class Owner : RealmObject
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string AvatarURL { get; set; }
    }

    public class License : RealmObject
    {
        public string Key { get; set; }
        public string Name { get; set; }
    }
}

