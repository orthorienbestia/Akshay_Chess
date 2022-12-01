using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {
                var piece = hit.transform.GetComponent<IPiece>();
                //Select stage    
                if (piece)
                {
                    Debug.Log("Tapped: " + piece.gameObject.name + "  " + piece.Position);
                }
            }
        }
    }

    private void HandleTap(IPiece piece)
    {
        ChessBoardPlacementHandler.Instance.ClearHighlights();
    }
}
