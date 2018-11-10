using System;
using System.Collections.Generic;
using System.Text;

namespace GamesBacklog.Domain.Entities
{
    public class Game
    {
        public Game() { }

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
