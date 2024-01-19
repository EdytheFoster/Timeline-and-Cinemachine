using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Vcam1_FOV_Target : MonoBehaviour
{
    [SerializeField] private GameObject _VC1;
    [SerializeField] private GameObject _Target01;
    [SerializeField] private GameObject _Target02;

    private bool _firsttarget;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Switchtarget();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float FOV = _VC1.GetComponent<CinemachineVirtualCamera>().m_Lens.FieldOfView -= 20;
            if (FOV < 10)
            {
                _VC1.GetComponent<CinemachineVirtualCamera>().m_Lens.FieldOfView = 60;
            }
        }
    }
    private void Switchtarget()
    {
        if (_firsttarget == true)
        {
            _VC1.GetComponent<CinemachineVirtualCamera>().LookAt = _Target01.transform;
            _firsttarget = false;
        }
        else if (_firsttarget == false)
        {
            _VC1.GetComponent<CinemachineVirtualCamera>().LookAt = _Target02.transform;
            _firsttarget = true;
        }
    }
}
