using UnityEngine;

public class MoveBehaviour : MonoBehaviour
{
    [SerializeField]
    private SpeedData speedData;
    
    public void Move(float horizontal, float vertical) {
        Move(horizontal, vertical, 0f);
    }

    public void Move(float horizontal, float vertical, float depth) {
        var direction = new Vector3(horizontal, vertical, depth);
        transform.Translate(direction * speedData.Speed * Time.deltaTime);
    }
}
