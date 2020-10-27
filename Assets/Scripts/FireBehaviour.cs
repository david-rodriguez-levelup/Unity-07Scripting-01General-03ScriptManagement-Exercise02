using UnityEngine;

public class FireBehaviour : MonoBehaviour
{
    
    [SerializeField]
    private Rigidbody _projectil;

    [SerializeField]
    private float _projectileForce = 20;
    
    public void Fire(Vector3 target) {
        var projectile = Instantiate(_projectil, transform.position, Quaternion.identity);
        var projectileDelta = target - transform.position;
        projectile.AddForce(projectileDelta.normalized * _projectileForce);
    }

}
