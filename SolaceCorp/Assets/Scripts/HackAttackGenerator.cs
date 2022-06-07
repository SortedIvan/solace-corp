using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackAttackGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public int StartInitialAttack()
    {
        return ChooseNextOfficeToAttack(Random.Range(1, 9));
    }

    public int ChooseNextOfficeToAttack(int previousOffice)
    {
        int nextOffice = Random.Range(1, 9);

        while (nextOffice == previousOffice)
        {
            nextOffice = Random.Range(1, 9);
        }

        return nextOffice;
    }
}
