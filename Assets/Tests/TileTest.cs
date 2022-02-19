using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TileTest {
    // A Test behaves as an ordinary method
  
   

    [UnityTest]
    public IEnumerator ConstructorInstantiatesTiles() {
        int expected = 4;
        int actual = 2;
        yield return null;
        Assert.Less(expected, actual, "Can see this?");
        //
    
    }

}
