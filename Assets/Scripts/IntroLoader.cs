using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;


public class IntroLoader : MonoBehaviour
{
    public VideoPlayer player;
    public string sceneToLoad = "Menu";

    void Start()
    {
        player.Play();
        player.loopPointReached += EndIntro;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LoadScene();
        }
    }

    void EndIntro(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
