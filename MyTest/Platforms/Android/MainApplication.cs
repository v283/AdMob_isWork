using Android.App;
using Android.Gms.Ads;
using Android.OS;
using Plugin.MauiMTAdmob;
using Android.Runtime;


namespace MyTest;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();


}
