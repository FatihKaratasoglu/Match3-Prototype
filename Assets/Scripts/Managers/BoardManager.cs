using UnityEngine;

public class BoardManager : MonoBehaviour
{
    [Header("Board Settings")]
    [SerializeField] int width;
    [SerializeField] int height;

    [Header("References")]
    [SerializeField] GameObject tilePrefab;

    [Header("Gem")]
    [SerializeField] GameObject gemPrefab;

    void Start()
    {
        CreateBoard();
        transform.position = new Vector3(-width / 2f + 0.5f, 0, -height / 2f + 0.5f);
    }
    void CreateBoard()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Vector3 position = new Vector3(x, 0, y);
                GameObject tileObject = Instantiate(tilePrefab, position, Quaternion.identity, transform);
                Tile tile = tileObject.GetComponent<Tile>();
                tile.gridPosition = new Vector2Int(x, y);
                GameObject gemObject = Instantiate(gemPrefab, position + Vector3.up * 0.6f, Quaternion.identity, tileObject.transform);
                Gem gem = gemObject.GetComponent<Gem>();
                gem.gemType = (GemType)Random.Range(0, System.Enum.GetValues(typeof(GemType)).Length);
            }
        }
    }
}
