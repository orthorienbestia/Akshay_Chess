using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class IPiece : MonoBehaviour
{
    [SerializeField] public int row, column;

    public Vector2Int Position => new Vector2Int(row, column);
    protected virtual void Start()
    {
        transform.position = ChessBoardPlacementHandler.Instance.GetTile(row, column).transform.position;
    }

    public abstract IEnumerable<Vector2Int> GetAllPossibleMovements();

    protected List<Vector2Int> GetPath(int row, int col, int steps, int deltaRow, int deltaCol)
    {
        var result = new List<Vector2Int>() { };
        row += deltaRow;
        col += deltaCol;
        var cell = new Vector2Int(row, col);

        if ((steps <= 0) || // Check if all steps are over
        (row < 0 || row > 7 || col < 0 || col > 7) || // Check if position is inside the board
        ChessBoardPlacementHandler.Instance.GetAllPiecesPositions().Contains(cell) // Check if path is obstructed by any piece
        ) return result;

        result = GetPath(row, col, --steps, deltaRow, deltaCol);
        result.Add(cell);
        return result;
    }
}
