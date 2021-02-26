using System;
using System.Collections.Generic;
using MailSender.lib.ViewModels.Base;

namespace TestWPF.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        private string _Title = "Test111";

        public string Title 
        { 
            get => _Title; 
            set
            {
                _Title = value;
                OnPropertyChanged(nameof(Title));
            }
        }
    }
}
