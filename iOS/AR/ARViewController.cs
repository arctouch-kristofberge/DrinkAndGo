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
		}
    }
}
