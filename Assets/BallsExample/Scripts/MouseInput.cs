using UnityEngine;

public class MouseInput : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject target = GetObjectToMousePosition();
            if (target != null && target.TryGetComponent(out Ball ball))
            {
                Destroy(target);
            }
        }
    }

    private GameObject GetObjectToMousePosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
            return hit.collider.gameObject;
        else
            return null;
    }
}
