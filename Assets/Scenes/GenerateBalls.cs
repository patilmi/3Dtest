using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GenerateBalls : MonoBehaviour
{
    // Start is called before the first frame update
    
    public int width = 9;
    public int height = 9;

    List<GameObject> ballList = new List<GameObject>();

    void Start()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //sphere.AddComponent<Animation>();
        //sphere.AddComponent<MeshFilter>();
        //sphere.AddComponent<MeshCollider>();
        //sphere.AddComponent<MyCustomScript>();
        //sphere.AddComponent<MeshRenderer>();

        var sphereRenderer = sphere.GetComponent<Renderer>();

        sphereRenderer.material.SetColor("_Color", Color.red);
        
        for (int y=0; y<height; y+=2)
        {
           for (int x=0; x<width; x+=2)
           {
             ballList.Add(Instantiate(sphere, new Vector3(x,y,0), Quaternion.identity));
           }
        }    

    
    }

    // Update is called once per frame
    // void Update()
    // {

        
    // }
}
