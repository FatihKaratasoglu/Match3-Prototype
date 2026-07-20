using UnityEngine;

public class BoardManager : MonoBehaviour
{
    [Header("Board Settings")]
    [SerializeField] private int width = 8;
    [SerializeField] private int height = 8;

    [Header("References")]
    [SerializeField] private GameObject tilePrefab;
}
