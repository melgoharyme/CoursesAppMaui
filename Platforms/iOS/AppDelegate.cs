using Foundation;
using UIKit;

namespace LearnPro
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            // Listen for the screenshot notification
            UIKeyboard.Notifications.ObserveDidHide((sender, e) =>
            {
                if (UIScreen.MainScreen.Bounds.Contains(e.FrameEnd))
                {
                    // Perform necessary actions (e.g., show a blur or alert)
                    HandleScreenshotAttempt();
                }
            });

            return base.FinishedLaunching(app, options);
        }

        // Optional: Handle screenshot attempt (e.g., show a blur screen or alert)
        private void HandleScreenshotAttempt()
        {
            // You can present a blurred view, hide content, or trigger some other alert
            Console.WriteLine("Screenshot attempted.");
        }
    }
}
