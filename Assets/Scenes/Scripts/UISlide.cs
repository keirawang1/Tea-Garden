using UnityEngine;

public class UISlide : MonoBehaviour
{
    public enum SlideDirection { Up, Down, Left, Right }

    [SerializeField] private SlideDirection direction = SlideDirection.Up;
    [SerializeField] private float slideOffset = 200f;
    [SerializeField] private float animTime = 0.35f;

    private RectTransform rt;
    private CanvasGroup cg;
    private Vector2 startPos;

    void Awake()
    {
        rt = GetComponent<RectTransform>();
        cg = GetComponent<CanvasGroup>();
        startPos = rt.anchoredPosition;

    }

    public void Show()
    {
        
        gameObject.SetActive(true);
        cg.alpha = 0f;

        Vector2 offset = GetOffsetVector(direction, slideOffset);
        rt.anchoredPosition = startPos + offset;

        LeanTween.value(gameObject, 0f, 1f, animTime)
            .setOnUpdate(v => cg.alpha = v)
            .setEaseOutExpo()
            .setIgnoreTimeScale(true);

        LeanTween.move(rt, startPos, animTime)
            .setEaseOutExpo()
            .setIgnoreTimeScale(true);
    }

    public void Hide()
    {
        var rt = GetComponent<RectTransform>();
        var cg = GetComponent<CanvasGroup>();

        Vector2 offset = GetOffsetVector(direction, slideOffset);

        LeanTween.value(gameObject, 1f, 0f, animTime)
            .setOnUpdate(v => cg.alpha = v)
            .setEaseInExpo()
            .setIgnoreTimeScale(true);

        LeanTween.move(rt, startPos + offset, animTime)
            .setEaseInExpo()
            .setIgnoreTimeScale(true)
            .setOnComplete(() => gameObject.SetActive(false));
    }

    private static Vector2 GetOffsetVector(SlideDirection dir, float distance)
    {
        return dir switch
        {
            SlideDirection.Up => new Vector2(0f, -distance),
            SlideDirection.Down => new Vector2(0f, distance),
            SlideDirection.Left => new Vector2(distance, 0f),
            SlideDirection.Right => new Vector2(-distance, 0f),
            _ => Vector2.zero
        };
    }

    

}
