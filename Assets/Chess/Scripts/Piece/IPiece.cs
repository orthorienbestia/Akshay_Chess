using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Chess.Scripts.Core;

[RequireComponent(typeof(ChessPlayerPlacementHandler))]
public abstract class IPiece : MonoBehaviour
{
    ChessPlayerPlacementHandler _placementHandler;
    public Vector2Int Position => new Vector2Int(_placementHandler.row, _placementHandler.column);
    protected virtual void Awake()
    {
        _placementHandler = GetComponent<ChessPlayerPlacementHandler>();
    }
    protected abstract List<Vector2Int> GetAllMovements();
    public abstract List<Vector2Int> GetAllPossibleMovements();
}
