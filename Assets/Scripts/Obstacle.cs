using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{ 
    private float _speed = -10f;

   private void Update()
   {
     this.transform.Translate(Vector3.forward * _speed * Time.deltaTime); 
   }
}
