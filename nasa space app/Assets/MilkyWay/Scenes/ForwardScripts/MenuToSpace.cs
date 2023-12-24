using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuToSpace : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("galaxy1");
    }

}
