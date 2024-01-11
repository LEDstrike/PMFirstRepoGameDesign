using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int sum = 0;
        for(int i = 0; i <= 10000; i++)
        {
            sum += i;
        }
        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
