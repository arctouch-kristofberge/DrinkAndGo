using System;
using ARKit;
using SceneKit;
using UIKit;
namespace DrinkAndGo.iOS.AR
{
    public class ARViewController : UIViewController
    {
			
        public ARViewController()
        {
        }


		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			ARSCNView SceneView = (View as ARSCNView);

			// Create a new scene
			var scene = SCNScene.FromFile("art.scnassets/Pokemon");

			// Set the scene to the view
			SceneView.Scene = scene;

			SceneView.Session.Delegate = new ARViewSessionDelegate();
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
			// Create a session configuration
			ARSCNView SceneView = (View as ARSCNView);
			var configuration = new ARWorldTrackingConfiguration
			{
				PlaneDetection = ARPlaneDetection.Horizontal,
				LightEstimationEnabled = true
			};

			// Run the view's session
			SceneView.Session.Run(configuration, ARSessionRunOptions.ResetTracking);

			// Find the ship and position it just in front of the camera
			var bulba = SceneView.Scene.RootNode.FindChildNode("bulba", true);

			bulba.Position = new SCNVector3(2f, -2f, -9f);
		}

		public override void ViewWillDisappear(bool animated)
		{
			base.ViewWillDisappear(animated);
			ARSCNView SceneView = (View as ARSCNView);
			SceneView.Session.Pause();
		}
    }
}
