using UnityEngine;
using UnityEditor;

public static partial class PropertyDrawers {

	public static float sLH = EditorGUIUtility.singleLineHeight;


	[CustomPropertyDrawer(typeof(BintAttribute))]
	public class BintDrawer : PropertyDrawer {

		private BintAttribute _attributeValue = null;
		private BintAttribute attributeValue {
			get {
				if (_attributeValue == null) _attributeValue = (BintAttribute)attribute;
				return _attributeValue;
			}
		}

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
			label = EditorGUI.BeginProperty(position, label, property);
			Rect contentPosition = EditorGUI.PrefixLabel(position, label);

			bool dispValue = property.intValue == attributeValue.val1 ? false : true;

			property.intValue = EditorGUI.Toggle(contentPosition, dispValue) == false ? attributeValue.val1 : attributeValue.val2;
			EditorGUI.EndProperty();
		}

		public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
			return sLH;
		}
	}

	[CustomPropertyDrawer(typeof(BstringAttribute))]
	public class BstringDrawer : PropertyDrawer {

		private BstringAttribute _attributeValue = null;
		private BstringAttribute attributeValue {
			get {
				if (_attributeValue == null) _attributeValue = (BstringAttribute)attribute;
				return _attributeValue;
			}
		}

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
			label = EditorGUI.BeginProperty(position, label, property);
			Rect contentPosition = EditorGUI.PrefixLabel(position, label);

			bool dispValue = property.stringValue == attributeValue.val1 ? false : true;

			property.stringValue = EditorGUI.Toggle(contentPosition, dispValue) == false ? attributeValue.val1 : attributeValue.val2;
			EditorGUI.EndProperty();
		}

		public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
			return sLH;
		}
	}

	[CustomPropertyDrawer(typeof(BfloatAttribute))]
	public class BfloatDrawer : PropertyDrawer {

		private BfloatAttribute _attributeValue = null;
		private BfloatAttribute attributeValue {
			get {
				if (_attributeValue == null) _attributeValue = (BfloatAttribute)attribute;
				return _attributeValue;
			}
		}

		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
			label = EditorGUI.BeginProperty(position, label, property);
			Rect contentPosition = EditorGUI.PrefixLabel(position, label);

			bool dispValue = property.floatValue == attributeValue.val1 ? false : true;

			property.floatValue = EditorGUI.Toggle(contentPosition, dispValue) == false ? attributeValue.val1 : attributeValue.val2;
			EditorGUI.EndProperty();
		}

		public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
			return sLH;
		}
	}
}
