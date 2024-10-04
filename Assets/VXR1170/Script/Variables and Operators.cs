using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class VariablesandOpperators : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int health = 10; //whole numbers
        int damage = 2;
        int healthPotion = 3;
        int poison = 1;
        float defence = 2.0f; //decimal numbers, double, and decimal double the amount of decimals
        Debug.LogWarning("No target assigned for LookAt."); //string that I pulled out of the transfom components script
        bool FFA = false; //true or false, default is always false
        int damageTaken = health - damage; //subtraction
        int healingPotion = health + healthPotion; //addition
        float poisonDMG = health / poison; //division


        int a = 10;
        int b = 9;
        int resullt = a % b;  // gives a remainder value of 1

        a = 6;
        a += 4;  // equals to 10

        a = 7;
        a -= 3;  // equals to 4

        int r = 9;
        r++;        // makes 10

        r = 9;
        r--;        // makes 8

            if (r == 8) { }  // if r equals equals 8, do { }
                             // == means to compare 2 values and always makes a bool value

            if (r != 8) { }  // if r does not equal 8, do { }  // also always makes a bool value

        bool ticTacs = false;
        if (!ticTacs) { }      // if the ticTacs values isn't false, do { }

        a = 33;
        if (a > b) { }  // if a is greater than b, do { }

        int y = 88;
        int e = 100;
        if (y < e) { }  // if y is lesser than e, do { }

        int g = 35;
        int L = 76;
        if (L >= g) { }  // if L is greater than or equal to g, do { }
        if (g <= L) { }  // if g is lesser than or equal to L, do { }

        if (r == 8 && ticTacs) { } // if r equals equals 8 and ticTacs isn't false, do { }

        if (r == 8 || ticTacs) { } // if r equals equals 8 or if ticTacs isn't false, do { }

    }
}
