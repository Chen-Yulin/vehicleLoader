using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CamSelectVehicle : MonoBehaviour
{
    public int vehicleIndex = 0;
    CinemachineVirtualCamera virtualCamera;
    // Start is called before the first frame update
    public void Awake()
    {
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!virtualCamera.LookAt)
        {
            virtualCamera.LookAt = GameObject.Find("VehicleSpace").transform.GetChild(vehicleIndex);
            virtualCamera.Follow = GameObject.Find("VehicleSpace").transform.GetChild(vehicleIndex);
        }
    }
}
