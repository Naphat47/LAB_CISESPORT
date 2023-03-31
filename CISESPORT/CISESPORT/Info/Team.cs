using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CISESPORT.Info
{
    public class Team //key
    {
        public string _Team { get; set; }
        public string Name1 { get; set; }
        public string GameName1 { get; set; }
        public string Name2 { get; set; }
        public string GameName2 { get; set; }
        public string Name3 { get; set; }
        public string GameName3 { get; set; }
        public string Name4 { get; set; }
        public string GameName4 { get; set; }
        public string Name5 { get; set; }
        public string GameName5 { get; set; }

        public Team(string team, string name1, string Gname1, string name2, string Gname2, string name3, string Gname3, string name4, string Gname4, string name5, string Gname5)
        {
            _Team = team;
            Name1 = name1;
            GameName1 = Gname1;
            Name2 = name2;
            GameName2 = Gname2;
            Name3 = name3;
            GameName3 = Gname3;
            Name4 = name4;
            GameName4 = Gname4;
            Name5 = name5;
            GameName5 = Gname5;
        }
    }
}
