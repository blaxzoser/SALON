using Caliburn.Micro;
using SALON.Models;
using System.Collections.ObjectModel;

namespace SALON.ViewModels
{
    public class AddTeacherViewModel : PropertyChangedBase
    {
        private readonly ObservableCollection<ClassRoomModel> _items3;
        public ObservableCollection<ClassRoomModel> Items2 => _items3;

        string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                NotifyOfPropertyChange(() => Title);
               
            }
        }

        public AddTeacherViewModel(string title)
        {
            Title = title;
            _items3 = CreateData();
        }

        private static ObservableCollection<ClassRoomModel> CreateData()
        {
            return new ObservableCollection<ClassRoomModel>
            {
                  new ClassRoomModel
                {
                    Code="BAV",
                    Description = "Bachata Avanzada",
                    Mo = true,
                    Su=true,
                    Time= "9.00 a 10.00"
                },
                    new ClassRoomModel
                {
                    Code="SLB",
                    Description = "Sala Lineal Basica",
                    Mo = true,
                    Time= "9.00 a 10.00"
                },
                new ClassRoomModel
                {
                    Code="BA",
                    Description = "Bachata",
                    Mo = true,
                    Time= "9.00 a 10.00"
                },
                new ClassRoomModel
                {
                    Code="SB",
                    Description = "Salsa Basica",
                    Sa = true,
                    Su = true,
                    Time= "13.00 a 10.00"
                },
                new ClassRoomModel
                {
                    Code="SB2",
                    Description = "Salsa Basica 2",
                    Mo = true,
                    Tu = true,
                    Time = "12.00 a 5.00"
                }
            };
        }

    }
}
