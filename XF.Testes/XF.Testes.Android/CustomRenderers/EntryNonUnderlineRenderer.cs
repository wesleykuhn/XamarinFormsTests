using Android.Content;
using Android.Graphics.Drawables;
using Android.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XF.Testes.CustomElements;
using XF.Testes.Droid.CustomRenderers;

[assembly: ExportRenderer(typeof(EntryNonUnderline), typeof(EntryNonUnderlineRenderer))]
namespace XF.Testes.Droid.CustomRenderers
{
    public class EntryNonUnderlineRenderer : EntryRenderer
    {
        public EntryNonUnderlineRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                GradientDrawable gd = new GradientDrawable();
                gd.SetColor(Android.Graphics.Color.Transparent);

                Control.SetBackground(gd);
                Control.SetPadding(20, 0, 0, 0);

                EntryNonUnderline customEntry = (EntryNonUnderline)e.NewElement;
                if (customEntry.IsPasswordFlag)
                    Control.InputType = InputTypes.TextVariationVisiblePassword;
            }
        }
    }
}