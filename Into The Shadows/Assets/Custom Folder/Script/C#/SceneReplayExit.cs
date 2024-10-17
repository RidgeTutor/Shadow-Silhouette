using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReplayExit : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Outro Clip");
    }
}
