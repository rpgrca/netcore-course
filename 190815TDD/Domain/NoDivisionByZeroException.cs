using System;

namespace TDD.Domain {
    public class NoDivisionByZeroException : Exception {
        public NoDivisionByZeroException(string message)
            : base(message) {
                
            }
    }
}