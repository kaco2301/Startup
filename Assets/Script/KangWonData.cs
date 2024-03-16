using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ItemType { StoreName, MajCategory, SubCategory, StandardCategory, CityName, DistName, AdminName, LegalName, LandAdd, RoadAdd, OldPostCode, NewPostCode, Longitude, Latitude }
public class KangWonData : MonoBehaviour
{
    [System.Serializable]
    public class Item
    {
        public string StoreName;
        public string MajCategory;
        public string SubCategory;
        public string StandardCategory;
        public string CityName;
        public string DistName;
        public string AdminName;
        public string LegalName;
        public string LandAdd;
        public string RoadAdd;
        public string OldPostCode;
        public string NewPostCode;
        public float Longitude;
        public float Latitude;
    }

    [System.Serializable]
    public class ItemBundle
    {
        
    }
}
