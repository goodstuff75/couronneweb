using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Couronne.Core.Models.DTO;

namespace CouronneWeb.ViewModels
{
    public class HomeViewModel
    {
        public List<Player> TopPlayersYear { get; set; }
        public List<Player> TopPlayersMonth { get; set; }

    }
}
