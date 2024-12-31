using System;
using System.Diagnostics;

namespace LearnPro
{
    public partial class MainPage : ContentPage
    {
        // Define valid license codes for checking
        private readonly string[] validLicenseCodes = { "ABC123", "XYZ456", "LMN789" };

        public MainPage()
        {
            InitializeComponent();
        }

        // Event handler for the submit button click
        private async void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            string? enteredCode = LicenseCodeEntry.Text?.Trim(); // Get the entered license code

            if (string.IsNullOrEmpty(enteredCode))
            {
                await DisplayAlert("Error", "License code cannot be empty!", "OK");
                return;
            }

            if (Array.Exists(validLicenseCodes, code => code.Equals(enteredCode, StringComparison.OrdinalIgnoreCase)))
            {
                // License code is valid, navigate to the homepage
                await Navigation.PushAsync(new HomePage()); // Navigate to HomePage
            }
            else
            {
                // License code is invalid
                await DisplayAlert("Error", "Wrong license code. Please try again!", "OK");
            }
        }

    }


}
