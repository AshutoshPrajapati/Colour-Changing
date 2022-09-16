using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float jumpspeed = 400f;
    Rigidbody2D rb;
    public SpriteRenderer sr;
    public string currentColour;
    public Color yellow;
    public Color magenta;
    public Color cyan;
    public Color pink;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ChangeRandomColour();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector3.up * jumpspeed * Time.deltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ColorChanger"))
        {
            ChangeRandomColour();
        } 
        else if (collision.tag != currentColour)
        {
            SceneManager.LoadScene(0);
        }
    }
    #region RandomColour
    public void ChangeRandomColour()
    {
        int index = Random.Range(0, 4);
        switch (index)
        {
            case 0:
                currentColour = "Cyan";
                sr.color = cyan;
                break;
            case 1:
                currentColour = "Yellow";
                sr.color = yellow;
                break;
            case 2:
                currentColour = "Magenta";
                sr.color = magenta;
                break;
            case 3:
                currentColour = "Pink";
                sr.color = pink;
                break;
        }
        #endregion
    }
}
