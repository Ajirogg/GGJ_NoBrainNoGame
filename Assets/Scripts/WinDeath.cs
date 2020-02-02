using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinDeath : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public Backend back;
    public GameObject Win;
    public GameObject Loose;
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoButt(){
        back.NewPatient();
        Win.SetActive(false);
        Loose.SetActive(false);

    }

    
    }
