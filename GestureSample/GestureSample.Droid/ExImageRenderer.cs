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
            //���X�i�[(SimpleOnGestureListener)�N���X�𐶐�����
            _listener = new MyGestureListener();
            //���X�i�[�̃C���X�^���X��n����GestureDetector�𐶐�����
            _detector = new GestureDetector(_listener);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Image> e) {
            base.OnElementChanged(e);

            _listener.ExImage = Element as ExImage; //Xamarin.Forms����ExImage�ւ̃|�C���^

            //View��GenericMotion�C�x���g��GestureDetector��OnTouchEvent�𔭐�������
            //LongPress���擾���邽�߂ɁAGenericMotion�͕K�v�Ȃ����A����A���̑��̃W�F�X�`���ɂ��Ή��ł���悤�ɁA��������ǉ����Ă���
            GenericMotion += (s, a) => _detector.OnTouchEvent(a.Event);
            //View��Touch�C�x���g��GestureDetector��OnTouchEvent�𔭐�������
            Touch += (s, a) => _detector.OnTouchEvent(a.Event);

        }
    }
}
