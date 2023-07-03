using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AimLab
{
    [Serializable]
    public class Leaderboard
    {
        public List<Account> Accounts { get; set; }
        public DateTime LastUpdated { get; set; }
        public Leaderboard()
        {
            Accounts = new List<Account>();
        }
        public bool UsernameExists(string username)
        {
            if (Accounts.Where(s => s.Name == username).Any())
                return true;
            return false;
        }
    }
}
