using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientInfo : MonoBehaviour
{
    // Start is called before the first frame update
    public string[] names;
    public string[] firstnames;

    public PatientInfo()
    {
        firstnames = new string[] { 
            "Guillaume",
            "Priscila",
            "Florent",
            "Alan",
            "Loic",
            "Britt" };

        names = new string[] {
            "LEDDA",
            "DISARBOIS",
            "MONNIER",
            "GALVIN",
            "GOY",
            "RAIMUNDO" };
    }

    public string getRandomName()
    {
        int index = Random.Range(0, names.Length);
        return names[index];
    }

    public string getRandomFirstname()
    {
        int index = Random.Range(0, firstnames.Length);
        return firstnames[index];
    }
}
