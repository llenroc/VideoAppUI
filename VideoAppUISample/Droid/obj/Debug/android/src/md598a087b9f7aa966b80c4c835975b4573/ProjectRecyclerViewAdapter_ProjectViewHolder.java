package md598a087b9f7aa966b80c4c835975b4573;


public class ProjectRecyclerViewAdapter_ProjectViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("VideoAppUISample.Droid.Adapters.ProjectRecyclerViewAdapter+ProjectViewHolder, VideoAppUISample.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ProjectRecyclerViewAdapter_ProjectViewHolder.class, __md_methods);
	}


	public ProjectRecyclerViewAdapter_ProjectViewHolder (android.view.View p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == ProjectRecyclerViewAdapter_ProjectViewHolder.class)
			mono.android.TypeManager.Activate ("VideoAppUISample.Droid.Adapters.ProjectRecyclerViewAdapter+ProjectViewHolder, VideoAppUISample.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Views.View, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
