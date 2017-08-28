using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_MoviesApp.Views {

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage : ContentPage {

        public TestPage() {
            InitializeComponent();
        }

        private void SetLabelContent(object sender, EventArgs e) {

            labelFullName.Text = entryFName.Text + " " + entryLName.Text;

            labelFullName.IsVisible = true;
        }

        private void HideLabel(object sender, TextChangedEventArgs e) {
            labelFullName.IsVisible = false;
        }
    }
}