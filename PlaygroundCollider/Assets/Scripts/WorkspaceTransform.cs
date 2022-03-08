using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkspaceTransform : MonoBehaviour
{

    public float X;
    public float Y;
    public float Z;

    public GameObject Workspace;

    // Start is called before the first frame update
    void Start()
    {

        Workspace.transform.localScale = new Vector3(X, Y, Z);

    }



    // Update is called once per frame
    void Update()
    {

    }
}
