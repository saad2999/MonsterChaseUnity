using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
   public void PlayGame()
    {
        int SelectedCharcter=
            int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
        
        gManager.instance.charIndex = SelectedCharcter;
        SceneManager.LoadScene("Gameplay");
    }
} //Class
