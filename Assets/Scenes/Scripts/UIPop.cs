using UnityEngine;

public class UIPop : MonoBehaviour
{

    [SerializeField] private float animTime = 0.35f;

    private RectTransform rt;
    private CanvasGroup cg;
    private Vector3 startScale;

    void Awake()
    {
        rt = GetComponent<RectTransform>();
        cg = GetComponent<CanvasGroup>();
        startScale = rt.localScale;
    }

    public void Show()
    {
        gameObject.SetActive(true);
        cg.alpha = 0f;
        rt.localScale = Vector3.zero;


        LeanTween.value(gameObject, 0f, 1f, animTime)
            .setOnUpdate(v => cg.alpha = v)
            .setEaseOutExpo()
            .setIgnoreTimeScale(true);


        LeanTween.scale(rt, startScale * 1.01f, animTime)
            .setEaseOutBack()
            .setIgnoreTimeScale(true)
            .setOnComplete(() =>
            {
                LeanTween.scale(rt, startScale, 0.1f)
                    .setEaseOutBack()
                    .setIgnoreTimeScale(true);
            });
    }

    public void Hide()
    {
        LeanTween.value(gameObject, 1f, 0f, animTime * 2)
            .setOnUpdate(v => cg.alpha = v)
            .setEaseInExpo()
            .setIgnoreTimeScale(true);

        LeanTween.scale(rt, Vector3.zero, animTime * 2)
            .setEaseInBack()
            .setIgnoreTimeScale(true)
            .setOnComplete(() => gameObject.SetActive(false));
    }

}
