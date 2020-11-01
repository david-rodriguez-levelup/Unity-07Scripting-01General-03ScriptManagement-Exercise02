using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    #region Variables

    private MoveBehaviour _myMoveBehaviour;
    
    private FireBehaviour _myFireBehaviour;

    #endregion


    #region Lifecycle

    private void Awake() 
    {
        // Components
        _myMoveBehaviour = GetComponent<MoveBehaviour>();
        _myFireBehaviour = GetComponent<FireBehaviour>();
    }

    private void Update()
    {
        // Move!
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        _myMoveBehaviour.Move(horizontal, vertical);

        // Fire!
        if (Input.GetButtonDown("Fire1"))
        {
            _myFireBehaviour.Fire(GetMousePosition());
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
