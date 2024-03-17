using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    public string readFileName = "";
    public string readHeaderName = "";

    private void Start()
    {
        SearchStore();
    }

    public void SearchStore()
    {
        List<Dictionary<string, object>> data_Dialog = CSVReader.Read(readFileName);

        for (int i = 0; i < data_Dialog.Count; i++)
        {
            Debug.Log(data_Dialog[i][readHeaderName].ToString());
        }
    }
}

