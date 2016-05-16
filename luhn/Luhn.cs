using System;
using System.Linq;

/*Luhn validates and creates checksum codes*/
public class Luhn {
	private int[] Code;

	/*Luhn creates a new checksum number*/
	public Luhn(long code) {
		Code = code.ToString ()
			.ToArray()
			.Select (d => (int)(d - '0'))
			.ToArray();
	}

	/*CheckDigit returns the last number*/
	public int CheckDigit {
		get { return Code.Last(); }
	}

	/*Addends doubles every other number starting from the right
	and subtracts 9 if the result is 10 or greater*/
	public int[] Addends {
		get {
			int[] doubled = (int[])Code.Clone();
			for (int i = doubled.Length - 2; 0 <= i; i -= 2) {
				doubled [i] *= 2;
				if (10 <= doubled [i])
					doubled[i] -= 9;
			}
			return doubled;
		}
	}

	/*Checksum sums all the digits after adding the ends*/
	public int Checksum {
		get { return Addends
				.Aggregate (0, (total, n) => total + n);
			}
	}

	/*Valid is true when the code is valid*/
	public bool Valid {
		get { return (Checksum % 10) == 0; }
	}

	/*Create adds a check digit to make the code valid*/
	public static long Create(long code) {
		code *= 10;
		Luhn luhn = new Luhn (code);
		if (luhn.Valid)
			return code;
		return code + (10 - (luhn.Checksum % 10));
	}
}