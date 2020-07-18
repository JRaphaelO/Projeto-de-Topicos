using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject aplicationIcons;
    public GameObject galleryIcons;
    private GameObject blink;

    private bool isAplication = true;

    private void InvertAplication(bool isAplication)
    {
        aplicationIcons.SetActive(isAplication);
        galleryIcons.SetActive(!isAplication);
    }

    public void ApplicationExit()
    {
        if (isAplication)
            Application.Quit();
        
        else 
            InvertAplication(true);
    }

    public void GalleryButton()
    {
        InvertAplication(false);
    }

    public void ScreenShootButton() 
    {
        StartCoroutine(this.CaptureIt());
    }

    IEnumerator CaptureIt() 
    {

        print("Isso ta pegando");
        string timeStamp = System.DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
        string filename = "Screenshot" + timeStamp + ".png";
        string pathToSave = filename;
        ScreenCapture.CaptureScreenshot(pathToSave);
        yield return new WaitForEndOfFrame();
    
    }
}
