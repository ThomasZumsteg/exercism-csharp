using System.Collections.Generic;

/*SecretHandshake preforms a secret handshake from Mary Poppins*/
public class SecretHandshake {
	private static string[] steps = new string[] {
		"wink",
		"double blink",
		"close your eyes",
		"jump",
	};

	/*Commands creates a set of commands from a code*/
	public static string[] Commands(int code) {
		List<string> commands = new List<string> ();
		for (int i = 0; i < steps.Length; i++) {
			if ((code & (1 << i)) > 0)
				commands.Add (steps [i]);
		}

		if (code > (1 << steps.Length))
			commands.Reverse ();
		
		return commands.ToArray();
	}
}