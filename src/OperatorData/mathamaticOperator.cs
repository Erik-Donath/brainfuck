using System;

namespace brainfuck.OperatorData {

    public class mathamaticOperator : IOperator {

        public var data { get; set; }

        public mathamaticOperator(int count) {
            var = count;
        }

        public override string ToString() {
            return "Count: " + var.ToString();
        }

    }

}