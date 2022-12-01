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

    protected List<Vector2Int> GetPath(int row, int column, int step, int rowInc, int colInc)
    {
        var result = new List<Vector2Int>() { };
        row += rowInc;
        column += colInc;

        if ((step <= 0) || (row < 0 || row > 7 || column < 0 || column > 7)) return result;
        var cell = new Vector2Int(row, column);
        if (ChessBoardPlacementHandler.Instance.GetAllPiecesPositions().Contains(cell)) return result;
        result = GetPath(row, column, --step, rowInc, colInc);
        result.Add(cell);
        return result;
    }
}
