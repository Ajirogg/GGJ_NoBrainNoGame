using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MentalDisordersList : MonoBehaviour
{
    public MentalDisorder[] mentalDisroders;
  //  public ObjectList objList = new ObjectList();

    public MentalDisordersList(ObjectList objList)
    {
        ObjectUsable incense = objList.GetObjectUsable(objList.objects, "Incense");
        ObjectUsable rubiksCube = objList.GetObjectUsable(objList.objects, "Rubik's Cube");
        ObjectUsable picture = objList.GetObjectUsable(objList.objects, "Picture");
        ObjectUsable carpet = objList.GetObjectUsable(objList.objects, "Carpet");
        MentalDisorder maniac = new MentalDisorder("Maniac", incense, rubiksCube, picture, carpet);     
        maniac.neutralObject = objList.GetObjUsableNeutral(objList.neutralManiac);


        
        ObjectUsable familyPortrait = objList.GetObjectUsable(objList.objects, "Family Portrait");
        ObjectUsable terminationLetter = objList.GetObjectUsable(objList.objects, "Termination Letter");
        ObjectUsable alcohol = objList.GetObjectUsable(objList.objects, "Alcohol");
        ObjectUsable cigarette = objList.GetObjectUsable(objList.objects, "Cigarette");
        MentalDisorder drugAddiction = new MentalDisorder("Drug Addiction", familyPortrait, terminationLetter, alcohol, cigarette);
        drugAddiction.neutralObject = objList.GetObjUsableNeutral(objList.neutralAddict);




        ObjectUsable cookie = objList.GetObjectUsable(objList.objects, "Cookies");
        ObjectUsable radio = objList.GetObjectUsable(objList.objects, "Radio");
        ObjectUsable toy = objList.GetObjectUsable(objList.objects, "Wood toy");
        ObjectUsable window = objList.GetObjectUsable(objList.objects, "Window");
        MentalDisorder attentionDeficit = new MentalDisorder("Attention deficit disorder", cookie, radio, toy, window);
        attentionDeficit.neutralObject = objList.GetObjUsableNeutral(objList.neutralADD);


        ObjectUsable medicine1 = objList.GetObjectUsable(objList.objects, "Blue medicine");
        ObjectUsable medicine2 = objList.GetObjectUsable(objList.objects, "Red medicine");
        ObjectUsable familyPortraitCrossed = objList.GetObjectUsable(objList.objects, "Crossed family portrait");
        ObjectUsable callingCard = objList.GetObjectUsable(objList.objects, "Calling card");
        MentalDisorder schizophrenia = new MentalDisorder("Schizophrenia", medicine1, callingCard, familyPortraitCrossed, medicine2);
        drugAddiction.neutralObject = objList.GetObjUsableNeutral(objList.neutralSchizo);

        mentalDisroders = new MentalDisorder[] { maniac, drugAddiction, attentionDeficit/*, schizophrenia */};
    }

    public MentalDisorder GetMentalDisorder()
    {
        int index = Random.Range(0, mentalDisroders.Length);
        return mentalDisroders[index];
    }
   
}
