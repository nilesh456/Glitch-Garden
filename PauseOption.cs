using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseOption : MonoBehaviour {

    public GameObject pausedMenuUI;
    private bool IsPaused;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            IsPaused = !IsPaused;
        }

        if (IsPaused)
        {
            ActivateMenu();
        }

        else
        {
            DeactivateMenu();
        }
    }

    void ActivateMenu ()
    {
        pausedMenuUI.SetActive(true);
    }

    void DeactivateMenu ()
    {
        pausedMenuUI.SetActive(false);
    }


}
