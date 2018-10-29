using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

using Newtonsoft.Json;
using System.IO;

namespace JsonParseTest
{
    class Parser
    {
        public List<Review> Reviews { get; set; }

        private JsonSerializer serializer;

        public Parser()
        {
            Reviews = new List<Review>();
        }

        public void ParseReviews()
        {
            Reviews = JsonConvert.DeserializeObject<List<Review>>(File.ReadAllText("ratings.json"));
        }
        
    }
}
