using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    public GameObject panelmenu, paneloption;
    public void bukaoption()
    {
        panelmenu.SetActive(false);
        paneloption.SetActive(true);
    }
    public void bukamenu()
    {
        panelmenu.SetActive(true);
        paneloption.SetActive(false);
    }

    public void startgame()
    {
        SceneManager.LoadScene("startgame");
    }
}
