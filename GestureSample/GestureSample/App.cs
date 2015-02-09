using Xamarin.Forms;

namespace GestureSample {
    public class App : Application {
        public App() {
            MainPage = new MyPage();

        }

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
    }

    internal class MyPage : ContentPage {
        public MyPage() {

            //タップ検出のコード
            //var image = new Image{
            //    HeightRequest = 200,
            //    Source = ImageSource.FromResource("GestureSample.Images.image01.png") 
            //};

            //var gr = new TapGestureRecognizer();
            //gr.Tapped += (s, e) =>{
            //    DisplayAlert("", "Tap", "OK");
            //};
            //image.GestureRecognizers.Add(gr); 

            //Content = new StackLayout {
            //    Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0),//iOSで上余白を確保
            //    Children = {image}
            //};

            //ロングタップ検出のコード
            var exImage = new ExImage {
                HeightRequest = 200,
                Source = ImageSource.FromResource("GestureSample.Images.image01.png")
            };

            exImage.LongPress += (s, a) => {
                DisplayAlert("", "Long Press", "OK");
            };

            Content = new StackLayout {
                Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0),//iOSで上余白を確保
                Children = {exImage}
            };
        }
    }
}