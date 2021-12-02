using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfSnake.Model
{
    public class SnakePart : Figure
    {

        private bool isHead;

        public bool IsHead
        {
            get { return isHead; }
            set
            {
                isHead = value;
                OnPropertyChanged();
            }

        }
    }
}
