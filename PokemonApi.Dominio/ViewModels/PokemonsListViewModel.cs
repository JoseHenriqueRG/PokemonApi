using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApi.Domain.ViewModels
{
    public class PokemonsListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BaseExperience { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string Image { get; set; }
    }
}
