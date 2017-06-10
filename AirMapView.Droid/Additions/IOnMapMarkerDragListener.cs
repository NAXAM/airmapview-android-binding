//using System;
//using System.Collections.Generic;
//using Android.Runtime;

//namespace Com.Airbnb.Android.Airmapview.Listeners
//{

//    // Metadata.xml XPath interface reference: path="/api/package[@name='com.airbnb.android.airmapview.listeners']/interface[@name='OnMapMarkerDragListener']"
//    [Register("com/airbnb/android/airmapview/listeners/OnMapMarkerDragListener", "", "Com.Airbnb.Android.Airmapview.Listeners.IOnMapMarkerDragListenerInvoker")]
//    public partial interface IOnMapMarkerDragListener : IJavaObject
//    {

//        //// Metadata.xml XPath method reference: path="/api/package[@name='com.airbnb.android.airmapview.listeners']/interface[@name='OnMapMarkerDragListener']/method[@name='onMapMarkerDrag' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.maps.model.Marker']]"
//        //[Register("onMapMarkerDrag", "(Lcom/google/android/gms/maps/model/Marker;)V", "GetOnMapMarkerDrag_Lcom_google_android_gms_maps_model_Marker_Handler:Com.Airbnb.Android.Airmapview.Listeners.IOnMapMarkerDragListenerInvoker, AirMapViewBinding")]
//        //void OnMapMarkerDrag(global::Android.Gms.Maps.Model.Marker p0);

//        // Metadata.xml XPath method reference: path="/api/package[@name='com.airbnb.android.airmapview.listeners']/interface[@name='OnMapMarkerDragListener']/method[@name='onMapMarkerDrag' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.google.android.gms.maps.model.LatLng']]"
//        [Register("onMapMarkerDrag", "(JLcom/google/android/gms/maps/model/LatLng;)V", "GetOnMapMarkerDrag_JLcom_google_android_gms_maps_model_LatLng_Handler:Com.Airbnb.Android.Airmapview.Listeners.IOnMapMarkerDragListenerInvoker, AirMapViewBinding")]
//        void OnMapMarkerDrag(long p0, global::Android.Gms.Maps.Model.LatLng p1);

//        //// Metadata.xml XPath method reference: path="/api/package[@name='com.airbnb.android.airmapview.listeners']/interface[@name='OnMapMarkerDragListener']/method[@name='onMapMarkerDragEnd' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.maps.model.Marker']]"
//        //[Register("onMapMarkerDragEnd", "(Lcom/google/android/gms/maps/model/Marker;)V", "GetOnMapMarkerDragEnd_Lcom_google_android_gms_maps_model_Marker_Handler:Com.Airbnb.Android.Airmapview.Listeners.IOnMapMarkerDragListenerInvoker, AirMapViewBinding")]
//        //void OnMapMarkerDragEnd(global::Android.Gms.Maps.Model.Marker p0);

//        // Metadata.xml XPath method reference: path="/api/package[@name='com.airbnb.android.airmapview.listeners']/interface[@name='OnMapMarkerDragListener']/method[@name='onMapMarkerDragEnd' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.google.android.gms.maps.model.LatLng']]"
//        [Register("onMapMarkerDragEnd", "(JLcom/google/android/gms/maps/model/LatLng;)V", "GetOnMapMarkerDragEnd_JLcom_google_android_gms_maps_model_LatLng_Handler:Com.Airbnb.Android.Airmapview.Listeners.IOnMapMarkerDragListenerInvoker, AirMapViewBinding")]
//        void OnMapMarkerDragEnd(long p0, global::Android.Gms.Maps.Model.LatLng p1);

//        //// Metadata.xml XPath method reference: path="/api/package[@name='com.airbnb.android.airmapview.listeners']/interface[@name='OnMapMarkerDragListener']/method[@name='onMapMarkerDragStart' and count(parameter)=1 and parameter[1][@type='com.google.android.gms.maps.model.Marker']]"
//        //[Register("onMapMarkerDragStart", "(Lcom/google/android/gms/maps/model/Marker;)V", "GetOnMapMarkerDragStart_Lcom_google_android_gms_maps_model_Marker_Handler:Com.Airbnb.Android.Airmapview.Listeners.IOnMapMarkerDragListenerInvoker, AirMapViewBinding")]
//        //void OnMapMarkerDragStart(global::Android.Gms.Maps.Model.Marker p0);

