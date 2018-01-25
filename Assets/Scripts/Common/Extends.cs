using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extends
{
    // ------ List
    public static void TrimTo<T>(this List<T> list, int limit)
    {
        if (limit < list.Count)
        {
            list.RemoveRange(limit, list.Count - limit);
        }
    }

    public static void Shuffle<T>(this List<T> list)
    {
        for (int i = 1; i < list.Count; i++)
        {
            int j = Random.Range(0, i+1);
            T t = list[i];
            list[i] = list[j];
            list[j] = t;
        }
    }

    public static void ExtendSize<T>(this List<T> list, int size)
    {
        if (list.Count < size)
        {
            list.Capacity = size;
            while (list.Count < size)
            {
                list.Add(default(T));
            }
        }
    }

    // ------ Transform
    public static void RemoveAllChildren(this Transform parent)
    {
        foreach (Transform t in parent)
        {
            if (t.parent == parent)
            {
#if UNITY_EDITOR
                if (!Application.isPlaying)
                {
                    GameObject.DestroyImmediate(t.gameObject);
                    continue;
                }
#endif
                GameObject.Destroy(t.gameObject);
            }
        }
    }

    // ------ Clone objects
    public static T Duplicate<T>(this T obj)
    {
        return (T)Sirenix.Serialization.SerializationUtility.CreateCopy(obj);
    }

    // ------ IHasMama
    public static int GetIndexHelper<T>(this T nod, int grandLevel) where T : class, IHasMama<T>
    {
        while (grandLevel > 0 && nod.Mama != null)
        {
            nod = nod.Mama;
            grandLevel--;
        }
        return nod.Index;
    }
}
