using System;

namespace CSharp_Testing.classes
{
    public class PropertyTest
    {
        private string _firstName;
        private string _lastName;
        private double _seconds;
        public double Hours
        {
            get { return _seconds / 3600; }
            set {
                if ( value < 0 || value > 24)
                    throw new ArgumentOutOfRangeException(
                        $"{nameof(value)} must be between 0 and 24."
                    );
                _seconds = value * 3600;
            }
        }
        public string Name => $"{_firstName} {_lastName}";
        public PropertyTest(string first, string last)
        {
            _firstName = first;
            _lastName = last;
        }

    }
}