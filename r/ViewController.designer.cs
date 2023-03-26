// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace r
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField MainFieldStatus { get; set; }

		[Outlet]
		AppKit.NSTextField pcRandChoice { get; set; }

		[Outlet]
		AppKit.NSTextField PcScore { get; set; }

		[Outlet]
		AppKit.NSTextFieldCell UserScore { get; set; }

		[Outlet]
		AppKit.NSTextField WinLoseStatus { get; set; }

		[Action ("MainTextField:")]
		partial void MainTextField (AppKit.NSTextField sender);

		[Action ("PaperPush:")]
		partial void PaperPush (AppKit.NSButton sender);

		[Action ("ResetScorePush:")]
		partial void ResetScorePush (AppKit.NSButton sender);

		[Action ("RockPush:")]
		partial void RockPush (AppKit.NSButton sender);

		[Action ("ScissorsPush:")]
		partial void ScissorsPush (AppKit.NSButton sender);

		[Action ("StartGamePush:")]
		partial void StartGamePush (AppKit.NSButton sender);

		[Action ("StartPush:")]
		partial void StartPush (AppKit.NSButton sender);

		[Action ("WinLoseField:")]
		partial void WinLoseField (AppKit.NSTextField sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (MainFieldStatus != null) {
				MainFieldStatus.Dispose ();
				MainFieldStatus = null;
			}

			if (pcRandChoice != null) {
				pcRandChoice.Dispose ();
				pcRandChoice = null;
			}

			if (PcScore != null) {
				PcScore.Dispose ();
				PcScore = null;
			}

			if (UserScore != null) {
				UserScore.Dispose ();
				UserScore = null;
			}

			if (WinLoseStatus != null) {
				WinLoseStatus.Dispose ();
				WinLoseStatus = null;
			}
		}
	}
}