//        // Metadata.xml XPath method reference: path="/api/package[@name='com.airbnb.android.airmapview.listeners']/interface[@name='OnMapMarkerDragListener']/method[@name='onMapMarkerDragStart' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.google.android.gms.maps.model.LatLng']]"
//        [Register("onMapMarkerDragStart", "(JLcom/google/android/gms/maps/model/LatLng;)V", "GetOnMapMarkerDragStart_JLcom_google_android_gms_maps_model_LatLng_Handler:Com.Airbnb.Android.Airmapview.Listeners.IOnMapMarkerDragListenerInvoker, AirMapViewBinding")]
//        void OnMapMarkerDragStart(long p0, global::Android.Gms.Maps.Model.LatLng p1);

//    }

//    [global::Android.Runtime.Register("com/airbnb/android/airmapview/listeners/OnMapMarkerDragListener", DoNotGenerateAcw = true)]
//    internal class IOnMapMarkerDragListenerInvoker : global::Java.Lang.Object, IOnMapMarkerDragListener
//    {

//        static IntPtr java_class_ref = JNIEnv.FindClass("com/airbnb/android/airmapview/listeners/OnMapMarkerDragListener");

//        protected override IntPtr ThresholdClass
//        {
//            get { return class_ref; }
//        }

//        protected override global::System.Type ThresholdType
//        {
//            get { return typeof(IOnMapMarkerDragListenerInvoker); }
//        }

//        IntPtr class_ref;

//        public static IOnMapMarkerDragListener GetObject(IntPtr handle, JniHandleOwnership transfer)
//        {
//            return global::Java.Lang.Object.GetObject<IOnMapMarkerDragListener>(handle, transfer);
//        }

//        static IntPtr Validate(IntPtr handle)
//        {
//            if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
//                throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
//                            JNIEnv.GetClassNameFromInstance(handle), "com.airbnb.android.airmapview.listeners.OnMapMarkerDragListener"));
//            return handle;
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (this.class_ref != IntPtr.Zero)
//                JNIEnv.DeleteGlobalRef(this.class_ref);
//            this.class_ref = IntPtr.Zero;
//            base.Dispose(disposing);
//        }

//        public IOnMapMarkerDragListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
//        {
//            IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
//            this.class_ref = JNIEnv.NewGlobalRef(local_ref);
//            JNIEnv.DeleteLocalRef(local_ref);
//        }

//        static Delegate cb_onMapMarkerDrag_Lcom_google_android_gms_maps_model_Marker_;
//#pragma warning disable 0169
//        static Delegate GetOnMapMarkerDrag_Lcom_google_android_gms_maps_model_Marker_Handler()
//        {
//            if (cb_onMapMarkerDrag_Lcom_google_android_gms_maps_model_Marker_ == null)
//                cb_onMapMarkerDrag_Lcom_google_android_gms_maps_model_Marker_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnMapMarkerDrag_Lcom_google_android_gms_maps_model_Marker_);
//            return cb_onMapMarkerDrag_Lcom_google_android_gms_maps_model_Marker_;
//        }

//        static void n_OnMapMarkerDrag_Lcom_google_android_gms_maps_model_Marker_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//        {
//            global::Com.Airbnb.Android.Airmapview.Listeners.IOnMapMarkerDragListener __this = global::Java.Lang.Object.GetObject<global::Com.Airbnb.Android.Airmapview.Listeners.IOnMapMarkerDragListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//            global::Android.Gms.Maps.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.Marker>(native_p0, JniHandleOwnership.DoNotTransfer);
//            __this.OnMapMarkerDrag(p0);
//        }
//#pragma warning restore 0169

//        IntPtr id_onMapMarkerDrag_Lcom_google_android_gms_maps_model_Marker_;
//        public unsafe void OnMapMarkerDrag(global::Android.Gms.Maps.Model.Marker p0)
//        {
//            if (id_onMapMarkerDrag_Lcom_google_android_gms_maps_model_Marker_ == IntPtr.Zero)
//                id_onMapMarkerDrag_Lcom_google_android_gms_maps_model_Marker_ = JNIEnv.GetMethodID(class_ref, "onMapMarkerDrag", "(Lcom/google/android/gms/maps/model/Marker;)V");
//            JValue* __args = stackalloc JValue[1];
//            __args[0] = new JValue(p0);
//            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onMapMarkerDrag_Lcom_google_android_gms_maps_model_Marker_, __args);
//        }

