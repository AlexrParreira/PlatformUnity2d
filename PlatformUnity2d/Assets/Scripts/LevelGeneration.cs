using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    
    [SerializeField] private Transform levelPart;
    [SerializeField] private Transform levelPart_Start;

   
   private void Awake(){
     Transform lastLevelTransform;
     lastLevelTransform = SpawnLevelPart(levelPart_Start.Find("End_Position").position);
    lastLevelTransform = SpawnLevelPart(lastLevelTransform.Find("End_Position").position);
    lastLevelTransform = SpawnLevelPart(lastLevelTransform.Find("End_Position").position);
    lastLevelTransform = SpawnLevelPart(lastLevelTransform.Find("End_Position").position);
    lastLevelTransform = SpawnLevelPart(lastLevelTransform.Find("End_Position").position);
    lastLevelTransform = SpawnLevelPart(lastLevelTransform.Find("End_Position").position);
      
      
   }
   
   private Transform SpawnLevelPart(Vector3 spawnPosition){
       Transform LevelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
       return LevelPartTransform;
   }
}
