using System;

namespace brainfuck {

    public static class Compiler {

        public static AssemblyCode Compile(string original) {

            List<Tuple<brainfuck.Type, IOperator>> code = new List<Tuple<brainfuck.Type, IOperator>>();

            int start, count;
            int codeIndex = 0;

            for(int i = 0; i < original.Length; i++) {
                char c = original[i];
                if(Utility.IsCharInString(c, "+-><")) {
                    start = i;
                    while(c == original[i])
                        i++;
                    i--;
                    count = i - start + 1;
                }

                switch(c) {
                    case '+':
                        code.Add(new mathamaticOperator(count));
                    default: 
                        break;
                }

                codeIndex++;
            }
        }





























        public static Tuple<brainfuck.Type, Object>[] CompileToAssemblyCode(string original) {

            int start = 0;

            for(int i = 0; i < original.Length; i++) {
                char c = original[i];
                if(Utility.IsCharInString(c, "+-><")) {
                    while(c != original[i])
                        i++;
                }

            }

        }

    }

}