//        static Delegate cb_onMapMarkerDrag_JLcom_google_android_gms_maps_model_LatLng_;
//#pragma warning disable 0169
//        static Delegate GetOnMapMarkerDrag_JLcom_google_android_gms_maps_model_LatLng_Handler()
//        {
//            if (cb_onMapMarkerDrag_JLcom_google_android_gms_maps_model_LatLng_ == null)
//                cb_onMapMarkerDrag_JLcom_google_android_gms_maps_model_LatLng_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, long, IntPtr>)n_OnMapMarkerDrag_JLcom_google_android_gms_maps_model_LatLng_);
//            return cb_onMapMarkerDrag_JLcom_google_android_gms_maps_model_LatLng_;
//        }

//        static void n_OnMapMarkerDrag_JLcom_google_android_gms_maps_model_LatLng_(IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
//        {
//            global::Com.Airbnb.Android.Airmapview.Listeners.IOnMapMarkerDragListener __this = global::Java.Lang.Object.GetObject<global::Com.Airbnb.Android.Airmapview.Listeners.IOnMapMarkerDragListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//            global::Android.Gms.Maps.Model.LatLng p1 = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLng>(native_p1, JniHandleOwnership.DoNotTransfer);
//            __this.OnMapMarkerDrag(p0, p1);
//        }
//#pragma warning restore 0169

//        IntPtr id_onMapMarkerDrag_JLcom_google_android_gms_maps_model_LatLng_;
//        public unsafe void OnMapMarkerDrag(long p0, global::Android.Gms.Maps.Model.LatLng p1)
//        {
//            if (id_onMapMarkerDrag_JLcom_google_android_gms_maps_model_LatLng_ == IntPtr.Zero)
//                id_onMapMarkerDrag_JLcom_google_android_gms_maps_model_LatLng_ = JNIEnv.GetMethodID(class_ref, "onMapMarkerDrag", "(JLcom/google/android/gms/maps/model/LatLng;)V");
//            JValue* __args = stackalloc JValue[2];
//            __args[0] = new JValue(p0);
//            __args[1] = new JValue(p1);
//            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onMapMarkerDrag_JLcom_google_android_gms_maps_model_LatLng_, __args);
//        }

//        static Delegate cb_onMapMarkerDragEnd_Lcom_google_android_gms_maps_model_Marker_;
//#pragma warning disable 0169
//        static Delegate GetOnMapMarkerDragEnd_Lcom_google_android_gms_maps_model_Marker_Handler()
//        {
//            if (cb_onMapMarkerDragEnd_Lcom_google_android_gms_maps_model_Marker_ == null)
//                cb_onMapMarkerDragEnd_Lcom_google_android_gms_maps_model_Marker_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnMapMarkerDragEnd_Lcom_google_android_gms_maps_model_Marker_);
//            return cb_onMapMarkerDragEnd_Lcom_google_android_gms_maps_model_Marker_;
//        }

//        static void n_OnMapMarkerDragEnd_Lcom_google_android_gms_maps_model_Marker_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//        {
//            global::Com.Airbnb.Android.Airmapview.Listeners.IOnMapMarkerDragListener __this = global::Java.Lang.Object.GetObject<global::Com.Airbnb.Android.Airmapview.Listeners.IOnMapMarkerDragListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//            global::Android.Gms.Maps.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.Marker>(native_p0, JniHandleOwnership.DoNotTransfer);
//            __this.OnMapMarkerDragEnd(p0);
//        }
//#pragma warning restore 0169

//        IntPtr id_onMapMarkerDragEnd_Lcom_google_android_gms_maps_model_Marker_;
//        public unsafe void OnMapMarkerDragEnd(global::Android.Gms.Maps.Model.Marker p0)
//        {
//            if (id_onMapMarkerDragEnd_Lcom_google_android_gms_maps_model_Marker_ == IntPtr.Zero)
//                id_onMapMarkerDragEnd_Lcom_google_android_gms_maps_model_Marker_ = JNIEnv.GetMethodID(class_ref, "onMapMarkerDragEnd", "(Lcom/google/android/gms/maps/model/Marker;)V");
//            JValue* __args = stackalloc JValue[1];
//            __args[0] = new JValue(p0);
//            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onMapMarkerDragEnd_Lcom_google_android_gms_maps_model_Marker_, __args);
//        }

