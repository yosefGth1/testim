using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class onClick : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI txt;
    public int inc = 0;
    void Start()
    {
        //txt.text = inc.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void clicked ()
    {
        inc++;
        txt.text = inc.ToString();
    }
}
