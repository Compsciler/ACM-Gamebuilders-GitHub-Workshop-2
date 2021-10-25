using UnityEngine;
public class DestroyOnClick : MonoBehaviour
{
    void OnMouseDown()
    {
        Destroy(gameObject);
        Debug.Log("Time survived: " + Time.time + "s");
    }
}
