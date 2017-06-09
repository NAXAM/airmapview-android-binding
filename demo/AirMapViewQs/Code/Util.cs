using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IO;
using Java.IO;

namespace AirMapViewQs
{
    public class Util
    {
        private const string LOGTAG = "Until";

        public static string ReadFromRawResource(Context context, int resourceid)
        {
            Stream resourcereader = context.Resources.OpenRawResource(resourceid);
            Writer writer = new Java.IO.StringWriter();
            try
            {
                BufferedReader reader = new BufferedReader(new InputStreamReader(resourcereader,"UTF-8"));
                string line = reader.ReadLine();
                while(line != null)
                {
                    writer.Write(line);
                    line = reader.ReadLine();
                }
            } catch(Exception e)
            {
                
            } finally
            {
                try
                {
                    resourcereader.Close();
                } catch (Exception e)
                {
                    
                }
            }

            return writer.ToString();
        }
    }
}