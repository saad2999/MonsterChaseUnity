using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Players;
    private string ScaneName = "Gameplay";
    public static gManager instance;
    private int _charIndex;
    public int charIndex
    {
        get { return _charIndex; }
        set { _charIndex = value; }
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }
    void OnLevelFinishedLoading(Scene scane,LoadSceneMode mode )
    {
        if (scane.name == ScaneName)
        {
            Instantiate(Players[charIndex]);
        }
    }
   
} //class
