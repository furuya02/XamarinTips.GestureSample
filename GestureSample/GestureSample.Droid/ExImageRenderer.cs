using Android.Views;
using GestureSample;
using GestureSample.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ExImage), typeof(ExImageRenderer))]

namespace GestureSample.Droid {
    internal class ExImageRenderer : ImageRenderer {
        private readonly MyGestureListener _listener;
        private readonly GestureDetector _detector;

        public ExImageRenderer() {
            //リスナー(SimpleOnGestureListener)クラスを生成する
            _listener = new MyGestureListener();
            //リスナーのインスタンスを渡してGestureDetectorを生成する
            _detector = new GestureDetector(_listener);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Image> e) {
            base.OnElementChanged(e);

            _listener.ExImage = Element as ExImage; //Xamarin.Forms側のExImageへのポインタ

            //ViewのGenericMotionイベントでGestureDetectorのOnTouchEventを発生させる
            //LongPressを取得するために、GenericMotionは必要ないが、今後、その他のジェスチャにも対応できるように、こちらも追加しておく
            GenericMotion += (s, a) => _detector.OnTouchEvent(a.Event);
            //ViewのTouchイベントでGestureDetectorのOnTouchEventを発生させる
            Touch += (s, a) => _detector.OnTouchEvent(a.Event);

        }
    }
}
