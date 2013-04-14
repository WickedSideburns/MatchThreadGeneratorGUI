MatchThreadGeneratorGUI
=======================

Small improvements from Schrodinger (4/14/2013)

MatchInfo.cs
	line 31: changed to string.IsNullOrEmpty().  Just a little simpler.

	Line 34 - 43: Changed to substring.  You don't risk index out of range errors that way.

	Line 70: removed redundant "== true"

	Line 81: string.IsNullOrEmpty() again.

	Line 85: Nice with the Environment.NewLine.  This is much better to use than '\n'


TeamInfo.cs
	Converted all to auto-properties.  Was suprised that even compiled.
	added "this" keyword.  You don't have to use it, but it makes code more readable, in my opinion.


Form1.cs
	Line 53: Changed to MessageBox.Show().  Does the same thing, but you don't have to write the code!
	Line 57: Added "this" keyword
