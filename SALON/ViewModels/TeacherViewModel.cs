using Caliburn.Micro;
using MaterialDesignThemes.Wpf;
using SALON.Commands;
using SALON.Views;
using System;
using System.Windows.Input;

namespace SALON.ViewModels
{
    public class TeacherViewModel : Screen
    {
        protected override void OnActivate()
        {         
            base.OnActivate();
        }

        public void AddTeacher()
        {
            IWindowManager manager = new WindowManager();
            manager.ShowDialog(new ViewModels.AddTeacherViewModel("Nuevo Maestro"), null, null);
        }
    }
}
