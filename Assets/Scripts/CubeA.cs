using UnityEngine;

public class CubeA : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    float elapsed;
    void Update()
    {
        elapsed += Time.deltaTime;

        transform.position += new Vector3(speed, 0, 0);

        if (elapsed >= 5f)
        {
            Debug.Log($"{name}: {transform.position.x}");
            gameObject.SetActive(false);
        }
    }
}
