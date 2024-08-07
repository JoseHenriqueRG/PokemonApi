using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApi.Domain.ViewModels
{
    public class ActionResult<T> where T : class
    {
        public bool IsValid { get; set; }
        public string Message { get; set; }
        public T Item { get; set; }
        public IList<T> Items { get; set; }
    }
}
