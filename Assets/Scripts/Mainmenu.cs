using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Exit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
