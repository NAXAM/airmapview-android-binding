using Android.Widget;
using Android.OS;
using Com.Airbnb.Android;
using Com.Airbnb.Android.Airmapview;
using AirMapViewQs.Code;
using Com.Airbnb.Android.Airmapview.Listeners;
using Android.Support.V7.Widget;
using Android.App;
using Android.Support.V4.App;
using Android.Gms.Maps.Model;
using System;
using System.Diagnostics;
using Android.Graphics;
using System.Collections.Generic;
using Android.Views;

namespace AirMapViewQs
{
    [Activity(Label = "AirMapViewQs", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : FragmentActivity, IOnCameraChangeListener, IOnMapInitializedListener,
        IOnMapClickListener, IOnCameraMoveListener, IOnMapMarkerClickListener, IOnMapMarkerDragListener,
        IOnInfoWindowClickListener, IOnLatLngScreenLocationCallback
    {
        //private LogsAdapter adapter = new LogsAdapter();
        private Com.Airbnb.Android.Airmapview.AirMapView mapView;
        private DefaultAirMapViewBuilder mapViewBuilder;
        private RecyclerView logsRecyclerView;
        private Button btNormal;
        private Button btSattelite;
        private Button btTerrain;
        private LogsAdapter adapter = new LogsAdapter();
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            InitInterface();
        }
        public void InitInterface()
        {
            btNormal = FindViewById<Button>(Resource.Id.btnMapTypeNormal);
            btSattelite = FindViewById<Button>(Resource.Id.btnMapTypeSattelite);
            btTerrain = FindViewById<Button>(Resource.Id.btnMapTypeTerrain);
            mapView = FindViewById<Com.Airbnb.Android.Airmapview.AirMapView>(Resource.Id.map_view);

            mapViewBuilder = new DefaultAirMapViewBuilder(this);
            logsRecyclerView = FindViewById<RecyclerView>(Resource.Id.logs);
            logsRecyclerView.SetLayoutManager(new LinearLayoutManager(this)
            {
                ReverseLayout = true
            });
            logsRecyclerView.SetAdapter(adapter);

            btNormal.Click += (s, e) =>
            {
                mapView.SetMapType(MapType.MapTypeNormal);
            };
            btSattelite.Click += (s, e) =>
            {
                mapView.SetMapType(MapType.MapTypeSatellite);
            };
            btTerrain.Click += (s, e) =>
            {
                mapView.SetMapType(MapType.MapTypeTerrain);
            };

            mapView.SetOnMapClickListener(this);
            mapView.SetOnCameraChangeListener(this);
            mapView.SetOnCameraMoveListener(this);
            mapView.SetOnMarkerClickListener(this);
            mapView.SetOnMarkerDragListener(this);
            mapView.SetOnMapInitializedListener(this);
            mapView.SetOnInfoWindowClickListener(this);
            mapView.Initialize(SupportFragmentManager);

        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnMenuItemSelected(int featureId, IMenuItem item)
        {
            int id = item.ItemId;

            IAirMapInterface airMapInterface = null;

            switch (id)
            {
                case Resource.Id.action_native_map:
                    try
                    {
                        airMapInterface = (IAirMapInterface)mapViewBuilder.Builder(AirMapViewTypes.Native).Build();
                    }
                    catch (Exception)
                    {
                        AppendLog("Sorry, native Google Maps are not supported by this device. " +
                          "Please make sure you have Google Play Services installed.");
                    }
                    break;
                case Resource.Id.action_mapbox_map:
                    airMapInterface = (IAirMapInterface)mapViewBuilder.Builder(AirMapViewTypes.Web).Build();
                    break;
                case Resource.Id.action_google_web_map:
                    airMapInterface = new WebAirMapViewBuilder().Build();
                    break;
                case Resource.Id.action_google_china_web_map:
                    airMapInterface = (IAirMapInterface)new WebAirMapViewBuilder().WithOptions(new GoogleChinaMapType()).Build();
                    break;
                case Resource.Id.action_clear_logs:
                    adapter.ClearLogs();
                    break;
                case Resource.Id.add_geojson_layer:
                    string getJsonString = Util.ReadFromRawResource(this, Resource.Raw.google);
                    AirMapGeoJsonLayer layer = new AirMapGeoJsonLayer.Builder(getJsonString)
                        .StrokeColor(Color.Green)
                        .StrokeWidth(10)
                        .FillColor(Color.LightGreen)
                        .Build();
                    try
                    {
                        mapView.MapInterface.SetGeoJsonLayer(layer);
                    }
                    catch (Exception e)
                    {
                        AppendLog("Failed to add GeoJson: " + e.ToString());
                    }
                    break;
                case Resource.Id.remove_geojson_layer:
                    mapView.MapInterface.ClearGeoJsonLayer();
                    break;
                case Resource.Id.take_snapshot:
                    mapView.MapInterface.GetSnapshot(new OnSnapshotReadyListener((bm) =>
                    {
                        if (bm != null)
                        {
                            AppendBitMap(bm);
                        }
                        else
                        {
                            AppendLog("Null bitmap");
                        }
                    }));
                    break;
                case Resource.Id.enable_location:
                    mapView.SetMyLocationEnable(true);
                    break;
                case Resource.Id.disable_location:
                    mapView.SetMyLocationEnable(false);
                    break;
                default: break;
            }

            if (airMapInterface != null)
            {
                mapView.Initialize(SupportFragmentManager, airMapInterface);
            }
            return true;
        }

        class OnSnapshotReadyListener : Java.Lang.Object, IOnSnapshotReadyListener
        {
            Action<Bitmap> action;
            public OnSnapshotReadyListener(Action<Bitmap> action)
            {
                this.action = action;
            }
            public void OnSnapshotReady(Bitmap p0)
            {
                action.Invoke(p0);
            }
        }

        public void OnCameraChanged(LatLng p0, int p1)
        {
            AppendLog("Map onCameraChanged triggered with lat:" + p0.Latitude + " --- lgn:" + p0.Longitude);
        }

        public void OnMapInitialized()
        {
            AppendLog("Map onMapInitialized triggered");
            LatLng airbnbLatLng = new LatLng(37.771883, -122.405224);
            var marker = new AirMapMarker.Builder()
                .Bitmap(BitmapFactory.DecodeResource(Resources, Resource.Drawable.ic_location_green))
                .Position(airbnbLatLng)
                .Rotation(45)
                .Title("Naxam Pro").Build();
            var marker2 = new AirMapMarker.Builder()
                .Bitmap(BitmapFactory.DecodeResource(Resources, Resource.Drawable.ic_location_green))
                .Position(new LatLng(37.773975, -122.40205))
                .Rotation(45)
                .Title("A17 Building").Build();
            mapView.AddMarker(marker);
            mapView.AddMarker(marker2);

            mapView.AnimateCenterZoom(airbnbLatLng, 10);
            List<LatLng> latLgns = new List<LatLng>()
            {
                new LatLng(37.77977, -122.38937),
                new LatLng(37.77811, -122.39160),
                new LatLng(37.77787, -122.38864)
            };
            mapView.AddPolyline(new AirMapPolyline(latLgns, 5));

            List<LatLng> polygonLatLgns = new List<LatLng>()
            {
                new LatLng(37.784, -122.405),
                new LatLng(37.784, -122.406),
                new LatLng(37.785, -122.406),
                new LatLng(37.785, -122.405)
            };
            mapView.AddPolygon(new AirMapPolygon.Builder().Add(new LatLng(37.784, -122.405)).StrokeWidth(3f).Build());
            mapView.DrawCircle(new LatLng(37.78443, -122.40805), 1000);
            mapView.DrawCircle(new LatLng(37.78443, -122.40805), 300, Color.White, 20, Color.Green);

        }

        public void OnMapClick(LatLng p0)
        {
            if (p0 != null)
            {
                AppendLog("Map onMapClick triggered with lat:" + p0.Latitude + ",  lng:" + p0.Longitude);
                mapView.MapInterface.GetScreenLocation(p0, this);
            }
            else
            {
                AppendLog("Map onMapClick triggered with null latLng");
            }
        }

        public void OnCameraMove()
        {
            AppendLog("Map onCameraMove triggered");
        }

        public void OnMapMarkerClick(AirMapMarker p0)
        {
            AppendLog("Map onMapMarkerClick triggered with id " + p0.Id);
        }

        public void OnGoogleMarkerDrag(Marker p0)
        {

        }

        public void OnMapMarkerDrag(long p0, LatLng p1)
        {

        }

        public void OnGoogleMarkerDragEnd(Marker p0)
        {

        }

        public void OnMapMarkerDragEnd(long p0, LatLng p1)
        {

        }

        public void OnGoogleMarkerDragStart(Marker p0)
        {

        }

        public void OnMapMarkerDragStart(long p0, LatLng p1)
        {

        }

        public void OnInfoWindowClick(AirMapMarker p0)
        {

        }

        public void OnLatLngScreenLocationReady(Point p0)
        {

        }

        public void AppendLog(string msg)
        {
            adapter.AddString(msg);
            adapter.NotifyDataSetChanged();
            logsRecyclerView.SmoothScrollToPosition(adapter.ItemCount - 1);
        }
        public void AppendBitMap(Bitmap bitmap)
        {
            adapter.AddBitmap(bitmap);
            adapter.NotifyDataSetChanged();
            logsRecyclerView.SmoothScrollToPosition(adapter.ItemCount - 1);
        }
    }
}

