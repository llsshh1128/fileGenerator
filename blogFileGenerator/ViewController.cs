using System;

using AppKit;
using Foundation;

namespace blogFileGenerator
{
	public partial class ViewController : NSViewController
	{
		#region Constructor
		public ViewController(IntPtr handle) : base(handle)
		{
			Initialize();
		}

		public ViewController(NSCoder coder) : base(coder)
        {
			Initialize();
		}

		public ViewController() : base()
        {
			Initialize();
		}

		// Shared initialization code
		void Initialize()
		{
		}
		#endregion

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Do any additional setup after loading the view.

			string filename = "";
			string fullname = "";
			string idx = "";
			string rtType = "";
			string inputVar = "";

			genButton.Activated += (object sender, EventArgs e) => {
				filename = fileNameInput.StringValue;
				fullname = fullNameInput.StringValue;
				idx = indexInput.StringValue;
				rtType = returnTypeInput.StringValue;
				inputVar = inputInput.StringValue;

				string underName = fullname.Replace(' ', '_');

				string rstTxt = ".. _" + underName + ":\n\n" +
						"==============================\n" +
						fullname + " (" + idx + ")\n" +
						"==============================\n\n" +
						"** **\n\n" +
						"|\n\n" +
						"**Solution**\n\n" +
						".. literalinclude:: ./code/" +
						filename + ".java\n" +
						"   :language: java\n" +
						"   :linenos:";

				System.IO.File.WriteAllText(@"/Users/yummyelaine/ucsc/ams209/webpage/lc/fb/" + filename + ".rst", rstTxt);

				string javaTxt = "public class Solution { \n\tpublic " + rtType + " " + filename + "(" + inputVar + ") {" + "\n\n\t}\n}";

				System.IO.File.WriteAllText(@"/Users/yummyelaine/ucsc/ams209/webpage/lc/fb/code/" + filename + ".java", javaTxt);
			};
		}

		public override NSObject RepresentedObject
		{
			get
			{
				return base.RepresentedObject;
			}
			set
			{
				base.RepresentedObject = value;
				// Update the view, if already loaded.

			}
		}
	}
}
