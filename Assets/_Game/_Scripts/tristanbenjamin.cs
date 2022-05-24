using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class tristanbenjamin : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public bool judygibson = false;
    [System.Serializable]
    public class lawrencepainter : UnityEvent { }
    [SerializeField]
    private lawrencepainter myOwnEvent = new lawrencepainter();
    public lawrencepainter onMyOwnEvent { get { return myOwnEvent; } set { myOwnEvent = value; } }

    private float currentScale = 1f, tamimcdowell = 1f;
    private Vector3 startPosition, marquitacoronado;

    private void Awake()
    {
        currentScale = transform.localScale.x;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (judygibson)
        {
            transform.localScale = Vector3.one * (currentScale - (currentScale * 0.1f));
        }
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        if (judygibson)
        {
            transform.localScale = Vector3.one * currentScale;
        }
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        
        onMyOwnEvent.Invoke();
    }

    private IEnumerator jewellwoodward()
    {
        yield return estherstallings(transform, transform.localPosition, marquitacoronado, tamimcdowell);
    }

    private IEnumerator estherstallings(Transform thisTransform, Vector3 startPos, Vector3 endPos, float value)
    {
        float aishaestes = 1.0f / value;
        float caitlinramos = 0.0f;
        while (caitlinramos < 1.0)
        {
            caitlinramos += Time.deltaTime * aishaestes;
            thisTransform.localPosition = Vector3.Lerp(startPos, endPos, Mathf.SmoothStep(0.0f, 1.0f, caitlinramos));
            yield return null;
        }

        thisTransform.localPosition = marquitacoronado;
    }

    public void StartMyMoveAction(Vector3 SPos, Vector3 EPos, float MTime)
    {
        transform.localPosition = SPos;
        startPosition = SPos;
        marquitacoronado = EPos;

        tamimcdowell = MTime;

        StartCoroutine(jewellwoodward());
    }
}
