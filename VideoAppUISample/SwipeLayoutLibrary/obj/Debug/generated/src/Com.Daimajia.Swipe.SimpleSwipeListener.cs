using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Daimajia.Swipe {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SimpleSwipeListener']"
	[global::Android.Runtime.Register ("com/daimajia/swipe/SimpleSwipeListener", DoNotGenerateAcw=true)]
	public partial class SimpleSwipeListener : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/daimajia/swipe/SimpleSwipeListener", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleSwipeListener); }
		}

		protected SimpleSwipeListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.daimajia.swipe']/class[@name='SimpleSwipeListener']/constructor[@name='SimpleSwipeListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SimpleSwipeListener ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SimpleSwipeListener)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
