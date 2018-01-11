using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(DrinkAndGo.Views.ARView), typeof(DrinkAndGo.iOS.AR.ARViewRenderer))]
namespace DrinkAndGo.iOS.AR
{
    public class ARViewRenderer : ViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);

            NativeView = new IOSARView();
        }
    }
}
