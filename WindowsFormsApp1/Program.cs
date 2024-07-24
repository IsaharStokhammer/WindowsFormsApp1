using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            
            Dictionary<string, string> year = new Dictionary<string, string>()
            {
                   {"תשפ\"ד", "חמשת אלפים ושבע מאות שמונים וארבע"},
                   {"תשפ\"ה", "חמשת אלפים ושבע מאות שמונים וחמש"},
                   {"תשפ\"ו", "חמשת אלפים ושבע מאות שמונים ושש"},
                   {"תשפ\"ז", "חמשת אלפים ושבע מאות שמונים ושבע"},
                   {"תשפ\"ח", "חמשת אלפים ושבע מאות שמונים ושמונה"},
                   {"תשפ\"ט", "חמשת אלפים ושבע מאות שמונים ותשע"},
                   {"תש\"צ", "חמשת אלפים ושמונה מאות"},
                   {"תשצ\"א", "חמשת אלפים ושמונה מאות ואחת"},
                   {"תשצ\"ב", "חמשת אלפים ושמונה מאות ושתיים"},
                   {"תשצ\"ג", "חמשת אלפים ושמונה מאות ושלוש"}
            };
            Dictionary<int, string> dayOfMonth = new Dictionary<int, string>()
            {
                { 1, "יום אחד" },
                { 2, "שני ימים" },
                {3, "שלשה ימים" },
                {4, "ארבעה ימים" },
                { 5, "חמישה ימים" },
                { 6, "שישה ימים" },
                { 7, "שבעה ימים" },
                { 8, "שמונה ימים" },
                { 9, "תשעה ימים" },
                { 10, "עשרה ימים" },
                { 11, "אחד עשר יום" },
                { 12, "שנים עשר יום" },
                { 13, "שלשה עשר יום" },
                { 14, "ארבעה עשר ימים" },
                { 15, "חמישה עשר ימים" },
                { 16, "ששה עשר יום" },
                { 17, "שבעה עשר ימים" },
                { 18, "שמונה עשר ימים" },
                { 19, "תשעה עשר ימים" },
                { 20, "עשרים ימים" },
                { 21, "עשרים ואחד ימים" },
                { 22, "עשרים ושתיים ימים" },
                { 23, "עשרים ושלושה ימים" },
                { 24, "עשרים וארבעה ימים" },
                { 25, "עשרים וחמישה ימים" },
                { 26, "עשרים וששה ימים" },
                { 27, "עשרים ושבעה ימים" },
                { 28, "עשרים ושמונה ימים" },
                { 29, "עשרים ותשע ימים" },
                { 30, "שלשים ימים" }
            };
            


            Application.EnableVisualStyles();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}
