using UnityEngine;

public class CubeRigid : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    float elapsed;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.position += new Vector3(speed,0f,0f);
    }
    void Update()
    {
        elapsed += Time.deltaTime;

        if (elapsed >= 5f)
        {
            Debug.Log($"{name}: {transform.position.x}");
            gameObject.SetActive(false);
        }
    }
}