//        static Delegate cb_onMapMarkerDragEnd_JLcom_google_android_gms_maps_model_LatLng_;
//#pragma warning disable 0169
//        static Delegate GetOnMapMarkerDragEnd_JLcom_google_android_gms_maps_model_LatLng_Handler()
//        {
//            if (cb_onMapMarkerDragEnd_JLcom_google_android_gms_maps_model_LatLng_ == null)
//                cb_onMapMarkerDragEnd_JLcom_google_android_gms_maps_model_LatLng_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, long, IntPtr>)n_OnMapMarkerDragEnd_JLcom_google_android_gms_maps_model_LatLng_);
//            return cb_onMapMarkerDragEnd_JLcom_google_android_gms_maps_model_LatLng_;
//        }

//        static void n_OnMapMarkerDragEnd_JLcom_google_android_gms_maps_model_LatLng_(IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
//        {
//            global::Com.Airbnb.Android.Airmapview.Listeners.IOnMapMarkerDragListener __this = global::Java.Lang.Object.GetObject<global::Com.Airbnb.Android.Airmapview.Listeners.IOnMapMarkerDragListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//            global::Android.Gms.Maps.Model.LatLng p1 = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLng>(native_p1, JniHandleOwnership.DoNotTransfer);
//            __this.OnMapMarkerDragEnd(p0, p1);
//        }
//#pragma warning restore 0169

//        IntPtr id_onMapMarkerDragEnd_JLcom_google_android_gms_maps_model_LatLng_;
//        public unsafe void OnMapMarkerDragEnd(long p0, global::Android.Gms.Maps.Model.LatLng p1)
//        {
//            if (id_onMapMarkerDragEnd_JLcom_google_android_gms_maps_model_LatLng_ == IntPtr.Zero)
//                id_onMapMarkerDragEnd_JLcom_google_android_gms_maps_model_LatLng_ = JNIEnv.GetMethodID(class_ref, "onMapMarkerDragEnd", "(JLcom/google/android/gms/maps/model/LatLng;)V");
//            JValue* __args = stackalloc JValue[2];
//            __args[0] = new JValue(p0);
//            __args[1] = new JValue(p1);
//            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onMapMarkerDragEnd_JLcom_google_android_gms_maps_model_LatLng_, __args);
//        }

//        static Delegate cb_onMapMarkerDragStart_Lcom_google_android_gms_maps_model_Marker_;
//#pragma warning disable 0169
//        static Delegate GetOnMapMarkerDragStart_Lcom_google_android_gms_maps_model_Marker_Handler()
//        {
//            if (cb_onMapMarkerDragStart_Lcom_google_android_gms_maps_model_Marker_ == null)
//                cb_onMapMarkerDragStart_Lcom_google_android_gms_maps_model_Marker_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnMapMarkerDragStart_Lcom_google_android_gms_maps_model_Marker_);
//            return cb_onMapMarkerDragStart_Lcom_google_android_gms_maps_model_Marker_;
//        }

//        static void n_OnMapMarkerDragStart_Lcom_google_android_gms_maps_model_Marker_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
//        {
//            global::Com.Airbnb.Android.Airmapview.Listeners.IOnMapMarkerDragListener __this = global::Java.Lang.Object.GetObject<global::Com.Airbnb.Android.Airmapview.Listeners.IOnMapMarkerDragListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//            global::Android.Gms.Maps.Model.Marker p0 = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.Marker>(native_p0, JniHandleOwnership.DoNotTransfer);
//            __this.OnMapMarkerDragStart(p0);
//        }
//#pragma warning restore 0169

//        IntPtr id_onMapMarkerDragStart_Lcom_google_android_gms_maps_model_Marker_;
//        public unsafe void OnMapMarkerDragStart(global::Android.Gms.Maps.Model.Marker p0)
//        {
//            if (id_onMapMarkerDragStart_Lcom_google_android_gms_maps_model_Marker_ == IntPtr.Zero)
//                id_onMapMarkerDragStart_Lcom_google_android_gms_maps_model_Marker_ = JNIEnv.GetMethodID(class_ref, "onMapMarkerDragStart", "(Lcom/google/android/gms/maps/model/Marker;)V");
//            JValue* __args = stackalloc JValue[1];
//            __args[0] = new JValue(p0);
//            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onMapMarkerDragStart_Lcom_google_android_gms_maps_model_Marker_, __args);
//        }

//        static Delegate cb_onMapMarkerDragStart_JLcom_google_android_gms_maps_model_LatLng_;
//#pragma warning disable 0169
//        static Delegate GetOnMapMarkerDragStart_JLcom_google_android_gms_maps_model_LatLng_Handler()
//        {
//            if (cb_onMapMarkerDragStart_JLcom_google_android_gms_maps_model_LatLng_ == null)
//                cb_onMapMarkerDragStart_JLcom_google_android_gms_maps_model_LatLng_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, long, IntPtr>)n_OnMapMarkerDragStart_JLcom_google_android_gms_maps_model_LatLng_);
//            return cb_onMapMarkerDragStart_JLcom_google_android_gms_maps_model_LatLng_;
//        }

