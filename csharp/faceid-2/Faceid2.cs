using System;
using System.Collections.Generic;

public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
// TODO: implement equality and GetHashCode() methods
    public override bool Equals(object obj) => this.Equals(obj as FacialFeatures);

	public bool Equals(FacialFeatures face)
	{
		if (face is null)
		{
			return false;
		}

		// Optimization for a common success case.
		if (Object.ReferenceEquals(this, face))
		{
			return true;
		}

		// If run-time types are not exactly the same, return false.
		if (this.GetType() != face.GetType())
		{
			return false;
		}

		// Return true if the fields match.
		// Note that the base class is not invoked because it is
		// System.Object, which defines Equals as reference equality.
		return this.EyeColor.Equals(face.EyeColor) && this.PhiltrumWidth.Equals(face.PhiltrumWidth);
	}

	public override int GetHashCode() => (EyeColor, PhiltrumWidth).GetHashCode();

//	public static bool operator ==(FacialFeatures firstFace, FacialFeatures secondFace)
//	{
//		if (firstFace is null)
//		{
//			if (secondFace is null)
//			{
//				return true;
//			}
//
//			// Only the first face is null.
//			return false;
//		}
//		// Equals handles case of null on second face.
//		return firstFace.Equals(secondFace);
//	}
//
//	public static bool operator !=(FacialFeatures firstFace, FacialFeatures secondFace) => !(firstFace == secondFace);
}


public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
	// TODO: implement equality and GetHashCode() methods
	public override bool Equals(object obj) => this.Equals(obj as Identity);

	public bool Equals(Identity id)
	{
		if (id is null)
		{
			return false;
		}

		// Optimization for a common success case.
		if (Object.ReferenceEquals(this, id))
		{
			return true;
		}

		// If run-time types are not exactly the same, return false.
		if (this.GetType() != id.GetType())
		{
			return false;
		}

		// Return true if the fields match.
		// Note that the base class is not invoked because it is
		// System.Object, which defines Equals as reference equality.
		return this.Email.Equals(id.Email) && this.FacialFeatures.Equals(id.FacialFeatures);
	}

	public override int GetHashCode() => (Email, FacialFeatures).GetHashCode();
}

public class Authenticator
{
	private Identity admin = new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m));

	private HashSet<Identity> identities = new HashSet<Identity>();

    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return faceA.Equals(faceB);
    }

    public bool IsAdmin(Identity identity)
    {
        return identity.Equals(admin);
    }

	public bool Register(Identity identity)
	{
		if (!IsRegistered(identity))
		{
			identities.Add(identity);
			return true;
		}
		else
		{
			return false;
		}
	}

    public bool IsRegistered(Identity identity)
    {
        return identities.Contains(identity);
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return Object.ReferenceEquals(identityA,identityB);
    }
}
