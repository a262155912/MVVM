using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FWQLB : MonoBehaviour
{

    //// Use this for initialization
    //IEnumerable Start ()
    //   {
    //       string url = "http://cqx-kingnet-login-test.tmskapp.com/serverlist/getserverlist.php";
    //       ClientServerListData clientListData = new ClientServerListData();
    //       clientListData.AreaId = "1";
    //       clientListData.PtId = "10";
    //       clientListData.strUID = "";
    //       clientListData.AppLevelUpVerCode = "100";
    //       string json = JsonUtility.ToJson(clientListData);

    //       byte[] clientBytes = System.Text.Encoding.UTF8.GetBytes(json);

    //       WWW www = new WWW(url, clientBytes);

    //       yield return www; 


    //   }
    private void Awake()
    {
        string url = Application.streamingAssetsPath + "/" + "MainUIActivityAtlas.png.qj";
        Debug.Log(" | url | " + url);
        if(File.Exists(url))
        {
            Debug.Log("true");
        }
        else
        {
            Debug.Log("false ");
        }


        string url1 = Application.persistentDataPath + "/" + "MainUIActivityAtlas.png.qj";
        Debug.Log(" | url1 | " + url1);
        if (File.Exists(url))
        {
            Debug.Log("url1 | true");
             
        }
        else
        {
            Debug.Log(" url1 | false ");
        }

        //string url2 = Application.streamingAssetsPath + "/" + "MainUIActivityAtlas.png.qj";
        //Debug.Log(" | url2 | " + url2);
        //if (File.Exists(url))
        //{
        //    Debug.Log("url2 | true");
        //}
        //else
        //{
        //    Debug.Log("url2 | false ");
        //}


    }


}


//[Serializable]
//public class ClientServerListData
//{
//    [SerializeField]
//    public string AreaId;
//    [SerializeField]
//    public string PtId;
//    [SerializeField]
//    public string strUID;
//    [SerializeField]
//    public string AppLevelUpVerCode;
//    [SerializeField]
//    public string ServerIds;

//}