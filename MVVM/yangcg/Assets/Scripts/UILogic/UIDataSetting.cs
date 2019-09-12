using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIData
{
    public string path;
    public string resFolder;
    public int define;
    public UILayer layer = UILayer.Normal;
    public Type panelType;
    public Type logicType;
    public Color color = Color.black;
    public int mask;
    public int zOffset = 300;
    public int depthOffset = 100;
    public bool  isDownloader = false;
    public bool isOpening = false;

    //全屏界面
    public static readonly int UI_MASK_FULLSCREEN = 0x00000001;
    //单例
    public static readonly int UI_MASK_SINGLE = 0x00000100; 


    public UIData(string resFolder , Type panelType , Type logicType ,int mask = 0 )
    {

    }
}

public class UIDataSetting
{
    private Dictionary<int, UIData> m_UIDatas = new Dictionary<int, UIData>();

    public Dictionary<int, UIData> UIDatas
    {
        get
        {
            return m_UIDatas; 
        }
    }

    private Dictionary<Type, UIData> m_PanelTypeUIData = new Dictionary<Type, UIData>(); 

	public UIDataSetting()
    {
        SetupData();
    }

    public void Add (int define , UIData data )
    {

    }

    private void SetupData()
    {
        Add((int)UIDefine.eLoadingGame, new UIData("LoadingGame", typeof(LoadingGame), typeof(DefaultLogic),UIData.UI_MASK_FULLSCREEN | UIData.UI_MASK_SINGLE));

    }
}
