using Microsoft.Maui.Controls;
using MyContact = Patel8sd_ContactList.Models.Contact;

namespace Patel8sd_ContactList;

public partial class DetailsPage : ContentPage
{

    public DetailsPage(MyContact contact) // Constructor now expects MyContact
    {
        InitializeComponent();
        photoImage.Source = contact.Photo;
        nameLabel.Text = $"Name: {contact.Name}";
        emailLabel.Text = $"Email: {contact.Email}";
        phoneLabel.Text = $"Phone: {contact.PhoneNumber}";
        descriptionLabel.Text = $"Description: {contact.Description}";
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}