using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StoreBaseData", menuName = "Scriptable Object/StoreBaseData", order = int.MaxValue)]
public class StoreData : MonoBehaviour
{
    [SerializeField]
    private Sprite[] ItemIcon;
    public Sprite[] itemIcon { get { return ItemIcon; } }

    [SerializeField]
    [TextArea(12, 20)]

    private string Data;
    public string data { get { return Data; } }
}
