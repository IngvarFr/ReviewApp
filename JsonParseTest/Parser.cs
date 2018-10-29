using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

using Newtonsoft.Json;
using System.IO;

namespace JsonParseTest
{
    public class Parser
    {
        public IEnumerable<Review> Reviews { get; set; }

        public Parser()
        {
            Reviews = new List<Review>();
        }

        public void ParseReviews()
        {
            Reviews = JsonConvert.DeserializeObject<IEnumerable<Review>>(File.ReadAllText("ratings.json"));
        }
        
    }
}
