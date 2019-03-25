using UnityEngine;
using System.Collections;

public class ReceivePosition : MonoBehaviour {
    
   	public OSC osc;

    public string adressMoveX;
    public string adressMoveY;
    public string adressMoveZ;

    // Use this for initialization
    void Start () {
	  // osc.SetAddressHandler( "/CubeXYZ" , OnReceiveXYZ );
       osc.SetAddressHandler(adressMoveX, OnReceiveX);
       osc.SetAddressHandler(adressMoveY, OnReceiveY);
       osc.SetAddressHandler(adressMoveZ, OnReceiveZ);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    /*
        void OnReceiveXYZ(OscMessage message){
            float x = message.GetInt(0);
             float y = message.GetInt(1);
            float z = message.GetInt(2);

            transform.position = new Vector3(x,y,z);
        }
        */

    void OnReceiveX(OscMessage message) {
        print("receiveX");
        float x = message.GetFloat(0);

        Vector3 position = transform.position;

        position.x = x;

        transform.position = position;
    }

    void OnReceiveY(OscMessage message) {
        print("receiveY");
        float y = message.GetFloat(0);

        Vector3 position = transform.position;

        position.y = y;

        transform.position = position;
    }

    void OnReceiveZ(OscMessage message) {
        float z = message.GetFloat(0);

        Vector3 position = transform.position;

        position.z = z;

        transform.position = position;
    }


}
