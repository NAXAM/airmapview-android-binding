using Android.App;
using Android.Widget;
using Android.OS;
using Com.Airbnb.Android;
using Com.Airbnb.Android.Airmapview;
using AirMapViewQs.Code;
using Com.Airbnb.Android.Airmapview.Listeners;
using Android.Support.V7.Widget;

namespace AirMapViewQs
{
    [Activity(Label = "AirMapViewQs", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        //private LogsAdapter adapter = new LogsAdapter();
        private Com.Airbnb.Android.Airmapview.AirMapView map;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            map = FindViewById<AirMapView>(Resource.Id.map_view);
            map.SetMapType(MapType.MapTypeNormal);

        }
    }
}

