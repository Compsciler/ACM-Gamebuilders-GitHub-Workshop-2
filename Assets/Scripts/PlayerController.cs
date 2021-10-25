using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] int speed;
    private int xBound = 10;
    private int yBound = 4;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime);
        KeepInBounds();
    }

    void KeepInBounds()
    {
        float posX = transform.position.x;
        float posY = transform.position.y;
        if (posX > xBound)
        {
            posX = xBound;
        }
        else if (posX < -xBound)
        {
            posX = -xBound;
        }
        if (posY > yBound)
        {
            posY = yBound;
        }
        else if (posY < -yBound)
        {
            posY = -yBound;
        }
        transform.position = new Vector3(posX, posY, transform.position.z);
    }
}
