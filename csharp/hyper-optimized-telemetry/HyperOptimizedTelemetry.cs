using System;

public static class TelemetryBuffer
{


    public static byte[] ToBuffer(long reading)
    {
        byte[] buffer = new byte[9] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        byte prefix = 0;

        if ((reading > uint.MaxValue && reading <= long.MaxValue) || (reading < int.MinValue && reading >= long.MinValue))
        {
            prefix = 8;
        }
        else if ((reading <= uint.MaxValue && reading > ushort.MaxValue) || (reading < short.MinValue && reading >= int.MinValue))
        {
            prefix = 4;
        }
        else if ((reading <= ushort.MaxValue && reading >= ushort.MinValue) || (reading < ushort.MinValue && reading >= short.MinValue))
        {
            prefix = 2;
        }
        buffer[0] = (long.IsNegative(reading) || (reading > uint.MaxValue) || (reading <= int.MaxValue && reading > ushort.MaxValue)) ? (byte)(256 - prefix) : prefix;

        for (int i = 1; i <= prefix; i++)
        {
            buffer[i] = BitConverter.GetBytes(reading)[i - 1];
        }
        return buffer;

    }

    public static long FromBuffer(byte[] buffer)
    {
        int prefix = buffer[0];
        long result = 0;
        switch (prefix)
        {

            case 254:
                result = BitConverter.ToInt16(buffer, 1);
                break;
            case 252:
                result = BitConverter.ToInt32(buffer, 1);

                break;
            case 248:
            case 4:
            case 2:
                result = BitConverter.ToInt64(buffer, 1); 
                break;
            default: 
                break;

        }
        return result;

    }
}
