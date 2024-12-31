using Microsoft.Maui.Controls;

namespace LearnPro
{
    public partial class CourseDetailPage : ContentPage
    {
        public CourseDetailPage(Course course)
        {
            InitializeComponent();
            BindingContext = course;
        }
        private async void OnWatchVideoClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var lecture = (CourseSectionLecture)button.CommandParameter;
            if (lecture != null && !string.IsNullOrEmpty(lecture.VideoUrl))
            {
                await Navigation.PushAsync(new VideoPage(lecture));
            }
            else
            {
                await DisplayAlert("Error", "Video URL is not available for this lecture.", "OK");
            }
        }

    }
}
