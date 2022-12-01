using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Chess.Scripts.Core;

public abstract class IPiece : MonoBehaviour
{
    [SerializeField] public int row, column;

    public Vector2Int Position => new Vector2Int(row, column);
    protected virtual void Start()
    {
        transform.position = ChessBoardPlacementHandler.Instance.GetTile(row, column).transform.position;
    }

    protected abstract List<Vector2Int> GetAllMovements();
    public abstract List<Vector2Int> GetAllPossibleMovements();
}
