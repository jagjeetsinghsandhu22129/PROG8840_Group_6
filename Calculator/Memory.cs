using System;

namespace Calculator
{
    public static class Memory
    {
        private static float _storedValue = 0;

        // Store a value in memory
        public static void Store(float value)
        {
            _storedValue = value;
        }

        // Recall the value from memory
        public static float Recall()
        {
            return _storedValue;
        }

        // Clear the memory
        public static void Clear()
        {
            _storedValue = 0;
        }
    }
}
