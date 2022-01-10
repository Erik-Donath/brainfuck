using System;

namespace brainfuck {

    public static class Utility {

        public static bool IsCharInString(char ch, string str) {
            return IsCharInCharArray(str.ToCharArray());
        }

        public static bool IsCharInCharArray(char ch, char[] array) {
            foreach(char c in array) {
                if(c == ch)
                    return true;
            }
            return false;
        }

        // Funktions that arent spesific to one class.
    }
}