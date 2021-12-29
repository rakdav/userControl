using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userControl.ViewModel
{
    public class PlayerViewModel
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public PlayerViewModel(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public override string ToString() => $"{Name}(#{Number})";
    }
}
