using UnityEngine;

/// <summary>
/// Attribute for declaring a field to be displayed as a boolean in the editor. False being val1 and true being val2.
/// </summary>
public class BintAttribute : PropertyAttribute {

	public readonly int val1;
	public readonly int val2;


	public BintAttribute(int val1, int val2) {
		this.val1 = val1;
		this.val2 = val2;
	}
}