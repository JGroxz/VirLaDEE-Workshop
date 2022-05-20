using System;
using System.Collections;
using System.Collections.Generic;
using Mirage;
using UnityEngine;using Object = UnityEngine.Object;




public class DisableFloor : MonoBehaviour



{
 public NetworkManager networkManager;
 public GameObject objectToDestroy;
 public void OnDisable()
 {
  Debug.Log("disable floor");
  networkManager.ServerObjectManager.Destroy(objectToDestroy,true);

 }
}
