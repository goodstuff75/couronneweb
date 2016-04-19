using System;

namespace Couronne.Core.Models.DTO
{
    public class Game
    {

        public int Id { get; set; }
        public int Player1 { get; set; }
        public int Player2 { get; set; }
        public int Winner { get; set; }
        public DateTime PlayDate { get; set; }
    }
}
