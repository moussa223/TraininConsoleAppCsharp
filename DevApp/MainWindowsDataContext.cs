using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevApp
{
    public class MainWindowsDataContext
    {
        private readonly ApplicationDbContext _dbcontext;

        public MainWindowsDataContext()
        {
            _dbcontext = new ApplicationDbContext();
        }
        public List<Langues> Languages
        {
            get; set;
        }
        public List<Langues> LeftListLangues { get; set; }
        public List<Langues> RightListLangues { get; set; }

        public void DeveloppementLangages()
        {
            Languages = _dbcontext.Langues.ToList();
            LeftListLangues = Languages;
            RightListLangues = Languages;
            //Languages = new ObservableCollection<string>() { "Csharp", "PHP", "C", "C++", "HTML", "Javascript", "SQL" };
        }

    }
}