//        static void n_OnMapMarkerDragStart_JLcom_google_android_gms_maps_model_LatLng_(IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
//        {
//            global::Com.Airbnb.Android.Airmapview.Listeners.IOnMapMarkerDragListener __this = global::Java.Lang.Object.GetObject<global::Com.Airbnb.Android.Airmapview.Listeners.IOnMapMarkerDragListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
//            global::Android.Gms.Maps.Model.LatLng p1 = global::Java.Lang.Object.GetObject<global::Android.Gms.Maps.Model.LatLng>(native_p1, JniHandleOwnership.DoNotTransfer);
//            __this.OnMapMarkerDragStart(p0, p1);
//        }
//#pragma warning restore 0169

//        IntPtr id_onMapMarkerDragStart_JLcom_google_android_gms_maps_model_LatLng_;
//        public unsafe void OnMapMarkerDragStart(long p0, global::Android.Gms.Maps.Model.LatLng p1)
//        {
//            if (id_onMapMarkerDragStart_JLcom_google_android_gms_maps_model_LatLng_ == IntPtr.Zero)
//                id_onMapMarkerDragStart_JLcom_google_android_gms_maps_model_LatLng_ = JNIEnv.GetMethodID(class_ref, "onMapMarkerDragStart", "(JLcom/google/android/gms/maps/model/LatLng;)V");
//            JValue* __args = stackalloc JValue[2];
//            __args[0] = new JValue(p0);
//            __args[1] = new JValue(p1);
//            JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onMapMarkerDragStart_JLcom_google_android_gms_maps_model_LatLng_, __args);
//        }

//    }

//    public partial class MapMarkerDragEventArgs : global::System.EventArgs
//    {

//        public MapMarkerDragEventArgs(global::Android.Gms.Maps.Model.Marker p0)
//        {
//            this.p0 = p0;
//        }

//        global::Android.Gms.Maps.Model.Marker p0;
//        public global::Android.Gms.Maps.Model.Marker P0
//        {
//            get { return p0; }
//        }
//    }

//    public partial class
//    MapMarkerDrag2EventArgs
//   : global::System.EventArgs
//    {

//        public
//    MapMarkerDrag2EventArgs
//   (long p0, global::Android.Gms.Maps.Model.LatLng p1)
//        {
//            this.p0 = p0;
//            this.p1 = p1;
//        }

//        long p0;
//        public long P0
//        {
//            get { return p0; }
//        }

//        global::Android.Gms.Maps.Model.LatLng p1;
//        public global::Android.Gms.Maps.Model.LatLng P1
//        {
//            get { return p1; }
//        }
//    }

//    public partial class MapMarkerDragEndEventArgs : global::System.EventArgs
//    {

//        public MapMarkerDragEndEventArgs(global::Android.Gms.Maps.Model.Marker p0)
//        {
//            this.p0 = p0;
//        }

//        global::Android.Gms.Maps.Model.Marker p0;
//        public global::Android.Gms.Maps.Model.Marker P0
//        {
//            get { return p0; }
//        }
//    }

//    public partial class
//    MapMarkerDragEnd2EventArgs
//   : global::System.EventArgs
//    {

//        public
//    MapMarkerDragEnd2EventArgs
//   (long p0, global::Android.Gms.Maps.Model.LatLng p1)
//        {
//            this.p0 = p0;
//            this.p1 = p1;
//        }

//        long p0;
//        public long P0
//        {
//            get { return p0; }
//        }

//        global::Android.Gms.Maps.Model.LatLng p1;
//        public global::Android.Gms.Maps.Model.LatLng P1
//        {
//            get { return p1; }
//        }
//    }

//    public partial class MapMarkerDragStartEventArgs : global::System.EventArgs
//    {

//        public MapMarkerDragStartEventArgs(global::Android.Gms.Maps.Model.Marker p0)
//        {
//            this.p0 = p0;
//        }

//        global::Android.Gms.Maps.Model.Marker p0;
//        public global::Android.Gms.Maps.Model.Marker P0
//        {
//            get { return p0; }
//        }
//    }

//    public partial class
//    MapMarkerDragStart2EventArgs
//   : global::System.EventArgs
//    {

