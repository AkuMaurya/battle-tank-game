using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawneer : MonoBehaviour
{
    public TankView tankView;
    void Start()
    {
        // Instantiate(tankView.gameObject,transform.position,Quaternion.identity);
        CreateTank();
    }

    private void CreateTank(){
        TankModel tankModel = new TankModel();
        TankController tankController = new TankController(tankModel,tankView);
    }
}
