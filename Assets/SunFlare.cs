using UnityEngine;

public class SunFlare : MonoBehaviour
{
    public float offset;
    public Transform _transform;


    private void Update()
    {
        Vector3 difference = Camera.main.transform.position - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
    }
}
