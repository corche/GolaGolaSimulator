using UnityEngine;

public class MouseLock : MonoBehaviour
{
    public static bool isMouseLocked = false;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            MouseLockToggle();
        }
    }

    private void MouseLockToggle() => SetMouseLock(!isMouseLocked);

    private void SetMouseLock(bool isLocked)
    {
        Cursor.visible = !isLocked;
        isMouseLocked = isLocked;
    }
}
