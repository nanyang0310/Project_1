using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using com.ootii.Actors;
using com.ootii.Cameras;
using UnityStandardAssets.Characters.FirstPerson;

public class Test : MonoBehaviour
{
  public  CameraController m_cameraController;
    public Transform m_cameraTargt;
    public FirstPersonController m_firstPersonController;

    void Start()
    {
        
    }


    void LateUpdate()
    {
        //m_cameraTargt.position = m_firstPersonController.transform.position;
        //m_firstPersonController.transform.rotation = m_cameraTargt.rotation;

        CameraMotor activeMotor = m_cameraController.ActiveMotor;
        Debug.Log(activeMotor.Name);
    }

    public void SwitchToFirstPersonView()
    {
        CameraMotor activeMotor = m_cameraController.ActiveMotor;
    }
}
