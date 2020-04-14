namespace CSharp_Testing.classes
{
    public struct StructTest
    { //stuct example
        public StructTest (double x, string y)
        {
            X = x;
            Y = y;
        }

        public double X {get;}
        public string Y {get;}

        public override string ToString() => $"The string is {Y} and the double is {X}";
    }
    public class ClassTest
    { // class example
        public ClassTest ()
        {
            X = 1;
            Y = "Default";
        }
        public ClassTest(double x, string y)
        {
            X = x;
            Y = y;
        }

        public double X {get;}
        public string Y {get;}

        public override string ToString() => $"The string is {Y} and the double is {X}";
    }
}