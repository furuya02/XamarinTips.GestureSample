using Android.Views;

namespace GestureSample.Droid {
    internal class MyGestureListener : GestureDetector.SimpleOnGestureListener {

        public ExImage ExImage { private get; set; } //Xamarin.Forms側のExImageへのポインタ

        public override void OnLongPress(MotionEvent e) {
            base.OnLongPress(e);
            if (ExImage != null) {
                ExImage.OnLongPress(); //Xamarin.Forms側のExImageのOnLongPress()を呼び出す
            }
        }
    }
}

