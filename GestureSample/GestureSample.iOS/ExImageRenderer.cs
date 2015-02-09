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

            var exImage = Element as ExImage; //Xamarin.Forms����ExImage�ւ̃|�C���^
            //�����������o����W�F�X�`�����R�i�C�U�𐶐�����
            var gr = new UILongPressGestureRecognizer(o => exImage.OnLongPress()); //�������������������ɁAExImage��OnSLongPress���Ăяo��

            //�W�F�X�`���[���R�i�C�U�[�̒ǉ�
            AddGestureRecognizer(gr);
        }
    }
}
