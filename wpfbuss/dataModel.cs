using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfbuss
{
    public class dataModel : INotifyPropertyChanged
    {
        private string yId;
        private string id;
        private DateTime date;
        private decimal amount;
        private string recorder;
        private string note;

        public string YId
        {
            get { return yId; }
            set
            {
                yId = value;
                OnPropertyChanged("YId");
            }
        }

        public string Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }

        public decimal Amount
        {
            get { return amount; }
            set
            {
                amount = value;
                OnPropertyChanged("Amount");
            }
        }

        public string Recorder
        {
            get { return recorder; }
            set
            {
                recorder = value;
                OnPropertyChanged("Recorder");
            }
        }

        public string Note
        {
            get { return note; }
            set
            {
                note = value;
                OnPropertyChanged("Note");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}

