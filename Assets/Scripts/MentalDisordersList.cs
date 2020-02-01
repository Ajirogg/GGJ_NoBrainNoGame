using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MentalDisordersList : MonoBehaviour
{
    public MentalDisorder[] mentalDisroders;

    public MentalDisordersList()
    {
        ObjectUsable incense = new ObjectUsable("incense", 50, "Light incense");
        ObjectUsable noteBook = new ObjectUsable("Note Book", 50, "Propose a distraction");
        ObjectUsable picture = new ObjectUsable("Picture", -50, "Straighten the table");
        ObjectUsable carpet = new ObjectUsable("Carpet", -50, "Lay down the mat");
        MentalDisorder maniac = new MentalDisorder("Maniac", incense, noteBook, picture, carpet);

        ObjectUsable familyPortrait = new ObjectUsable("Family Portrait", 50, "Show family portrait");
        ObjectUsable terminationLetter = new ObjectUsable("Termination Letter", 50, "Recall the termination");
        ObjectUsable alcohol = new ObjectUsable("Alcohol", -50, "Offer a glass");
        ObjectUsable cigarette = new ObjectUsable("Cigarette", -50, "Offer a cigarette");
        MentalDisorder drugAddiction = new MentalDisorder("Drug Addiction", familyPortrait, terminationLetter, alcohol, cigarette);

        mentalDisroders = new MentalDisorder[] { maniac, drugAddiction };
    }

    public MentalDisorder GetMentalDisorder()
    {
        int index = Random.Range(0, mentalDisroders.Length);
        return mentalDisroders[index];
    }
   
}
