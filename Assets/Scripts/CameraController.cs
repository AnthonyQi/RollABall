using UnityEngine;

public class CameraController : MonoBehaviour
{
    #region Instance Variables
    public GameObject player;
    private Vector3 offset;

    #endregion
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //TEST comment
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
