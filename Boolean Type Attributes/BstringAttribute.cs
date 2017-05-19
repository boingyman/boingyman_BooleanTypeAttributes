using UnityEngine;

/// <summary>
/// Attribute for declaring a field to be displayed as a boolean in the editor. False being val1 and true being val2.
/// </summary>
public class BstringAttribute : PropertyAttribute {

	public readonly string val1;
	public readonly string val2;


	public BstringAttribute(string val1, string val2) {
		this.val1 = val1;
		this.val2 = val2;
	}
}