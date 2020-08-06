using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


[CreateAssetMenu(fileName = "ScriptableLists", menuName = "ListsVariables/Type: ListOfAnimations")]
public class ListOfAnimations_SO : ScriptableObject
{
    public List<Motion> motionList = new List<Motion>();

    public List<GameObject> gameObjects = new List<GameObject>();


}
