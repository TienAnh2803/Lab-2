using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Xulivacham : MonoBehaviour
{
    public int Egg = 0;
    public TextMeshProUGUI EggText;
    // Start is called before the first frame update
    void Start()
    {
        EggText.SetText(Egg.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Egg"))
        {
            Egg++;
            EggText.SetText(Egg.ToString());
            Destroy(collision.gameObject);
        }
    }
}
