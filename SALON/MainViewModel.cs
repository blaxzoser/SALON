using Caliburn.Micro;
using SALON.ViewModels;

namespace SALON
{
    public class MainViewModel : Conductor<IScreen>.Collection.OneActive
    {
        string message;

        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                NotifyOfPropertyChange(() => message);               
            }
        }


        bool isShowMessage;
        public bool IsShowMessage
        {
            get { return isShowMessage; }
            set
            {
                isShowMessage = value;
                NotifyOfPropertyChange(() => message);
            }
        }

       public MainViewModel()
        {
            Message = "Bienvenido";
            isShowMessage = true;
        }


        public void ShowTeachers()
        {
            ActivateItem(new TeacherViewModel());
        }

    }
}
