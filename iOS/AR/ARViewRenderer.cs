using ARKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(DrinkAndGo.Views.ARView), typeof(DrinkAndGo.iOS.AR.ARViewRenderer))]
namespace DrinkAndGo.iOS.AR
{
    public class ARViewRenderer : ViewRenderer
    {
        private IOSARView arView;

        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);

            base.OnElementChanged(e);
            if (Element == null)
            {
                return;
            }

            if (Control == null)
            {
                this.arView = new IOSARView();
                SetNativeControl(this.arView);
				this.arView.LayoutSubviews();
            }
        }
    }
}
