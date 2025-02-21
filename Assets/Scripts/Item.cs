using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    protected bool InShelf;
    protected bool InShop;
    protected bool InBackpack;
    public enum itemType
    {
        weapon,
        nature,
        pet
    }
    public itemType MyType;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

}
