using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OscReceiver : MonoBehaviour
{
    public OSC osc;
    public string oscAdress;
    public int slot;

    public float inputValue;

    [SerializeField]
    private float testInput;
    private float oldTestInput;

    [System.Serializable]
    public class ColorEvent : UnityEvent<float> { }
    public ColorEvent target;



    // Start is called before the first frame update
    void Start()
    {
        if (osc == null)
            osc = GameObject.Find("OSCHandler").GetComponent<OSC>();
        osc.SetAddressHandler(oscAdress, OnReceive);

        
    }

    // Update is called once per frame
    void Update()
    {
        if(testInput != oldTestInput)
        {
            oldTestInput = testInput;
            target.Invoke(testInput);
        }
    }

    void OnReceive(OscMessage message)
    {
        
        inputValue = message.GetFloat(slot);

        target.Invoke(inputValue);
    }
}
