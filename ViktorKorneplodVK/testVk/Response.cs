using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testVk
{
    class getProfileInfo
    {
        public Response response;
        public class Response
        {
            public string id;
            public string first_name;
            public string last_name;
            public string status_1223;
        }
    }
    class getAvatar
    {
        public Response[] response;
        public class Response
        {
            public string photo_50;
        }
    }


    public class FriendsGet
    {
        public Response response { get; set; }

        public class Item
        {
            public int id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public bool can_access_closed { get; set; }
            public bool is_closed { get; set; }
            public string photo_50 { get; set; }
            public string track_code { get; set; }
            public List<int> lists { get; set; }
        }

        public class Response
        {
            public int count { get; set; }
            public List<Item> items { get; set; }
        }
    }
   

    public class friendList
    {
        public Response response { get; set; }
        public class Item
        {
            public int id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public bool can_access_closed { get; set; }
            public bool is_closed { get; set; }
            public string bdate { get; set; }
            public string track_code { get; set; }
            public string deactivated { get; set; }
        }

        public class Response
        {
            internal string bdate;

            public int count { get; set; }
            public List<Item> items { get; set; }
        }
    }
    //Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class LikeAllPhoto
    {
        public Response response { get; set; }
        public class Item
        {
            public int album_id { get; set; }
            public int date { get; set; }
            public int id { get; set; }
            public int owner_id { get; set; }
            public int post_id { get; set; }
            public List<Size> sizes { get; set; }
            public string text { get; set; }
            public bool has_tags { get; set; }
            public double? lat { get; set; }
            public double? @long { get; set; }
        }

        public class Response
        {
            public int count { get; set; }
            public List<Item> items { get; set; }
        }
        public class Size
        {
            public int height { get; set; }
            public string url { get; set; }
            public string type { get; set; }
            public int width { get; set; }
        }
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Like
    {
        public Response response { get; set; }
        public class Response
        {
            public int likes { get; set; }
        }

    }

}
