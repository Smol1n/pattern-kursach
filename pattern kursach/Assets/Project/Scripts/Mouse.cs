using UnityEngine;

public class Mouse : MonoBehaviour
{
    public GameObject message;
    private bool check = false;

    void Update()
    {
        if (message.activeSelf == true && Input.GetMouseButtonDown(0)) 
        {
            message.SetActive(false);
            Time.timeScale = 1f;
            check = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (check == false && other.gameObject.name == "Character")
        {
            message.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
