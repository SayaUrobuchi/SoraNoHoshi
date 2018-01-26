using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities.Editor;

[OdinDrawer]
public sealed class SelfDescAttributeDrawer : OdinAttributeDrawer<SelfDescAttribute>
{
    protected override void DrawPropertyLayout(InspectorProperty property, SelfDescAttribute attribute, GUIContent label)
    {
        // 檢查是否為 ISelfDescriptable
        if (typeof(ISelfDescriptable).IsAssignableFrom(property.ValueEntry.TypeOfValue))
        {
            this.CallNextDrawer(property, label);
            // Draw ISelfDescriptable
            ISelfDescriptable value = property.ValueEntry.WeakSmartValue as ISelfDescriptable;
            string msg = string.Format("{1}: {0}", value.Desc(), property.Name);
            Color bgcTemp = GUI.color;
            GUI.color = Color.magenta;
            {
                Rect r = EditorGUILayout.GetControlRect();
                EditorGUI.DrawRect(r, Color.magenta);
                EditorGUI.LabelField(r, msg);
                //EditorGUILayout.LabelField(msg);
            }
            GUI.color = bgcTemp;
        }
        // 如果不是，印出錯誤
        else
        {
            SirenixEditorGUI.ErrorMessageBox("此欄型別並非 ISelfDescriptable！");
            this.CallNextDrawer(property, label);
        }
    }
}
