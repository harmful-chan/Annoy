using MvvmApp1.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmApp1.ViewModels
{
    class MainWindowNotification : NotificationObject
    {

        private int input1;

        public int Input1
        {
            get { return input1; }
            set { input1 = value; this.RaisePropertyChanged("Input1"); }
        }
        private int input2;

        public int Input2
        {
            get { return input2; }
            set { input2 = value; this.RaisePropertyChanged("Input2");  }
        }

        private int result;

        public int Result
        {
            get { return result; }
            set { result = value; this.RaisePropertyChanged("Result"); }
        }

        public DelegateCommand addCommand { get; set; }

        public void Add(object p)
        {
            this.Result = this.Input1 + this.Input2;
        }

        public MainWindowNotification()
        {
            this.addCommand = new DelegateCommand();
            this.addCommand.ExecuteAction = new Action<object>(this.Add);
        }
    }
}
