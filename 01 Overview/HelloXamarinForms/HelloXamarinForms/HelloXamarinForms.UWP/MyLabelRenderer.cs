using HelloXamarinForms;
using HelloXamarinForms.UWP;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(MyLabel), typeof(MyLabelRenderer))]
namespace HelloXamarinForms.UWP
{
    public class MyLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Text = "UWP: " + Control.Text;
            }
        }
    }
}
