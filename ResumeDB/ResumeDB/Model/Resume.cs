using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeDB.Model
{
    public class Resume
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Post { get; set; }
        public string JobExperience { get; set; }
        public bool CPP { get; set; }
        public bool CSharp { get; set; }
        public bool Unity  { get; set; }
        public bool WPF { get; set; }
        public bool SQL { get; set; }

        public Resume() { }
        public Resume(string name, string surname, string email, string post, string jobExperience, bool cPP, bool cSharp, bool unity, bool wPF, bool sQL)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Post = post;
            JobExperience = jobExperience;
            CPP = cPP;
            CSharp = cSharp;
            Unity = unity;
            WPF = wPF;
            SQL = sQL;
        }
        public override string ToString()
        {
            return string.Concat(Name, " ", Surname);
        }
    }
}
