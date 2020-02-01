using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MentalDisordersList : MonoBehaviour
{
    public MentalDisorder[] mentalDisroders;

    public MentalDisordersList()
    {
        ObjectUsable incense = new ObjectUsable("incense", 50);
        ObjectUsable noteBook = new ObjectUsable("Note Book", 50);
        ObjectUsable picture = new ObjectUsable("Picture", -50);
        ObjectUsable carpet = new ObjectUsable("Carpet", -50);
        MentalDisorder maniac = new MentalDisorder("Maniac", incense, noteBook, picture, carpet);

        ObjectUsable familyPortrait = new ObjectUsable("Family Portrait", 50);
        ObjectUsable terminationLetter = new ObjectUsable("Termination Letter", 50);
        ObjectUsable alcohol = new ObjectUsable("Alcohol", -50);
        ObjectUsable cigarette = new ObjectUsable("Cigarette", -50);
        MentalDisorder drugAddiction = new MentalDisorder("Drug Addiction", familyPortrait, terminationLetter, alcohol, cigarette);

        mentalDisroders = new MentalDisorder[] { maniac, drugAddiction };
    }

    public MentalDisorder GetMentalDisorder()
    {
        int index = Random.Range(0, mentalDisroders.Length);
        return mentalDisroders[index];
    }
   
}
