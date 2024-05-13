namespace solution
{
    class User
    {
        public string Name;
        public string Lastname;
        List<IBAN> _Accs = new List<IBAN>();
        public User(string name,string lastname)
        {
            this.Name = name;
            this.Lastname = lastname;
            _Accs.Add(null);
        }
        public IBAN this[int index]
        {
            get
            {
                return _Accs[index];
            }
            set
            {
                while (_Accs.Count <= index)
                {
                    _Accs.Add(null);
                }
                
                _Accs[index] = value;
            }
        }
    }
}
