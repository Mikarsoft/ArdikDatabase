
namespace ArdikDb
{
    struct Int24
    {
        private const int MaxValue = 16777215; // Maximum value for a 3-byte number
        private const int ByteMask = 0xFF; // Mask to ensure only 8 bits are used

        private int value;

        public Int24(int value)
        {
            if (value < 0 || value > MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Value must be between 0 and 16777215.");
            }
            this.value = value;
        }

        public static implicit operator Int24(int value)
        {
            return new Int24(value);
        }

        public static implicit operator int(Int24 number)
        {
            return number.value;
        }

        public override string ToString()
        {
            return value.ToString();
        }

        // Convert ThreeByteNumber to byte array
        public byte[] ToByteArray()
        {
            byte[] byteArray = new byte[3];
            byteArray[0] = (byte)((value >> 16) & ByteMask);
            byteArray[1] = (byte)((value >> 8) & ByteMask);
            byteArray[2] = (byte)(value & ByteMask);
            return byteArray;
        }
    }
}
