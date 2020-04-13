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

namespace RecvIntent.Droid
{
    [Activity(Label = "Activity1", Name = "com.companyname.recvintent.activity1", MainLauncher = true)]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            System.Diagnostics.Debug.Print("Activity1.OnCreate");

            base.OnCreate(savedInstanceState);

            // Create your application here
        }

        protected override void OnNewIntent(Intent intent)
        {
            System.Diagnostics.Debug.Print("Activity1.OnNewIntent");

            if (intent.Extras != null)
            {


            }

            base.OnNewIntent(intent);
        }

    }
}