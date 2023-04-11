using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject target;
    public Vector3 offset;
    public bool isUseOffset;
    void Start()
    {
        if (!isUseOffset)
        {
            offset = target.transform.position - transform.position ;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position - offset;
        transform.LookAt(target.transform);
    }
}
