using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    void Update()
    {
       
        Vector3 mousePosition = Input.mousePosition;
        
       
        mousePosition.z = 10; 
        
        
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }
}