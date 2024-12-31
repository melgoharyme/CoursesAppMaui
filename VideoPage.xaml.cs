namespace LearnPro;

public partial class VideoPage : ContentPage
{
    public VideoPage(CourseSectionLecture lecture)
    {
        InitializeComponent();
        BindingContext = lecture;
    }
}