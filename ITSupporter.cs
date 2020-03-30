namespace EmployeesV10
{
    public class ITSupporter : Employee
    {
        #region Instance fields
        private string _name;
        private int _hoursPerWeek;
        private string _primaryWorkArea;
        #endregion

        #region Constructor
        public ITSupporter(string Name, int HoursPerWeek, string PrimaryWorkArea)
            : base(Name, HoursPerWeek, PrimaryWorkArea)
        {
            _name = Name;
            _hoursPerWeek = HoursPerWeek;
            _primaryWorkArea = PrimaryWorkArea;
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int HoursPerWeek
        {
            get { return _hoursPerWeek; }
            set { _hoursPerWeek = value; }
        }

        public string PrimaryWorkArea
        {
            get { return _primaryWorkArea; }
            set { _primaryWorkArea = value; }
        }

        public string AllInformation
        {
            get
            {
                return $"IT-Supporter {Name} works {HoursPerWeek} hours/week, mostly with {PrimaryWorkArea}";
            }
        } 
        #endregion
    }
}
