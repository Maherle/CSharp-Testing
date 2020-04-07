namespace DotNetTesting.classes{
    public struct StructTest{
        public StructTest (double x, string y){
            X = x;
            Y = y;
        }

        public double X {get;}
        public string Y {get;}

        public override string ToString() => $"The string is {Y} and the double is {X}";
    }
    public class ClassTest{
        public ClassTest (){
            X = 1;
            Y = "Default";
        }
        public ClassTest(double x, string y){
            X = x;
            Y = y;
        }

        public double X {get;}
        public string Y {get;}

        public override string ToString(){
            return "The string is " + Y + " and the double is " + X;
        }
    }
}