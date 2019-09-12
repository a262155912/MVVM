using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 
/// </summary>
public class DontUnloadObject : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        DontDestroyOnLoad(this.gameObject);

	}

#if UNITY_EDITOR
    void Update ()
    {
		
	}
#endif
}
