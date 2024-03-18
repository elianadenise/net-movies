using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using tutorial_mvc_net.Models;

namespace tutorial_mvc_net.Models;

public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }
}