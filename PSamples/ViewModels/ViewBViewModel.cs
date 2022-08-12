using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PSamples.ViewModels
{
    public class ViewBViewModel : BindableBase, IDialogAware
    {
        public ViewBViewModel()
        {

        }

        public string Title => "View B";

        public event Action<IDialogResult> RequestClose;

        public bool CanCloseDialog()
        {
            //throw new NotImplementedException();
            return true;
        }

        public void OnDialogClosed()
        {
            //throw new NotImplementedException();
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            //throw new NotImplementedException();
        }
    }
}
