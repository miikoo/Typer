using System.Collections.Generic;

namespace Typer.Database.Entities
{
    public class User
    {
        
        public long UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string ASd { get; set; }




        /*
        
        private int a;
        public void Set(int x)
        {
            a = x;
        }
        public int Get()
        {
            return a;
        }

        */













        public User()
        {
            MatchPredictions = new HashSet<MatchPrediction>();
        }

        public virtual ICollection<MatchPrediction> MatchPredictions { get; set; }
    }
}
