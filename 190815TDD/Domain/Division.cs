namespace TDD.Domain {
    public class Division {
        public double Dividir(int v1, int v2) {
            if (v2 == 0) {
                throw new NoDivisionByZeroException("NO");
            }
            
            return v1 / (double)v2;
        }
    }
}