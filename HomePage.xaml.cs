using System.Collections.Generic;
using System.Linq;
using Microsoft.Maui.Controls;

namespace LearnPro
{
    public partial class HomePage : ContentPage
    {

        public List<Course> Courses { get; set; }

        public HomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);

            // Static data for courses and lessons
            Courses = new List<Course>
            {
               new Course
                {
                    Id = 1,
                    Title = "Mastering Python Programming",
                    Image = "python_course.png",
                    Category = "Programming",
                    DatePublished = "2023-01-01",
                    CourseSection = new List<CourseSection>
                    {
                        new CourseSection
                        {
                            Id = 1,
                            Name = "Getting Started with Python",
                            CourseSectionLectures = new List<CourseSectionLecture>
                            {
                                new CourseSectionLecture {
                                    Id = 1,
                                    Name = "Installing Python and Setting Up Your IDE",
                                    Detail = "Learn how to install Python and set up a coding environment",
                                    VideoUrl = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"
                                },
                                new CourseSectionLecture {
                                    Id = 2,
                                    Name = "Writing Your First Python Program",
                                    Detail = "Create a simple Python script and run it",
                                    VideoUrl = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"
                                },
                                new CourseSectionLecture {
                                    Id = 3,
                                    Name = "Using Comments Effectively",
                                    Detail = "Explore Python’s clean syntax and indentation rules",
                                    VideoUrl = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"
                                },
                                new CourseSectionLecture {
                                    Id = 4,
                                    Name = "Understanding Python Syntax and Indentation",
                                    Detail = "Learn to document your code with single-line and multi-line comments",
                                    VideoUrl = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"
                                }
                            }
                        },
                        new CourseSection
                        {
                            Id = 2,
                            Name = "Core Python Concepts",
                            CourseSectionLectures = new List<CourseSectionLecture>
                            {
                                new CourseSectionLecture {
                                    Id = 1,
                                    Name = "Variables and Data Types",
                                    Detail = "Understand how to declare and use variables effectively",
                                    VideoUrl = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"
                                },
                                new CourseSectionLecture {
                                    Id = 2,
                                    Name = "Control Flow Statements",
                                    Detail = "Learn how to use if, else, and loops in Python",
                                    VideoUrl = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"
                                },
                                new CourseSectionLecture {
                                    Id = 3,
                                    Name = "Python Functions",
                                    Detail = "Create reusable code blocks with Python functions",
                                    VideoUrl = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"
                                },
                                new CourseSectionLecture {
                                    Id = 4,
                                    Name = "Error Handling in Python",
                                    Detail = "Handle errors gracefully using try-except blocks",
                                    VideoUrl = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"
                                }
                            }
                        }
                    }
                },
                 new Course
                    {
                        Id = 2,
                        Title = "Full-Stack Web Development",
                        Image = "fullstack_course.png",
                        Category = "Web Development",
                        DatePublished = "2023-01-01",
                        CourseSection = new List<CourseSection>
                        {
                            new CourseSection
                            {
                                Id = 1,
                                Name = "Frontend Basics",
                                CourseSectionLectures = new List<CourseSectionLecture>
                                {
                                    new CourseSectionLecture {
                                        Id = 1,
                                        Name = "Introduction to HTML",
                                        Detail = "Learn the building blocks of web pages with HTML",
                                        VideoUrl = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"
                                    },
                                    new CourseSectionLecture {
                                        Id = 2,
                                        Name = "CSS for Styling",
                                        Detail = "Style your web pages with CSS",
                                        VideoUrl = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"
                                    },
                                    new CourseSectionLecture {
                                        Id = 3,
                                        Name = "Introduction to JavaScript",
                                        Detail = "Add interactivity to your web pages with JavaScript",
                                        VideoUrl = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"
                                    },
                                    new CourseSectionLecture {
                                        Id = 4,
                                        Name = "Responsive Design Basics",
                                        Detail = "Learn to make your websites responsive and mobile-friendly",
                                        VideoUrl = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"
                                    }
                                }
                            },
                            new CourseSection
                            {
                                Id = 2,
                                Name = "Backend Development",
                                CourseSectionLectures = new List<CourseSectionLecture>
                                {
                                    new CourseSectionLecture {
                                        Id = 1,
                                        Name = "Setting Up a Node.js Server",
                                        Detail = "Learn how to create a server with Node.js",
                                        VideoUrl = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"
                                    },
                                    new CourseSectionLecture {
                                        Id = 2,
                                        Name = "RESTful API Basics",
                                        Detail = "Build a RESTful API with Express.js",
                                        VideoUrl = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"
                                    },
                                    new CourseSectionLecture {
                                        Id = 3,
                                        Name = "Connecting to a Database",
                                        Detail = "Integrate your server with a database like MongoDB",
                                        VideoUrl = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"
                                    },
                                    new CourseSectionLecture {
                                        Id = 4,
                                        Name = "User Authentication",
                                        Detail = "Implement secure user login and authentication",
                                        VideoUrl = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"
                                    }
                                }
                            }
                        }
                    }
            };

            // Bind data to the CollectionView
            CoursesCollectionView.ItemsSource = Courses;
        }

        private async void OnViewCourseClicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var courseId = (int)button.CommandParameter;
            var course = Courses.FirstOrDefault(c => c.Id == courseId);
            if (course != null)
            {
                await Navigation.PushAsync(new CourseDetailPage(course));
            }
        }
    }

    // Course Models
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public string DatePublished { get; set; }
        public List<CourseSection> CourseSection { get; set; }
    }

    public class CourseSection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CourseSectionLecture> CourseSectionLectures { get; set; }
    }

    public class CourseSectionLecture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public string VideoUrl { get; set; }
    }
}
