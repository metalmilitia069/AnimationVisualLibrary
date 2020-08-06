using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;

public class AnimBUtton : MonoBehaviour
{
    [Header("INSERT CUSTOM SAVED MOTION LIST SO: ")]
    public ListOfAnimations_SO CustomlistOfAnimations_SO;

    public Text itemName;
    public string name;
    public Motion motion;


    public Text saveButtonName;
    public Image saveButtonImage;
    private bool wannaSave = false;

    public UnityEditor.Animations.AnimatorController animatorController;
    public AnimatorState animatorState;

    // Start is called before the first frame update
    void Start()
    {
        animatorState = animatorController.layers[0].stateMachine.defaultState;
        saveButtonImage.color = Color.magenta;

        CustomlistOfAnimations_SO.motionList.Clear();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ApplyAnimation()
    {
        animatorState.motion = motion;
    }

    public void SaveMotionToList()
    {
        wannaSave = !wannaSave;

        if (wannaSave)
        {
            CustomlistOfAnimations_SO.motionList.Add(motion);
            saveButtonName.text = "Saved To Custom";
            saveButtonImage.color = Color.green;
        }
        else
        {
            CustomlistOfAnimations_SO.motionList.Remove(motion);
            saveButtonName.text = "Wanna Save to Custom?";
            saveButtonImage.color = Color.magenta;
        }
    }
}
