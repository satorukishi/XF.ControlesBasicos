using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XF.ControlesBasicos.Model
{
    public class Email : INotifyPropertyChanged
    {
        private bool _aceitaReceber;
        public bool AceitaReceber
        {
            get { return _aceitaReceber; }
            set {
                _aceitaReceber = value;
                if (!_aceitaReceber)
                {
                    Conta = string.Empty;
                }
            }
        }

        private string _conta;
        public string Conta {
            get { return _conta; }
            set
            {
                _conta = value;
                EventPropertyChanged();
            }
        }


        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void EventPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion INotifyPropertyChanged

    }
}
