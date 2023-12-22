using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class IsVR : MonoBehaviour
{
    string path;
    string s;
    // Start is called before the first frame update
    void Start()
    {
        IsVRClass isvr=new IsVRClass();
        path = Application.dataPath + "/Resources/config.json";
        s=File.ReadAllText(path);
        isvr = JsonUtility.FromJson<IsVRClass>(s);
        if (File.Exists(path))
        {
            if (isvr.PC == 1)
            {

            }
            if (isvr.VR == 1)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(1);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
public class IsVRClass
{
    public int VR;
    public int PC;
}
