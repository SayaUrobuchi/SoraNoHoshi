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
            ISelfDescriptable value = property.ValueEntry.WeakSmartValue as ISelfDescriptable;
            string msg = value.Desc();
            this.CallNextDrawer(property, label);
            EditorGUILayout.LabelField(msg);
        }
        // 如果不是，印出錯誤
        else
        {
            SirenixEditorGUI.ErrorMessageBox("此欄型別並非 ISelfDescriptable！");
            this.CallNextDrawer(property, label);
        }

        /* 封印
        // Get and create string member helper context.
        PropertyContext<StringMemberHelper> context;
        if (property.Context.Get(this, "StringHelper", out context))
        {
            context.Value = new StringMemberHelper(property.ParentType, attribute.Name);
        }

        // Display error
        if (context.Value.ErrorMessage != null)
        {
            SirenixEditorGUI.ErrorMessageBox(context.Value.ErrorMessage);
            this.CallNextDrawer(property, label);
        }
        else
        {
            EditorGUILayout.BeginHorizontal();
            this.CallNextDrawer(property, null);

            // Get the string from the string member helper.
            EditorGUILayout.PrefixLabel(context.Value.GetString(property));

            EditorGUILayout.EndHorizontal();
        }
        */
    }
}
