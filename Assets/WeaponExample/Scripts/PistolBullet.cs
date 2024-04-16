using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PistolBullet : MonoBehaviour, IShootable
{
    [SerializeField] private Color _color;

    private Renderer _renderer;

    public GameObject BulletPrefab => gameObject;

    public Color BulletColor => _color;


    private void OnEnable()
    {
        _renderer = GetComponent<Renderer>();

        SetColor();
    }
    public void SetColor()
    {
        if(_renderer != null)
            _renderer.material.color = BulletColor;
    }
}
