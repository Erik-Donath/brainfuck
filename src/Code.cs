using System;

namespace brainfuck {

    public class Code {

        public readonly string original;

        public AssemblyCode code {get; private set; }

        public int exitCode { get; private set; }

        public bool isRunning { get; private set; }
        public bool isCompiled {get; private set; }

        public Code(string original, bool run = false) {
            // TODO: Write Implementation
            this.original = original;

            if(run)
                Run();
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
            code = brainfuck.Compiler.Compile(original);
        }

        public int Run() {
            if(!isCompiled)
                Compile();

            if(!code.isRunnable)
                return 1;
            isRunning = true;

            // Stuff to do here

            isRunning = false;
            exitCode = 0;
            return exitCode;
        }
    }

}