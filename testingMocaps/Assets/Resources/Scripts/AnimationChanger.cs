using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class AnimationChanger : MonoBehaviour
{
    [Header("INSERT MOTION LIST SO: ")]
    public ListOfAnimations_SO listOfAnimations_SO;

    public UnityEditor.Animations.AnimatorController animatorController;    

    public Motion motion1;
    public Motion motion2;

    private AnimatorState animatorState;
    private int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        animatorState = animatorController.layers[0].stateMachine.defaultState;
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            ChangeAnimation();
        }
    }

    public void ChangeAnimation()
    {
        index++;
        if (index <= listOfAnimations_SO.motionList.Count - 1)
        {
            animatorState.motion = listOfAnimations_SO.motionList[index];
        }
        else
        {
            index = 0;
            animatorState.motion = listOfAnimations_SO.motionList[index];
        }
        
       
    }
}
