using UnityEngine;
using UnityEngine.Events;

public class Passsystem : MonoBehaviour
{
    public string nameTarget = "�p���s";
    public UnityEvent onPass;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == nameTarget) onPass.Invoke();
    }
}
