using UnityEngine;

public class Gem : MonoBehaviour
{
    public GemType gemType;
    
    private Renderer meshRenderer;
    private Color originalColor;

    void Awake()
    {
        meshRenderer = GetComponent<Renderer>();
    }

    void Start()
    {
        SetColor();
        originalColor = meshRenderer.material.color;
    }

    public void Select()
    {
        meshRenderer.material.color = Color.white;
        Debug.Log($"Selected gem: {gemType}");
    }

    void SetColor()
    {
        switch (gemType)
        {
            case GemType.Red:
                meshRenderer.material.color = Color.red;
                break;

            case GemType.Blue:
                meshRenderer.material.color = Color.blue;
                break;

            case GemType.Green:
                meshRenderer.material.color = Color.green;
                break;

            case GemType.Yellow:
                meshRenderer.material.color = Color.yellow;
                break;

            case GemType.Purple:
                meshRenderer.material.color = new Color(0.6f, 0f, 1f);
                break;

            case GemType.Orange:
                meshRenderer.material.color = new Color(1f, 0.5f, 0f);
                break;
        }
    }
}