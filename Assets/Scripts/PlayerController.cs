using UnityEngine;

/// <summary>
/// A very simple player controller.
/// </summary>
public class PlayerController : MonoBehaviour
{
    
    #region Variables

    // Components
    private MoveBehaviour _moveBehaviour;
    private FireBehaviour _fireBehaviour;

    #endregion


    #region Lifecycle

    private void Awake() 
    {
        // Components
        _moveBehaviour = GetComponent<MoveBehaviour>();
        _fireBehaviour = GetComponent<FireBehaviour>();
    }

    private void Update()
    {
        // Move!
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        _moveBehaviour.Move(horizontal, vertical);

        // Fire!
        if (Input.GetButtonDown("Fire1"))
        {
            _fireBehaviour.Fire(GetMousePosition());
        }
    }    

    #endregion


    #region Private methods

    private Vector3 GetMousePosition() 
    {
        var mouseInput = Input.mousePosition;
        mouseInput.z = 10;
        var mousePosition = Camera.main.ScreenToWorldPoint(mouseInput);
        mousePosition.z = 0;
        return mousePosition;
    }

    #endregion

}
