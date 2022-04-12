using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kreta.Models;
using Kreta.Repositories;
using System.Collections.ObjectModel;

namespace Kreta.ViewModels
{
    public class SchoolClassViewModel
    {
        private SchoolClassesRepo classesRepo;
        private ObservableCollection<SchoolClass> classes;

        public SchoolClassViewModel()
        {
            classesRepo = new SchoolClassesRepo();
            classes = new ObservableCollection<SchoolClass>(classesRepo.SchoolClasses);
        }

        public ObservableCollection<SchoolClass> Classes { get => classes; set => classes = value; }
    }
}
