using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerSc : MonoBehaviour
{
    public GameObject mouse;
    public GameObject mouse2;
    Vector3 MousePosition = new Vector3();
    private int GameStage;
    public Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        GameStage = 2;
    }

    // Update is called once per frame
    void Update()
    {
        MouseControl();
    }
    private void StageControl()
    {

    }
    private void MouseControl()
    {
        Cursor.visible = false; 
        MousePosition = Input.mousePosition;
        mouseMovement();
        mouseClick();
    }
    private void mouseMovement()
    {
        if (GameStage != 1)
        {
            // Farenin ekran pozisyonunu al
            Vector3 mousePosition = Input.mousePosition;

            // Farenin pozisyonunu dünya pozisyonuna çevir
            Vector3 worldPosition = mainCamera.ScreenToWorldPoint(new Vector3(
                mousePosition.x,
                mousePosition.y,
                mainCamera.nearClipPlane
            ));

            // Kameranýn sýnýrlarýný al
            Vector3 bottomLeft = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, mainCamera.nearClipPlane));
            Vector3 topRight = mainCamera.ViewportToWorldPoint(new Vector3(1, 1, mainCamera.nearClipPlane));

            // Dünya pozisyonunu kameranýn sýnýrlarý içinde tut
            worldPosition.x = Mathf.Clamp(worldPosition.x, bottomLeft.x, topRight.x);
            worldPosition.y = Mathf.Clamp(worldPosition.y, bottomLeft.y, topRight.y);

            // Fare görselini güncelle
            mouse.transform.position = worldPosition;
        }
        else
        {
            mouse.SetActive(false);
        }
    }
    private void mouseClick()
    {
        if (Input.GetMouseButton(0))
        {
            mouse2.SetActive(true);
        }
        else
        {
            mouse2.SetActive(false);
        }
    }
}
