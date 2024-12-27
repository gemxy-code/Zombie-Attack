using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject _bulletObj;

    void Start()
    {
        InvokeRepeating(nameof(Shoot), 0f, 0.1f);
    }


    private void Shoot()
    {
        PoolManager.instance.RentObject(_bulletObj);
    }
}
