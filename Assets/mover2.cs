using UnityEngine;

public class MoverByClickWASD : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        if (Vector3.Distance(transform.position, GameObject.Find("player1").transform.position) < 0.5f)
        {
            Destroy(GameObject.Find("player2"));
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0f, speed * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0f, speed * Time.deltaTime, 0f);
        }
    }
}
