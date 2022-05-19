using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Employee_Database
{
    internal class VM : INotifyPropertyChanged
    {
        private string empName = "";
        public string EmpName
        {
            get
            {
                return empName;
            }
            set
            {
                empName = value;
                propChange();
            }
        }

        private int empId = 0;
        public int EmpId
        {
            get
            {
                return empId;
            }
            set
            {
                empId = value;
                propChange();
            }
        }

        private string empDep = "";
        public string EmpDep
        {
            get
            {
                return empDep;
            }
            set
            {
                empDep = value;
                propChange();
            }
        }

        private string empPos = "";
        public string EmpPos
        {
            get
            {
                return empPos;
            }
            set
            {
                empPos = value;
                propChange();
            }
        }

        private static VM vm;
        public static VM Instance
        {
            get
            {
                if (vm == null)
                    vm = new VM();
                return vm;
            }
        }

        public BindingList<Records> Record { get; set; } = new BindingList<Records>();

        private Records selectedRecord;
        public Records SelectedRecord
        {
            get { return selectedRecord; }
            set { selectedRecord = value; propChange(); }
        }

        public void Save()
        {
            Record.Add(new Records
            {
                Name = empName,
                IdNumber = empId,
                Department = empDep,
                Position = empPos
            });
            Clear();
        }

        public void Clear()
        {
            EmpName = "";
            EmpId = 0;
            EmpDep = "";
            EmpPos = "";
        }

        private VM() // singleton
        {
            Record.Add(new Records());

            Record.Add(new Records
            {
                Name = "Bharat",
                IdNumber = 1,
                Department = "Computer Science",
                Position = "Software Developer"
            });

            Record.Add(new Records
            {
                Name = "Sree",
                IdNumber = 2,
                Department = "Computer Science",
                Position = "Software Service Engineer"
            });

            Record.Add(new Records
            {
                Name = "Harshit",
                IdNumber = 3,
                Department = "Computer Science",
                Position = "Database Engineer"
            });

            Record.Add(new Records
            {
                Name = "Mounika",
                IdNumber = 4
            });
        }
        #region Property Changed
        public event PropertyChangedEventHandler PropertyChanged;

        private void propChange([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
