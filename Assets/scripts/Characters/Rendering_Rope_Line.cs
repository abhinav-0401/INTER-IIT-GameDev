using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rendering_Rope_Line : MonoBehaviour
{
    // Start is called before the first frame update
    public LineRenderer RopeLine;
    List<Vector2> edges = new List<Vector2>();
    public Transform OtherCharacterTransform;
    EdgeCollider2D edgecollider;
    void Start()
    {
        edgecollider = this.GetComponent<EdgeCollider2D>();
        // edgecollider.tag = "LineCollider";
    }

    // Update is called once per frame
    void Update()
    {
        MakeLine(transform, OtherCharacterTransform);

        MakeCollider(RopeLine);

    }

     void MakeLine(Transform TR1, Transform TR2)
    {

        List<Vector3> pos = new List<Vector3>();
        pos.Add(TR1.position);
        pos.Add(TR2.position);
        RopeLine.startWidth = 0.1f;
        RopeLine.endWidth = 0.1f;
        RopeLine.SetPositions(pos.ToArray());
        RopeLine.useWorldSpace = true;
        RopeLine.sortingOrder = -1;

    }
    void MakeCollider(LineRenderer lr)
    {
        edges.Clear();
        for (int point = 0; point < lr.positionCount; point++)
        {
            Vector3 lineRendererPoint = lr.GetPosition(point);
            // edges.Add(new Vector2(0, 0));
            edges.Add(new Vector2(lineRendererPoint.x - lr.transform.position.x, lineRendererPoint.y - lr.transform.position.y));
        }
        edgecollider.SetPoints(edges);
    }

}
