using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchTrigger : MonoBehaviour
{
    private CameraManager _cameraManager;
    [SerializeField] private int _whichCamera;

    // Start is called before the first frame update
    void Start()
    {
        _cameraManager = GameObject.Find("Managers").GetComponent<CameraManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _cameraManager.ResetAllCameras();
            _cameraManager.SetMasterCamera(_whichCamera);
        }
    }
}
