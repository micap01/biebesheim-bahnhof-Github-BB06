using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavButtons1 : MonoBehaviour {

	public void NavForward ()
    {
        SceneManager.LoadScene(2);
    }

    public void NavBackward()
    {
        SceneManager.LoadScene(0);
    }

}
