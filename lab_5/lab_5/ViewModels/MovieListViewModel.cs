using System.Collections.ObjectModel;
using System.Windows.Input;
using lab_5.Models;

namespace lab_5.ViewModels;

public class MovieListViewModel
{
    public ObservableCollection<MovieViewModel> Movies { get; set; }
    public ICommand DeleteMovieCommand { get; private set; }

    public MovieListViewModel()
    {
        // Тестові дані
        Movies = new ObservableCollection<MovieViewModel>
        {
            new MovieViewModel { Title = "Inception" },
            new MovieViewModel { Title = "Interstellar" },
            new MovieViewModel { Title = "The Dark Knight" }
        };

        DeleteMovieCommand = new Command<MovieViewModel>(DeleteMovie);
    }

    public void DeleteMovie(MovieViewModel movie)
    {
        if (Movies.Contains(movie))
        {
            Movies.Remove(movie);
        }
    }
}