using UnityEngine;

/// <summary>
/// Attribute for declaring a field to be displayed as a boolean in the editor. False being val1 and true being val2.
/// </summary>
public class BfloatAttribute : PropertyAttribute {

	public readonly float val1;
	public readonly float val2;


	public BfloatAttribute(float val1, float val2) {
		this.val1 = val1;
		this.val2 = val2;
	}
}