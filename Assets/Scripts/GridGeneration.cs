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

        DrawWingFloorArea();

    }

    void DrawWingFloorArea() {
        //This Function requires defaultTile to be set inside Unity3D Editor's Inspector Window.
        //Click on WingA or WingB, and under the GridGeneration component.
        //Drag and drop a tile into the spot.
        for (int x = 0; x < wingSizeX; x++) {
            for (int z = 0; z < wingSizeZ; z++) {

                Vector3 pos = new Vector3(x * gridOffset + wingOffsetX, 0, z * gridOffset + wingOffsetZ);

                GameObject tile = Instantiate(defaultTile, pos, Quaternion.identity) as GameObject;

                tile.transform.SetParent(this.transform);
            }
        }
    }










    //let z be the number of cells in the z axis
    public int cellsZ;
    //let x be the number of cells in the x axis
    public int cellsX;
    //let nz be the number of rooms in the z axis
    public int RoomsZ;
    //let nx be the number of rooms in the x axis
    public int RoomsX;
    //let pz be the position modifyer for the z axis
    public int positionModz;
    //let px be the position modifyer for the x axis
    public int positionModx;
    //(10(z/nz))+pz
    //private float zAxisequation = ((10 * (cellsZ / RoomsZ)) + positionModz);
    //(10(x/nx))+px
    //private float xAxisequation = ((10 * (cellsX / RoomsX)) + positionModx);
    void ProceduralGrid() {
    
    
    
    }
    void RoomDefinition() {
        //Vector3 WingA = new Vector3(xAxisequation, 0, zAxisequation);
        //Vector3 WingB = new Vector3(xAxisequation, 0, zAxisequation);
    }
   
}

    

        
