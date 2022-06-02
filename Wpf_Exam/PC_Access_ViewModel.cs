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
        public string PC_Access_SSD
        {
            get { return _model.SSD; }
            set
            {
                _model.Title_Name = value;
                OnPropertyChanged("PC_Access_SSD");
            }
        }
        public string PC_Access_Cooling_systems
        {
            get { return _model.Cooling_systems; }
            set
            {
                _model.Title_Name = value;
                OnPropertyChanged("PC_Access_Cooling_systems");
            }
        }
        public string PC_Access_Video_cards
        {
            get { return _model.Video_cards; }
            set
            {
                _model.Title_Name = value;
                OnPropertyChanged("PC_Access_Video_cards");
            }
        }
        public string PC_Access_RAM
        {
            get { return _model.RAM; }
            set
            {
                _model.Title_Name = value;
                OnPropertyChanged("PC_Access_RAM");
            }
        }
        public string PC_Access_Processors
        {
            get { return _model.Processors; }
            set
            {
                _model.Title_Name = value;
                OnPropertyChanged("PC_Access_Processors");
            }
        }
        public string PC_Access_Motherboards
        {
            get { return _model.Motherboards; }
            set
            {
                _model.Title_Name = value;
                OnPropertyChanged("PC_Access_Motherboards");
            }
        }
        public string PC_Access_Hard_drives
        {
            get { return _model.Hard_drives; }
            set
            {
                _model.Title_Name = value;
                OnPropertyChanged("PC_Access_Hard_drives");
            }
        }
        public string PC_Access_Power_supplies
        {
            get { return _model.Power_supplies; }
            set
            {
                _model.Title_Name = value;
                OnPropertyChanged("PC_Access_Power_supplies");
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
