using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject MenuButton;
    public GameObject MenuBoard;
    private GameObject Mary;

    private Image MenuPan;
    private Controll MaryControl;

    private bool activiated;

    private Vector3 roomVector = new Vector3(-7, -6.2f, 0);

    public void Start()
    {
        MenuButton = GameObject.Find("MenuButton");
        MenuButton.SetActive(true);

        MenuBoard = GameObject.Find("Menu");
        //MenuBoard = GameObject.Find("Menu_UI").gameObject;
        MenuBoard.SetActive(false);

        Mary = GameObject.FindGameObjectWithTag("Mary");

        MenuPan = MenuBoard.GetComponent<Image>();
        //MaryControl = MaryControl.GetComponent<Controll>();

        activiated = false;
       
    }

    public void MenuON()
    {
        activiated = true;
        MenuButton.SetActive(false);
       // MaryControl.gameObject.SetActive(false);
        
        MenuBoard.SetActive(true);
        MenuPan.gameObject.SetActive(activiated);
        Mary.GetComponent<Controll>().speed = 0;
    }

    public void MenuOFF()
    {
        activiated = false;
        MenuButton.SetActive(true);
      
          Debug.Log(MenuButton.activeSelf);
          MenuPan.gameObject.SetActive(activiated);

        Mary.GetComponent<Controll>().speed = 8;

        MenuBoard.SetActive(false);
    }

    public void MoveToMain()
    {
        Destroy(GameObject.Find("Mary"));
        SceneManager.LoadScene("MainMenu");
    }

    public void MoveToRoom()
    {
        SceneManager.LoadScene("MaryRoom");
        Mary.GetComponent<Transform>().position = roomVector;
    }

    public void Exit()
    {
        Application.Quit();
    }




}