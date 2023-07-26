using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;
    private float movement;
    private float rotation;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if(movement != 0){
            tankController.Move(movement,30);
        }

        if(rotation != 0)
            tankController.Rotate(rotation, 20);
    }

    private void Movement(){
        movement = Input.GetAxis("Vertical1");
        rotation = Input.GetAxis("Horizontal1");
    }

    public void SetTankController(TankController _tankController){
        tankController = _tankController;
    }

    public Rigidbody GetRigidBody(){
        return rb;
    }
}
