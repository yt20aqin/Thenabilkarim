using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class mariocaudill : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public bool alinemclain = false;
    [System.Serializable]
    public class hiramkaplan : UnityEvent { }
    [SerializeField]
    private hiramkaplan myOwnEvent = new hiramkaplan();
    public hiramkaplan onMyOwnEvent { get { return myOwnEvent; } set { myOwnEvent = value; } }

    private float currentScale = 1f, ursulahorne = 1f;
    private Vector3 startPosition, denicesantana;

    private void Awake()
    {
        currentScale = transform.localScale.x;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (alinemclain)
        {
            transform.localScale = Vector3.one * (currentScale - (currentScale * 0.1f));
        }
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        if (alinemclain)
        {
            transform.localScale = Vector3.one * currentScale;
        }
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        
        onMyOwnEvent.Invoke();
    }

    private IEnumerator maryannbiggs()
    {
        yield return dorthypearce(transform, transform.localPosition, denicesantana, ursulahorne);
    }

    private IEnumerator dorthypearce(Transform thisTransform, Vector3 startPos, Vector3 endPos, float value)
    {
        float youngyost = 1.0f / value;
        float penelopethomson = 0.0f;
        while (penelopethomson < 1.0)
        {
            penelopethomson += Time.deltaTime * youngyost;
            thisTransform.localPosition = Vector3.Lerp(startPos, endPos, Mathf.SmoothStep(0.0f, 1.0f, penelopethomson));
            yield return null;
        }

        thisTransform.localPosition = denicesantana;
    }

    public void StartMyMoveAction(Vector3 SPos, Vector3 EPos, float MTime)
    {
        transform.localPosition = SPos;
        startPosition = SPos;
        denicesantana = EPos;

        ursulahorne = MTime;

        StartCoroutine(maryannbiggs());
    }
}
