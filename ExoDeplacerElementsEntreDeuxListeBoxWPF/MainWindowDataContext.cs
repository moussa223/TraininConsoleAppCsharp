using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace ExoDeplacerElementsEntreDeuxListeBoxWPF
{
    public class MainWindowDataContext
    {
        public ObservableCollection<string> Languages
        {
            get; set;
        }
        public void DeveloppementLangages()
        {
            Languages = new ObservableCollection<string>() { "Csharp", "PHP", "C", "C++", "HTML", "Javascript", "SQL" };
        }
    }
}
