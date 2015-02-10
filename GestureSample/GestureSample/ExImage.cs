using System;
using Xamarin.Forms;

namespace GestureSample {
    public class ExImage : Image {

        //長押しのイベントを定義する
        public event EventHandler LongPress;

        public void OnLongPress() {
            if (LongPress != null) {
                LongPress(this, new EventArgs());
            }
        }
    }
}