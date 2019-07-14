using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Cannon")]
public class Cannon : ScriptableObject
{
    public Transform prefab = null;
    public string tag = "Untagged";
    public Color color = new Color(255, 255, 255, 1);
    public int direction = 1;
    public int layer = 1;

    public Transform Initialize(Vector3 position, Quaternion rotation, Vector3 scale)
    {
        //Instantiate GameObject
        Transform obj = Instantiate(prefab);

        //Set position, rotation and scale
        if(direction == 1)
        {
            obj.position = position;
            obj.rotation = rotation;
            obj.localScale = scale;
        }else if(direction == -1)
        {
            obj.position = position;
            obj.rotation = Quaternion.Euler(rotation.eulerAngles * direction);
            obj.localScale = new Vector3(scale.x * direction, scale.y, scale.z);
            obj.Find("Direction").transform.eulerAngles = new Vector3(0f, 180f, 12f);
        }
        
        //Set color
        obj.GetComponent<SpriteRenderer>().color = color;

        //Set tag and layer
        obj.tag = tag;
        obj.gameObject.layer = layer;
        for(int i = 0; i < obj.childCount; i++)
        {
            obj.GetChild(i).tag = tag;
            obj.GetChild(i).gameObject.layer = layer;
        }

        //Return object
        return obj;
    }
}
