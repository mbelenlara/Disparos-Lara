using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBall : MonoBehaviour
{
    [SerializeField] public float speed; 
    [SerializeField] public Vector3 movimiento;
    [SerializeField] public float damage = 10f;
  

    // Start is called before the first frame update
    void Start()
    
    {
     
    }


    // Update is called once per frame
    void Update()
    {
        transform.position += movimiento *speed; 
    }

    public void MoveBall()
    {    
        transform.position = new Vector3 (0, 0, 0); 
    }


}
