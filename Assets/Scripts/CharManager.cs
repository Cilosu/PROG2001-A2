using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharManager : MonoBehaviour
{
    public GameObject gingerBread;
    public float value;
    public Vector3 sizeChange;

    //Method to move character left
    public void moveLeft()
    {
        value = value - 0.1f;
        gingerBread.transform.position = new Vector3(value, 3, 5);
    }

    //Method to move character right
    public void moveRight()
    {
        value = value + 0.1f;
        gingerBread.transform.position = new Vector3(value, 3, 5);
    }

    //Method to rotate character left
    public void rotateLeft()
    {
        gingerBread.transform.Rotate(0f, 20f, 0f);
    }

    //Method to rotate character right
    public void rotateRight()
    {
        gingerBread.transform.Rotate(0f, -20f, 0f);
    }

    //Method to resize character larger
    public void resizeUp()
    {
        moveUp(); //moves character higher to try and keep him 'standing' on the floor
        gingerBread.transform.localScale = gingerBread.transform.localScale + sizeChange;
    }

    //Method to resize character smaller
    public void resizeDown()
    {
        moveDown();//moves character lower to try and keep him 'standing' on the floor
        gingerBread.transform.localScale = gingerBread.transform.localScale - sizeChange;
    }

    //method to move character up
    public void moveUp()
    {
        value = value + 0.5f;
        gingerBread.transform.position = new Vector3(0, 3 + value, 5);
    }

    //Method to move character down
    public void moveDown()
    {
        value = value - 0.5f;
        gingerBread.transform.position = new Vector3(0, 3 + value, 5);
    }

    //Method to reset character back to original transform settings
    public void resetGingerbread()
    {
        gingerBread.transform.position = new Vector3(0, 3, 5);
        gingerBread.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        gingerBread.transform.localScale = new Vector3(1, 1, 1);
    }
}
