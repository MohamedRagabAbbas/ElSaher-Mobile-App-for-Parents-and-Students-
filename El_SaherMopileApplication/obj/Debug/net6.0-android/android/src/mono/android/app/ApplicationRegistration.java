package mono.android.app;

public class ApplicationRegistration {

	public static void registerApplications ()
	{
				// Application and Instrumentation ACWs must be registered first.
		mono.android.Runtime.register ("El_SaherMopileApplication.MainApplication, El_SaherMopileApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc64888107b78bc9de2c.MainApplication.class, crc64888107b78bc9de2c.MainApplication.__md_methods);
		mono.android.Runtime.register ("Microsoft.Maui.MauiApplication, Microsoft.Maui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc6488302ad6e9e4df1a.MauiApplication.class, crc6488302ad6e9e4df1a.MauiApplication.__md_methods);
		
	}
}
