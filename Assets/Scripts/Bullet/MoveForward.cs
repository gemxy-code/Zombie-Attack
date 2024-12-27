using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private Transform _startPosition;
    [SerializeField] private float _speedBullet;

    private void Awake()
    {
        _startPosition = GameObject.Find("ShootPlace").transform;
    }

    private void OnEnable()
    {
        transform.position = _startPosition.position;
        transform.rotation = _startPosition.rotation;
    }

    private void FixedUpdate()
    {
        transform.Translate(0, 0, Time.deltaTime * _speedBullet);
    }
}
