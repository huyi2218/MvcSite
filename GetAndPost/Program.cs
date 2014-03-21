using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GetAndPost
{
    class Program
    {
        static void Main(string[] args)
        {

            //用法举例  http://zhoufoxcn.blog.51cto.com/792419/561934
           // string userName = "userName";
            string tagUrl = @"http://www.baidu.com";
            CookieCollection cookies = new CookieCollection();//如何从response.Headers["Set-Cookie"];中获取并设置CookieCollection的代码略  
            //Cookie cookie = new Cookie("JSESSIONID", "FF9DE8B70C192FED0F841043185E6D95");
            //cookies.Add(cookie);
            HttpWebResponse response = HttpWebResponseUtility.CreateGetHttpResponse(tagUrl, null, null, cookies);
            Stream st = response.GetResponseStream();
            StreamReader sr = new StreamReader(st, Encoding.UTF8);
            string s = sr.ReadToEnd();
           // Console.Write(s);
            

        }
    }
}
