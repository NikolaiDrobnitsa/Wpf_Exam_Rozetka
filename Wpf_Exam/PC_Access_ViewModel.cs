using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Exam
{
    public class PC_Access_ViewModel : INotifyPropertyChanged
    {
        private PC_Access _model;
        public PC_Access_ViewModel()
        {
            _model = new PC_Access { Title_Name = "Компьютерные комплектующие", SSD = "SSD", Cooling_systems = "Системы охлаждения", Video_cards = "Видеокарты", RAM = "Оперативная память", Processors = "Процессоры", Motherboards = "Материнские платы", Hard_drives = "Жесткие диски и дисковые массивы", Power_supplies = "Блоки питания" };
        }

        public string PC_Access_Title_Name
        {
            get { return _model.Title_Name; }
            set { 
                _model.Title_Name = value;
                OnPropertyChanged("PC_Access_Title_Name");
            }
        }

        
        



        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                this.PropertyChanged(this, e);
            }
        }
    }
}
