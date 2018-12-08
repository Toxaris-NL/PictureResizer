using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureResizer {
   internal class Quality: INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
        private int _Value;
        public int Value {
            get { return _Value; }
            set {
                _Value = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Value"));
            }
        }

        public Quality() {
            PropertyChanged = new PropertyChangedEventHandler(OnPropertyChanged);
            _Value = 0;
        }

        protected void OnPropertyChanged(object send, PropertyChangedEventArgs e) {
        }
    }
}
