using GestureSample;
using GestureSample.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ExImage), typeof(ExImageRenderer))]

namespace GestureSample.iOS {
    internal class ExImageRenderer : ImageRenderer {
        protected override void OnElementChanged(ElementChangedEventArgs<Image> e) {
            base.OnElementChanged(e);

            var exImage = Element as ExImage; //Xamarin.Forms側のExImageへのポインタ
            //長押しを検出するジェスチャレコナイザを生成する
            var gr = new UILongPressGestureRecognizer(o => exImage.OnLongPress()); //長押しが発生した時に、ExImageのOnSLongPressを呼び出す

            //ジェスチャーレコナイザーの追加
            AddGestureRecognizer(gr);
        }
    }
}
