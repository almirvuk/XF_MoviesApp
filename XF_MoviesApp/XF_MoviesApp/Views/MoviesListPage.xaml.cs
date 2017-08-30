using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_MoviesApp.Models;
using XF_MoviesApp.ViewModels;

namespace XF_MoviesApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MoviesListPage : ContentPage
	{
		public MoviesListPage ()
		{
			InitializeComponent ();

            BindingContext = new MoviesListViewModel();
		}

        private void OpenDetailsPage(object sender, ItemTappedEventArgs e) {

            var movie = (Movie)e.Item;

            if (movie != null)
                Navigation.PushAsync(new MovieDetailsPage(movie.MovieId));
        }
    }
}