using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Antares.QRCode;

public class QRCodeGenerate : MonoBehaviour {

    //in the scene,we need three UI elements:1. image to show pic 2. input filed 3.generate Button

    public Image _QRImage;

    public Text _INputFiled;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // call by button
    public void QRButton() {


        Encode_QR(_INputFiled.text);


    }

    // generate texture -- convert to sprite -- feed to image
    public void Encode_QR(string _URL) {

        Texture2D tx = QRCodeProcessor.Encode(_URL, 512, 512);

        Sprite sp = Sprite.Create(tx, new Rect(0, 0, 512, 512), new Vector2(0f, 0f));

        _QRImage.sprite = sp;




    }




}
