using System;

namespace brainfuck {

    public class AssemblyCode {

        public readonly Tuple<brainfuck.Type, Object>[] code;

        public readonly Tuple<int,int> loops;

        public readonly bool isRunnable;

        public AssemblyCode(Tuple<brainfuck.Type, Object>[] code, Tuple<int,int> loops, bool isRunnable) {
            this.code = code;
            this.loops = loops;
            this.isRunnable = isRunnable;
        }

        public override string ToString() {
            string str;

            str += "Code:";
            for(int i = 0; i < code.Length; i++)
                str += i + ": { Type: " + Enum.GetName(typeof(brainfuck.Type), code[i].Item1) + ", " + code[i].Item2.ToString() + "}";
            
            str += "Loops:";
            for(int i = 0; i < loops.Length; i++)
                str += i + ": { start: " + loops[i].Item1 + ", end: " + loops[i].Item2 + "}";

            str += "Is Runnable: " + isRunnable.ToString();

            return str;
        }

    }
}