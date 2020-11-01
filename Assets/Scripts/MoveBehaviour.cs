using UnityEngine;

public class MoveBehaviour : MonoBehaviour
{

    #region Variables

    [SerializeField]
    [Tooltip("Asset with movement data settings.")]
    private ObjectMovementData movementData;

    #endregion


    #region Public methods

    public void Move(float horizontal, float vertical) 
    {
        Move(horizontal, vertical, 0f);
    }

    public void Move(float horizontal, float vertical, float depth) 
    {
        var direction = new Vector3(horizontal, vertical, depth);
        transform.Translate(direction * movementData.Speed * Time.deltaTime);
    }

    #endregion    

}
