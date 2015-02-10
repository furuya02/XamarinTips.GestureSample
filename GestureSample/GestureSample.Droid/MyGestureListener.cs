using Android.Views;

namespace GestureSample.Droid {
    internal class MyGestureListener : GestureDetector.SimpleOnGestureListener {

        public ExImage ExImage { private get; set; } //Xamarin.Forms����ExImage�ւ̃|�C���^

        public override void OnLongPress(MotionEvent e) {
            base.OnLongPress(e);
            if (ExImage != null) {
                ExImage.OnLongPress(); //Xamarin.Forms����ExImage��OnLongPress()���Ăяo��
            }
        }
    }
}

