using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient
{
    public string name;
    public int id;
    public GameObject prefab;
    public int dollarValue;
    // constructor for ingredient class - each of the required parameters need
    // to be
    public Ingredient(string redCube, int id = 1, GameObject RedCube, int dollarValue = 3)
    {
        name = redCube;
        id = 1;
        prefab = RedCube;
        dollarValue = 3;
    }
    public Ingredient(string greenCube, int id = 2, GameObject GreenCube, int dollarValue = 2)
    {
        name = greenCube;
        id = 2;
        prefab = GreenCube;
        dollarValue = 2;
    }
    public Ingredient(string orangeCube, int id = 3, GameObject OrangeCube, int dollarValue = 1)
    {
        name = orangeCube;
        id = 3;
        prefab = OrangeCube;
        dollarValue = 1;
    }
    public Ingredient(string purpleSphere, int id = 4, GameObject PurpleSphere, int dollarValue = 5)
    {
        name = purpleSphere;
        id = 4;
        prefab = PurpleSphere;
        dollarValue = 5;
    }
    public Ingredient(string yellowSphere, int id = 5, GameObject YellowSphere, int dollarValue = 6)
    {
        name = yellowSphere;
        id = 5;
        prefab = YellowSphere;
        dollarValue = 6;
    }
}
