using UnityEngine;

/// <summary>
/// Move behaviour.
/// Inject a <see cref="ObjectMovementData"/> in the inspector 
/// and call <see cref="Move(float, float)"/> or <see cref="Move(float, float, float)"/> 
/// to translate the object's transform.
/// </summary>
/// <see cref="ObjectMovementData"/>
public class MoveBehaviour : MonoBehaviour
{

    #region Variables

    [SerializeField]
    [Tooltip("Asset with movement data settings.")]
    private ObjectMovementData _movementData;

    #endregion


    #region Public methods

    /// <summary>
    /// Moves the object's transform in the x and y axis.
    /// </summary>
    /// <param name="horizontal">x movement.</param>
    /// <param name="vertical">y movement.</param>
    public void Move(float horizontal, float vertical) 
    {
        Move(horizontal, vertical, 0f);
    }

    /// <summary>
    /// Moves the object's transform in the x, y and z axis.
    /// </summary>
    /// <param name="horizontal">x movement.</param>
    /// <param name="vertical">y movement.</param>
    /// <param name="depth">z movement.</param>
    public void Move(float horizontal, float vertical, float depth) 
    {
        var direction = new Vector3(horizontal, vertical, depth);
        transform.Translate(direction * _movementData.Speed * Time.deltaTime);
    }

    #endregion    

}
