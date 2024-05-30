using System;

public static class PhoneNumber
{
	const string dialingCodeNY = "212";
	const string fakePrefix = "555";
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
		string[] phoneNumberParts = phoneNumber.Split(new char[] { '-' });
		var dialingCode = phoneNumberParts[0];
		var prefixCode = phoneNumberParts[1];
		var number = phoneNumberParts[2];

		return (dialingCode ==dialingCodeNY, prefixCode == fakePrefix, number);
	}

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
