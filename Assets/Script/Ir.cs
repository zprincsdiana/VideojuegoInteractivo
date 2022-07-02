using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ir : MonoBehaviour
{
    public void EscenaJuego(string SceneName){
        SceneManager.LoadScene(SceneName);
    }
}
