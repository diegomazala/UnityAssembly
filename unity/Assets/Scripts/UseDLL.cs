using UnityEngine;
using System.Collections;
using UnityDLL;

public class UseDLL : MonoBehaviour
{

    void Start()
    {
        MyUtilities utils = new MyUtilities();
        utils.AddValues(2, 3);
        print("2 + 3 = " + utils.c);
    }

    void Update()
    {
        print(MyUtilities.GenerateRandom(0, 100));
    }
}