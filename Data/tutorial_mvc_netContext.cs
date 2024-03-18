using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tutorial_mvc_net.Models;

namespace tutorial_mvc_net.Data
{
    public class tutorial_mvc_netContext : DbContext
    {
        public tutorial_mvc_netContext (DbContextOptions<tutorial_mvc_netContext> options)
            : base(options)
        {
        }

        public DbSet<tutorial_mvc_net.Models.Movie> Movie { get; set; } = default!; // representa las películas de la base de datos
    }
}
