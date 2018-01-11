using System;
using ARKit;

namespace DrinkAndGo.iOS.AR
{
	public class ARViewSessionDelegate : ARSessionDelegate
	{
		public ARViewSessionDelegate()
		{
		}

		public override void CameraDidChangeTrackingState(ARSession session, ARCamera camera)
		{
			Console.WriteLine("{0} {1}", camera.TrackingState, camera.TrackingStateReason);
		}
	}
}
