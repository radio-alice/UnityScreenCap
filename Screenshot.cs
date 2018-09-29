using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshot : MonoBehaviour {
    public string fileName;
    int screenshotNum;
    
    public void Capture () {
        string fileNameTemp = fileName + screenshotNum.ToString();
        ScreenCapture.CaptureScreenshot(fileNameTemp+".png");
        screenshotNum += 1;
	}
	
}
