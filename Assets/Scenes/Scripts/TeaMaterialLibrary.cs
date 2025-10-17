using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class TeaMaterialEntry
{
    public string teaName;
    public Material material;
}

[CreateAssetMenu(menuName = "Tea/TeaMaterialLibrary")]
public class TeaMaterialLibrary : ScriptableObject
{
    public List<TeaMaterialEntry> entries;
}

