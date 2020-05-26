using UnityEngine;

public class SunFlare : MonoBehaviour
{
    [SerializeField] private float _rotationOffset = -45f;
    [SerializeField] private Transform _lensFlare = null;
    private float _xLensFlareMax = 1f;
    private float _yLensFlareMax = 1f;


    private void Awake()
    {
        _xLensFlareMax = _lensFlare.localPosition.x;
        _yLensFlareMax = _lensFlare.localPosition.y;
    }


    private void Update()
    {
        Vector3 difference = Camera.main.transform.position - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + _rotationOffset);

        float vecC = Mathf.Sqrt((difference.x * difference.x) + (difference.y * difference.y));

        float _lensFlarePositionPercentage = (_xLensFlareMax / _xLensFlareMax) * (vecC/ _xLensFlareMax);

        _lensFlare.localPosition = new Vector3(
            Mathf.Lerp(0f, _xLensFlareMax, _lensFlarePositionPercentage),
            Mathf.Lerp(0f, _yLensFlareMax, _lensFlarePositionPercentage), -0.5f);
    }
}
