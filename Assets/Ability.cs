using UnityEngine;

public class Ability : MonoBehaviour
{
    // In here we will deciede which ability it is
    // 1. show the sprite for the choice
    // 2. send which ability it is through to AbilityManager to handle

    // Ability types
    /*
        - go smaller
        - shield
        - extra points to go towards future shop
        - slow mode
    */
    public AbilityManager abilityManager;

    void Start()
    {
        abilityManager = GameObject
            .FindGameObjectWithTag("AbilityManager")
            .GetComponent<AbilityManager>();
    }

    void Update() { }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            abilityManager.HandleAbility("smaller");
            Destroy(gameObject);
        }
    }
}
