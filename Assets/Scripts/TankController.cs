using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController
{
    private TankModel tankModel;
    private TankView tankView;

    public TankController(TankModel _tankModel, TankView _tankView){
        tankModel = _tankModel;
        tankView = _tankView;
        
        tankModel.SetTankController(this);
        tankView.SetTankController(this);

        GameObject.Instantiate(tankView.gameObject);
    }
}

// public class TankController : MonoBehaviour
// {
    // public float speed = 10.0f;
    // public float rotationSpeed = 100.0f;

    // void Update()
    // {
    //     //For PC
    //     float translation = Input.GetAxis("Vertical1")*speed;
    //     float rotation = Input.GetAxis("Horizontal1")*rotationSpeed;

         

    //     translation *= Time.deltaTime;
    //     rotation *= Time.deltaTime;

    //     transform.Translate(0,0,translation);

    //     transform.Rotate(0,rotation,0);  
    // }
// }