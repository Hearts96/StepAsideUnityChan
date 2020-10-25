using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGenerator : MonoBehaviour
{
    //MainCameraのオブジェクト
    private GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        //MainCameraの取得
        mainCamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        //unityちゃんのZ軸より後ろにMainFCameraのZ軸がきたらDestroyする
        if (this.transform.position.z > mainCamera.transform.position.z)
        {
            Destroy(this);

        }
    }
}
