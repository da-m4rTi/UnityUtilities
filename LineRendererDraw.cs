using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererDraw : MonoBehaviour
{
    [Header("Set-Up")]
    //[SerializeField] LineRendererType lineRendererType = LineRendererType.Polygon;
    [SerializeField] float radius = 1f;
    [SerializeField] float startWidth = .1f;
    [SerializeField] float endWidth = .1f;
    [SerializeField] int vertexNumber = 50;

    [Header("References")]
    [SerializeField] LineRenderer lineRenderer;


    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }
    void Start()
    {
        
        
    }
    private void Update()
    {
        DrawPolygon(transform.position);
    }


    public void SetRadius(float newRadius)
    {
        radius = newRadius;
    }


    void DrawTriangle(Vector3[] vertexPositions)
    {
        lineRenderer.startWidth = startWidth;
        lineRenderer.endWidth = endWidth;
        lineRenderer.loop = true;
        lineRenderer.positionCount = 3;
        lineRenderer.SetPositions(vertexPositions);
    }
    void DrawPolygon(Vector3 centerPos)
    {
        lineRenderer.startWidth = startWidth;
        lineRenderer.endWidth = endWidth;
        lineRenderer.loop = true;
        float angle = 2 * Mathf.PI / vertexNumber;
        lineRenderer.positionCount = vertexNumber;

        for (int i = 0; i < vertexNumber; i++)
        {
            Matrix4x4 rotationMatrix = new Matrix4x4(
                new Vector4(Mathf.Cos(angle * i), 0, Mathf.Sin(angle * i), 0),
                new Vector4(-1 * Mathf.Sin(angle * i), 0, Mathf.Cos(angle * i), 0),
                new Vector4(0, 0, 1, 0),
                new Vector4(0, 0, 0, 1));
            Vector3 initialRelativePosition = new Vector3(0, radius, 0);
            lineRenderer.SetPosition(i, centerPos + rotationMatrix.MultiplyPoint(initialRelativePosition));

        }
    }


}

enum LineRendererType
{
    Triangle,
    Polygon
}