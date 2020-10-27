using UnityEngine;

public class MoveBehaviour : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5;
    
    public void Move(float horizontal, float vertical) {
        var direction = new Vector3(horizontal, vertical, 0);
        transform.Translate(direction * _speed * Time.deltaTime);
    }
}