//        public
//    MapMarkerDragStart2EventArgs
//   (long p0, global::Android.Gms.Maps.Model.LatLng p1)
//        {
//            this.p0 = p0;
//            this.p1 = p1;
//        }

//        long p0;
//        public long P0
//        {
//            get { return p0; }
//        }

//        global::Android.Gms.Maps.Model.LatLng p1;
//        public global::Android.Gms.Maps.Model.LatLng P1
//        {
//            get { return p1; }
//        }
//    }

//    [global::Android.Runtime.Register("mono/com/airbnb/android/airmapview/listeners/OnMapMarkerDragListenerImplementor")]
//    internal sealed partial class IOnMapMarkerDragListenerImplementor : global::Java.Lang.Object, IOnMapMarkerDragListener
//    {

//        object sender;

//        public IOnMapMarkerDragListenerImplementor(object sender)
//            : base(
//                global::Android.Runtime.JNIEnv.StartCreateInstance("mono/com/airbnb/android/airmapview/listeners/OnMapMarkerDragListenerImplementor", "()V"),
//                JniHandleOwnership.TransferLocalRef)
//        {
//            global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
//            this.sender = sender;
//        }

//#pragma warning disable 0649
//        public EventHandler<MapMarkerDragEventArgs> OnMapMarkerDragHandler;
//#pragma warning restore 0649

//        public void OnMapMarkerDrag(global::Android.Gms.Maps.Model.Marker p0)
//        {
//            var __h = OnMapMarkerDragHandler;
//            if (__h != null)
//                __h(sender, new MapMarkerDragEventArgs(p0));
//        }
//#pragma warning disable 0649
//        public EventHandler<
//    MapMarkerDrag2EventArgs
//  > OnMapMarkerDragHandler2;
//#pragma warning restore 0649

//        public void OnMapMarkerDrag(long p0, global::Android.Gms.Maps.Model.LatLng p1)
//        {
//            var __h = OnMapMarkerDragHandler2;
//            if (__h != null)
//                __h(sender, new
//    MapMarkerDrag2EventArgs
//   (p0, p1));
//        }
//#pragma warning disable 0649
//        public EventHandler<MapMarkerDragEndEventArgs> OnMapMarkerDragEndHandler;
//#pragma warning restore 0649

//        public void OnMapMarkerDragEnd(global::Android.Gms.Maps.Model.Marker p0)
//        {
//            var __h = OnMapMarkerDragEndHandler;
//            if (__h != null)
//                __h(sender, new MapMarkerDragEndEventArgs(p0));
//        }
//#pragma warning disable 0649
//        public EventHandler<
//    MapMarkerDragEnd2EventArgs
//  > OnMapMarkerDragEndHandler2;
//#pragma warning restore 0649

//        public void OnMapMarkerDragEnd(long p0, global::Android.Gms.Maps.Model.LatLng p1)
//        {
//            var __h = OnMapMarkerDragEndHandler2;
//            if (__h != null)
//                __h(sender, new
//    MapMarkerDragEnd2EventArgs
//   (p0, p1));
//        }
//#pragma warning disable 0649
//        public EventHandler<MapMarkerDragStartEventArgs> OnMapMarkerDragStartHandler;
//#pragma warning restore 0649

//        public void OnMapMarkerDragStart(global::Android.Gms.Maps.Model.Marker p0)
//        {
//            var __h = OnMapMarkerDragStartHandler;
//            if (__h != null)
//                __h(sender, new MapMarkerDragStartEventArgs(p0));
//        }
//#pragma warning disable 0649
//        public EventHandler<
//    MapMarkerDragStart2EventArgs
//  > OnMapMarkerDragStartHandler2;
//#pragma warning restore 0649

//        public void OnMapMarkerDragStart(long p0, global::Android.Gms.Maps.Model.LatLng p1)
//        {
//            var __h = OnMapMarkerDragStartHandler2;
//            if (__h != null)
//                __h(sender, new
//    MapMarkerDragStart2EventArgs
//   (p0, p1));
//        }

//        internal static bool __IsEmpty(IOnMapMarkerDragListenerImplementor value)
//        {
//            return value.OnMapMarkerDragHandler == null && value.OnMapMarkerDragHandler == null && value.OnMapMarkerDragEndHandler == null && value.OnMapMarkerDragEndHandler == null && value.OnMapMarkerDragStartHandler == null && value.OnMapMarkerDragStartHandler == null;
//        }
//    }

//}
