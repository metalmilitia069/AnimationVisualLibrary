using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsToCanvas : MonoBehaviour
{
    [Header("INSERT MOTION LIST SO: ")]
    public ListOfAnimations_SO listOfAnimations_SO;

    public GameObject listOfAnimationsUI;
    public GameObject itemAnimationButtonPrefab;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in listOfAnimations_SO.motionList)
        {
            GameObject button = Instantiate(itemAnimationButtonPrefab, listOfAnimationsUI.transform);
            button.GetComponentInChildren<AnimBUtton>().itemName.text = item.name; //.GetComponent<AnimBUtton>().itemName.text = item.name;
            button.GetComponentInChildren<AnimBUtton>().motion = item;//GetComponent<AnimBUtton>().motion = item;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
