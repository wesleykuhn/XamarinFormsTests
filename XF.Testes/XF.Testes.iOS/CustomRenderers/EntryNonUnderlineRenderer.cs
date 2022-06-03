using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XF.Testes.CustomElements;
using XF.Testes.iOS.CustomRenderers;

[assembly: ExportRenderer(typeof(EntryNonUnderline), typeof(EntryNonUnderlineRenderer))]
namespace XF.Testes.iOS.CustomRenderers
{
    public class EntryNonUnderlineRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            EntryRemoveUnderLine();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            EntryRemoveUnderLine();
        }

        protected void EntryRemoveUnderLine()
        {
            if (Control != null)
            {
                Control.BorderStyle = UITextBorderStyle.None;
                //Control.Underline.Enabled = false;
                //Control.Underline.DisabledColor = UIColor.Clear;
                //Control.Underline.Color = UIColor.Clear;
                //Control.Underline.BackgroundColor = UIColor.Clear;
                //Control.ActiveTextInputController.UnderlineHeightActive = 0f;
                //Control.PlaceholderLabel.BackgroundColor = UIColor.Clear;
            }
        }
    }
}