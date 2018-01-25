using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHasMama<T> where T : class, IHasMama<T>
{
    int Index { get; }
    T Mama { get; }

    int GetIndex(int grandLevel);
}
