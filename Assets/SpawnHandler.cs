using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHandler : MonoBehaviour {
   [SerializeField] private GameObject[] spawnObjects;
   [SerializeField] private int amount;

   private void Start() {
      Spawn();
   }

   private void Spawn() {
      Transform tempTransform = gameObject.transform;
      for (var i = 0; i < amount; i++) {
         var randomIndex = Random.Range(0, spawnObjects.Length);
         Instantiate(spawnObjects[randomIndex], tempTransform.position,
            tempTransform.rotation);
         tempTransform.Translate(new Vector3(2, 0, 0));
      }

      foreach (var item in spawnObjects) {
         print(item);
      }
   }
}
