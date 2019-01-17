using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfSystemManagement.Modles;

namespace WpfSystemManagement.ViewModels
{
    class UserRegisterInfoNotification : NotificationObject
    {
        private List<UserRegisterInfo> userRegisterInfoTable;

        public List<UserRegisterInfo> UserRegisterInfoTable
        {
            get { return userRegisterInfoTable; }
            set
            {
                userRegisterInfoTable = value;
                this.RaisePropertyChanged("UserRegisterInfoTable");
            }
        }

        public UserRegisterInfoNotification()
        {
            this.UserRegisterInfoTable = new List<UserRegisterInfo>
            {
                new UserRegisterInfo() { RegisterAccount="13560247425", RegisterPassword="999", ReginterDate="2019-1-17 23:39:15", RegisterStatus="Open" },
                new UserRegisterInfo() { RegisterAccount="135602474", RegisterPassword="999", ReginterDate="2019-1-17 23:39:15", RegisterStatus="Open" },
                new UserRegisterInfo() { RegisterAccount = "1356024", RegisterPassword = "999", ReginterDate = "2019-1-17 23:39:15", RegisterStatus = "Open" },
                new UserRegisterInfo() { RegisterAccount = "13560", RegisterPassword = "999", ReginterDate = "2019-1-17 23:39:15", RegisterStatus = "Open" }
            };
        }
    }
}
