using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientInfo : MonoBehaviour
{
    // Start is called before the first frame update
    public string[] names;
    public string[] firstnames;

    public string actualname;
    public string actualFirstname;

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
            "Ledda",
            "Disarbois",
            "Monnier",
            "Galvin",
            "Goy",
            "Raimundo" };
    }

    public string getRandomName()
    {
        int index = Random.Range(0, names.Length);
        return actualname = names[index];
    }

    public string getRandomFirstname()
    {
        int index = Random.Range(0, firstnames.Length);
        return actualFirstname = firstnames[index];
    }
}
