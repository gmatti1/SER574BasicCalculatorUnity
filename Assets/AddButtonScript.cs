using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AddButtonScript : MonoBehaviour
{
    public InputField num1;
    public InputField num2;
    public Text result;

    // Start is called before the first frame update
    void Start()
    {
        int first = int.Parse(num1.text);
        int second = int.Parse(num2.text);
        result.text = "sdfsdf";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
