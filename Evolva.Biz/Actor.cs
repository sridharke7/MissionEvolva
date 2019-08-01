using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolva.Biz
{
    public class Actor
    {
        public Actor()
        {
            Console.WriteLine("An actor is born");
        }

        public Actor(string actorName)
        {
            ActorName = actorName;
        }

        private string actorName;

        public string ActorName
        {
            get { return actorName; }
            set { actorName = value; }
        }


        private string jobTitle;

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public string GetOccupation()
        {
            JobTitle = "Actor";
            return JobTitle;
        }
    }
}
