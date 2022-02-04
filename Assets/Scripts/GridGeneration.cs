using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GridGeneration : MonoBehaviour {
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.

    public GameObject defaultTile;

    //defines the size of the grid on the X axis
    public int wingSizeX = 3;

    //Defines the size of the grid on the Z axis
    public int wingSizeZ = 3;
    
    //sets the offset of tiles so they don't overlap
    public int gridOffset = 10;
    

    //the grid starts with the bottom left most 
    //changes the postion of the entire grid on the X axis
    public int wingOffsetX;
    
    //changes the position of the entire grid on the Y axis
    public int wingOffsetZ;

    void Start() {

        for (int x = 0; x < wingSizeX; x++) {
            for (int z = 0; z < wingSizeZ; z++) {

                Vector3 pos = new Vector3(x * gridOffset + wingOffsetX, 0, z * gridOffset + wingOffsetZ);

                GameObject tile = Instantiate(defaultTile, pos, Quaternion.identity) as GameObject;

                tile.transform.SetParent(this.transform);
            }
        }

    }
}
