using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using System.Linq;

public class textfour : MonoBehaviour
{

    public int x;
    // Start is called before the first frame update
    void Start()
    {
        StreamReader stream = new StreamReader("textfourunity.txt");
        string line;
        line = stream.ReadLine();
       x = int.Parse(line);

        


    }

    // Update is called once per frame
    void Update()
    {
       
    }
}