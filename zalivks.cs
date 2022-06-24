using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class zalivks : MonoBehaviour,IPointerClickHandler
{
    public Button red;
    public Button green;
    public Button blue;
    public Button rose;
    public Button yellow;
    public Button violet;
    public Button black;
    public Button white;
    public GameObject pixel;
    public Button pencil;
    public Button zfkivka;

    public string instrument;

    public SpriteRenderer img;
    public Color cl;

    public bool flag = false;
    // Start is called before the first frame updates
    void Start()
    {
        img = GetComponent<SpriteRenderer>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(instrument == "lastik")
        {
            pixel.GetComponent<SpriteRenderer>().color = Color.white;
        }
        else
        {
        pixel.GetComponent<SpriteRenderer>().color = cl;

        }
    }
    public void chosered()
    {
        cl = Color.red;
    }
    public void chosegreen()
    {
        cl = Color.green;
    }
    public void choseblue()
    {
        cl = Color.blue;
    }
    public void choserose()
    {
        cl = Color.magenta;
    }
    public void choseyellow()
    {
        cl = Color.yellow;
    }
    public void choseviolet()
    {
        cl = new Color(212,0,255);
    }
    public void choseblack()
    {
        cl = Color.black;
    }
    public void chosewhite()
    {
        cl= Color.white;
    }
    public void pencile()
    {
        instrument = "pensile";
    }
    public void zilivine()
    {
        instrument = "zalivka";
    }
    public void lastic()
    {
        instrument = "lastik";
    }
    private void OnMouseDrag()
    {
        if (instrument == "zalivka")
        {
            img.color = cl;
        }
        if (instrument == "pensile")
        {
            Vector3 mouseworldposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseworldposition.z = -3;
            Instantiate(pixel, mouseworldposition, Quaternion.identity);
        }
        if(instrument == "lastik")
        {
            Vector3 mouseworldposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseworldposition.z = -9;
            Instantiate(pixel, mouseworldposition, Quaternion.identity);
        }
    }
    void IPointerClickHandler()
    {
        if (instrument == "zalivka")
        {
            img.color = cl;
        }
        if (instrument == "pensile")
        {
            Vector3 mouseworldposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseworldposition.z = -3;
            Instantiate(pixel, mouseworldposition, Quaternion.identity);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
