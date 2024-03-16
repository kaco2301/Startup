using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataProcessing : MonoBehaviour
{
    public KangWonData storeBaseData;
    StoreData storeData;

    private void Start()
    {
        GameObject storeDataGo = new GameObject("Store DB");
        storeDataGo.transform.position = transform.position;
        storeDataGo.transform.parent = transform;

        storeData = storeDataGo.AddComponent<StoreData>();

    }
}
