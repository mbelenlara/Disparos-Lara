using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public GameObject ScriptBall; 
    public Transform PointOfShoot;
    void Start()
    {

    }

    [SerializeField] private KeyCode shootKeyCode;
 






    private void Update()
    {
        if (Input.GetKeyDown(shootKeyCode))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Instantiate(ScriptBall, PointOfShoot); 

        Debug.Log("Shoot");
    }



}
