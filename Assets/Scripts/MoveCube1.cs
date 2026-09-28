using UnityEngine;
using UnityEngine.InputSystem;

public class MoveCube1 : MonoBehaviour
{
    public float speed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            Keyboard kb = Keyboard.current;
            if (kb == null) return;

            float x = 0f;
            float z = 0f;

            if (kb.aKey.isPressed) x = -1f;
            if (kb.dKey.isPressed) x = 1f;
            if (kb.sKey.isPressed) z = -1f;
            if (kb.wKey.isPressed) z = 1f;

            Vector3 direction = new Vector3(x, 0f, z).normalized;

            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}
