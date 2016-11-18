using System;
using CoreGraphics;
using Foundation;
using AppKit;
using ObjCRuntime;

namespace blogFileGenerator
{
	[Register("AppDelegate")]
	public partial class AppDelegate : NSApplicationDelegate
	{

		ViewController vc;

		public AppDelegate()
		{
			
		}

		public override void DidFinishLaunching(NSNotification notification)
		{
			// Insert code here to initialize your application
			vc = new ViewController();

		}


		public override void WillTerminate(NSNotification notification)
		{
			// Insert code here to tear down your application
		}

		public override bool ApplicationShouldTerminateAfterLastWindowClosed(NSApplication sender)
		{
			return true;
		}

		public override bool ApplicationShouldHandleReopen(NSApplication sender, bool hasVisibleWindows)
		{

			return !hasVisibleWindows;
		}
	}
}
