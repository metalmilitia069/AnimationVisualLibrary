using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MenuScript
{
    [MenuItem("Tools/Process Animations")]    
    public static void ProcessAnimations()
    {
        //GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");
        //Object[] animations = Resources.LoadAll("MotionLibraryDemoAssets", typeof(ModelImporter));  //("Assets /Resources/MotionLibraryDemoAssets"); //.FindObjectsOfTypeAll<ModelImporter>(); //.FindObjectsOfType<ModelImporter>();// .FindGameObjectsWithTag("anim");
        ModelImporter[] animations = Resources.FindObjectsOfTypeAll<ModelImporter>();

        Debug.Log(animations.Length);
        //ModelImporter.ModelImporterAnimationType

        //Material mat = Resources.Load<Material>("Material/Tile");
        //Assets / Resources / MotionLibraryDemoAssets / Audiomotion - Amping up a crowd.fbx
        foreach (var item in animations)
        {
            //ModelImporter item = (ModelImporter)itemm;
            //item.GetComponent<Renderer>().material = mat;
            item.animationType = ModelImporterAnimationType.Human;
            item.avatarSetup = ModelImporterAvatarSetup.CreateFromThisModel;
            item.animationWrapMode = WrapMode.Loop;
            item.autoGenerateAvatarMappingIfUnspecified = true;
            item.SaveAndReimport();
            item.animationWrapMode = WrapMode.Loop;

            

        }


        //ListOfAnimations_SO listOfAnimations_SO = Resources.Load<ListOfAnimations_SO>("MotionLibraryDemoAssets/ScriptableLists"); //Resources.FindObjectsOfTypeAll<ListOfAnimations_SO>();

        //Object[] motions = Resources.LoadAll("MotionLibraryDemoAssets", typeof(Motion));//Resources.FindObjectsOfTypeAll<Motion>();


        //listOfAnimations_SO.motionList.Clear();

        //foreach (var itemm in motions)
        //{
        //    Motion item = (Motion)itemm;
        //    listOfAnimations_SO.motionList.Add(item);
        //}

        



        
    }

    [MenuItem("Tools/Add Processed Animations to List")]
    public static void AddProcessedtoList()
    {
        ListOfAnimations_SO listOfAnimations_SO = Resources.Load<ListOfAnimations_SO>("ListOfAllAnimations/ScriptableLists"); //Resources.FindObjectsOfTypeAll<ListOfAnimations_SO>();
        
        //listOfAnimations_SO.motionList.Clear();

        Object[] motions = Resources.LoadAll("AnimationsToAdd", typeof(Motion));//Resources.FindObjectsOfTypeAll<Motion>();
        //Object[] motions1 = Resources.LoadAll("HugeMocapLibPart1", typeof(Motion));


        foreach (var itemm in motions)
        {
            Motion item = (Motion)itemm;
            listOfAnimations_SO.motionList.Add(item);
        }

        //foreach (var itemm in motions1)
        //{
        //    Motion item = (Motion)itemm;
        //    listOfAnimations_SO.motionList.Add(item);
        //}


    }



    //[MenuItem("Tools/Assign Tile Script")]
    //public static void AssignTileScript()
    //{
    //    GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");

    //    foreach (var item in tiles)
    //    {
    //        //item.AddComponent<Tile>();
    //    }
    //}

}