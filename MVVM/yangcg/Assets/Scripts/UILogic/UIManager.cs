using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 
/// </summary>
public class UIManager
{
    private static UIManager s_Instance;

    public static UIManager Instance
    {
        get
        {
            if (null  == s_Instance)
            {
                s_Instance = new UIManager(); 
            }

            return s_Instance; 
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="ID">UI 枚举</param>
	public void OpenUI(UIDefine ID)
    {

    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="ID">UI 枚举</param>
    /// <param name="param">参数</param>
    public void OpenUI(UIDefine ID , params object[] param)
    {

    }
}
