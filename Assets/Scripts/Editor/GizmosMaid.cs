using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public static class GizmosMaid
{
    [DrawGizmo(GizmoType.Active | GizmoType.Selected)]
    static void DrawShowGizmos(ShowGizmos obj, GizmoType gizmoType)
    {
        if (obj.ShowAlways || (gizmoType & GizmoType.InSelectionHierarchy) != 0)
        {
            if (obj.IconName != null)
            {
                Gizmos.DrawIcon(obj.transform.position, obj.IconName, true);
            }
        }
    }

    static void DrawNumber(Vector3 pos, int num, float yStep = 1f)
    {
        if (num >= 10)
        {
            DrawNumber(pos+new Vector3(0, yStep), num/10);
        }
        int n = num % 10;
        Gizmos.DrawIcon(pos, n.ToString());
    }

    static void DrawDragonBall(Vector3 center, int count, float radius = .2f, float xStep = .4f, float yStep = .4f)
    {
        int j = 0;
        float y = center.y;
        for (int i = 1; true; i++)
        {
            int column = Mathf.Min(i, count - j);
            j += i;
            float startX = center.x + -xStep * 0.5f * (column-1);
            for (int k = 0; k < column; k++)
            {
                Gizmos.DrawSphere(new Vector3(startX, y), radius);
                startX += xStep;
            }
            y += yStep;
            if (count <= j)
            {
                break;
            }
        }
    }
}
