// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace blogFileGenerator
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField fileName { get; set; }

		[Outlet]
		AppKit.NSTextField fileNameInput { get; set; }

		[Outlet]
		AppKit.NSTextField fullName { get; set; }

		[Outlet]
		AppKit.NSTextField fullNameInput { get; set; }

		[Outlet]
		AppKit.NSButton genButton { get; set; }

		[Outlet]
		AppKit.NSTextField index { get; set; }

		[Outlet]
		AppKit.NSTextField indexInput { get; set; }

		[Outlet]
		AppKit.NSTextField input { get; set; }

		[Outlet]
		AppKit.NSTextField inputInput { get; set; }

		[Outlet]
		AppKit.NSTextField returnType { get; set; }

		[Outlet]
		AppKit.NSTextField returnTypeInput { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (fileName != null) {
				fileName.Dispose ();
				fileName = null;
			}

			if (fileNameInput != null) {
				fileNameInput.Dispose ();
				fileNameInput = null;
			}

			if (fullName != null) {
				fullName.Dispose ();
				fullName = null;
			}

			if (fullNameInput != null) {
				fullNameInput.Dispose ();
				fullNameInput = null;
			}

			if (index != null) {
				index.Dispose ();
				index = null;
			}

			if (indexInput != null) {
				indexInput.Dispose ();
				indexInput = null;
			}

			if (input != null) {
				input.Dispose ();
				input = null;
			}

			if (inputInput != null) {
				inputInput.Dispose ();
				inputInput = null;
			}

			if (returnType != null) {
				returnType.Dispose ();
				returnType = null;
			}

			if (returnTypeInput != null) {
				returnTypeInput.Dispose ();
				returnTypeInput = null;
			}

			if (genButton != null) {
				genButton.Dispose ();
				genButton = null;
			}
		}
	}
}
