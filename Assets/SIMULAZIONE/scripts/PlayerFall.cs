using UnityEngine;

public class PlayerFall : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            other.transform.SetPositionAndRotation(new Vector3(-4, 0, -3), new Quaternion());
        }
    }
}
