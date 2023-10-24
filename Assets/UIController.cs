using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject instruction;
    public GameObject homepage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Instructions()
    {
        homepage.SetActive(false);
        instruction.SetActive(true);
    }
    public void Homepage()
    {
        instruction.SetActive(false);
        homepage.SetActive(true);
    }

}
