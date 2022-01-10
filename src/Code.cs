using System;

namespace brainfuck {

    public class Code {

        public readonly string original;

        public Tuple<brainfuck.Type, Object>[] code { get; private set; }

        public Tuple<int,int> loops { get; private set; }

        public bool isRunnable { get; private set; }

        public Code() {
               


        }

        private Byte[] stack;

        private Byte Current {
            get {
                return stack[ptr];
            }
            set {
                stack[ptr] = value;
            }
        }

        private int ptr;

        private int Pointer {
            get {
                return ptr;
            }
            set {
                if(value < 0)
                    prt = stack.Length + value;
                else if(value >= stack.Length)
                    ptr = 0 + (value - stack.Length);
                else
                    prt = value;
            }
        }

        public void Compile() {

        }

        public int Run() {
            return 0; // TODO: Write Run Funktion
        }
    }

}