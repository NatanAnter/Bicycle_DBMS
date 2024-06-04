using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bicycle_DBMS;
using System.IO;


namespace Bicycle_Forms
{


    //להכין את המילון V
    //לסדר את עניין העתקת הנתונים שלא יהיה בצורה מטומטמת X
    //להכין ממשק לתיקונים V
    //פריטים שחסרים במלאי V
    //רווח יומי V
    //לחבר את האקדח V
    //לבדוק איפה הנתונים חשוב V
    //לסיים את כפתור הסיום V
    //לסיים את המילון V
    //לתקן עדכון סטטוס V
    //הרשאת גישה V
    //לעשות חיפוש מוצרים V
    //להגדיל את ממשק התיקונים V

    //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

    //דוח יומי למייל 
    //להגדיל את החלון הראשי

    static class Program
    {
        //קבועים 
        const string REPORT_PATH = @"C:\Users\Natan\Desktop\Bicycle_DBMS";

        //משתנים סטטיים
        public static DailyReport Reports;

       
        [STAThread]
        public static void Main()
        {


            //System.IO.FileStream gh;

            //string ReportPath = REPORT_PATH;
            try
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new AccountWin());
            }
            catch(Exception e)
            {
                MessageBox.Show("opps \n" + e);
            }
            
        }

    }
}
