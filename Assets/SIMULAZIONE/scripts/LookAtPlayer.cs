using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{

    public GameObject Player;

    

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.rotation = Player.transform.rotation;
        //gameObject.transform.rotation = new Quaternion(0, Player.transform.rotation.y, 0, 0);
        //gameObject.transform.rotation.SetLookRotation(new Vector3(0, Player.transform.rotation.y, 0));
        //gameObject.transform.SetLocalPositionAndRotation(Vector3.zero, new Quaternion(0, Player.transform.rotation.y, 0, 0));
        

    }
}
