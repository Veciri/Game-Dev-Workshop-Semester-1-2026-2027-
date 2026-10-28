using UnityEngine;
using UnityEngine.Tilemaps;

public class CoinPickup : MonoBehaviour
{
    public UIManager uiManagerRef;
    private Tilemap tilemapRef;

    private void Start()
    {
        tilemapRef = GetComponent<Tilemap>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        uiManagerRef.ModifyCoins(1);

        Vector3 playerPos = collision.gameObject.transform.position;

        tilemapRef.SetTile(Vector3Int.FloorToInt(playerPos), null);
    }
}
