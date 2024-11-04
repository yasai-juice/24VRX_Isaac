using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeManager : MonoBehaviour
{
    public List<Ingredient> ingredients = new List<Ingredient>();

    void Start()
    {
        ingredients.Add(new Ingredient("Red Cube", 0, Resources.Load("VXR1170/Resources/Ingredients/RedCube") as GameObject, 3));
        ingredients.Add(new Ingredient("Green Cube", 1, Resources.Load("VXR1170/Resources/Ingredients/GreenCube") as GameObject, 5));
        ingredients.Add(new Ingredient("Orange Cube", 2, Resources.Load("VXR1170/Resources/Ingredients/OrangeCube") as GameObject, 2));
        ingredients.Add(new Ingredient("Purple Sphere",3, Resources.Load("VXR1170/Resources/Ingredients/PurpleSphere") as GameObject, 8));
        ingredients.Add(new Ingredient("Yellow Sphere",4, Resources.Load("VXR1170/Resources/Ingredients/YellowSphere") as GameObject, 1));

        SpawnIngredients();
    }
    
    void SpawnIngredients()
    {
        for (int i = 0; i < ingredients.Count; i++)
        {
            //instantiate each prefab in the ingredients lsit (will be used when we click on the ingredient prefab)
            GameObject tempObj = Instantiate(ingredients[i].prefab);
            //rename the object to the associated ingredient ID
            tempObj.name = i.ToString();
            //code to offset the ingreents so they are not on top of each other
            Vector3 tempV3 = tempObj.transform.position;
            tempObj.transform.position = new Vector3(tempV3.x + (i * 1), tempV3.y, tempV3.z);
        }
    }
}