using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MentalDisordersList : MonoBehaviour
{
    public MentalDisorder[] mentalDisroders;
    public ObjectList objList = new ObjectList();

    public MentalDisordersList()
    {
        ObjectUsable[] objs = objList.CreateObjectList();


        ObjectUsable incense = objList.GetObjectUsable(objs, "Incense");
        ObjectUsable rubiksCube = objList.GetObjectUsable(objs, "Rubik's Cube");
        ObjectUsable picture = objList.GetObjectUsable(objs, "Picture");
        ObjectUsable carpet = objList.GetObjectUsable(objs, "Carpet");
        MentalDisorder maniac = new MentalDisorder("Maniac", incense, rubiksCube, picture, carpet);     
        maniac.neutralObject = objList.GetObjUsableNeutral(objList.neutralManiac);


        
        ObjectUsable familyPortrait = objList.GetObjectUsable(objs, "Family Portrait");
        ObjectUsable terminationLetter = objList.GetObjectUsable(objs, "Termination Letter");
        ObjectUsable alcohol = objList.GetObjectUsable(objs, "Alcohol");
        ObjectUsable cigarette = objList.GetObjectUsable(objs, "Cigarette");
        MentalDisorder drugAddiction = new MentalDisorder("Drug Addiction", familyPortrait, terminationLetter, alcohol, cigarette);
        drugAddiction.neutralObject = objList.GetObjUsableNeutral(objList.neutralAddict);




        ObjectUsable cookie = objList.GetObjectUsable(objs, "Cookies");
        ObjectUsable radio = objList.GetObjectUsable(objs, "Radio");
        ObjectUsable toy = objList.GetObjectUsable(objs, "Wood toy");
        ObjectUsable window = objList.GetObjectUsable(objs, "Window");
        MentalDisorder attentionDeficit = new MentalDisorder("Attention deficit disorder", cookie, radio, toy, window);
        attentionDeficit.neutralObject = objList.GetObjUsableNeutral(objList.neutralADD);


        ObjectUsable medicine1 = objList.GetObjectUsable(objs, "Blue medicine");
        ObjectUsable medicine2 = objList.GetObjectUsable(objs, "Red medicine");
        ObjectUsable familyPortraitCrossed = objList.GetObjectUsable(objs, "Crossed family portrait");
        ObjectUsable callingCard = objList.GetObjectUsable(objs, "Calling card");
        MentalDisorder schizophrenia = new MentalDisorder("Schizophrenia", medicine1, callingCard, familyPortraitCrossed, medicine2);
        drugAddiction.neutralObject = objList.GetObjUsableNeutral(objList.neutralSchizo);

        mentalDisroders = new MentalDisorder[] { maniac, drugAddiction, attentionDeficit, schizophrenia };
    }

    public MentalDisorder GetMentalDisorder()
    {
        int index = Random.Range(0, mentalDisroders.Length);
        return mentalDisroders[index];
    }
   
}
