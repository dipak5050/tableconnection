using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableconnection
{
    public class datetime
    {
        public DateTime getdatetime { get; set; }
    }

    public class PromptPanCustomer : datetime
    {
        public int cid { get; set; }
        public string cname { get; set; }
    }
    public class PromptPanProductName : datetime
    {
        public int ppid { get; set; }
        public string ppn { get; set; }

        public int pptid { get; set; }

        public float pptrs { get; set; }


    }
    public class PromptPanProductType : datetime
    {
        public int ptid;
        public string pttype;
    }

    public class total : datetime
    {
        public int billno;
        public int cid;
        public int ptid;
        public int pnid;
        public int quantity;
    }

    class Program
    {
        static void Main(string[] args)
        {
            total ob = new total();
        Console.WriteLine   ( ob.getdatetime = DateTime.Now);

            Console.ReadLine();
    }
    } }
