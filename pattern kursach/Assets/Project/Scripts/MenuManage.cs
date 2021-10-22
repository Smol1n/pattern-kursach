using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManage : MonoBehaviour
{
    public void PlayClick()
    {
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Main");
	} 

    public void ExitClick()
    {
        GetComponent<AudioSource>().Play();
		Application.Quit();
	}
}