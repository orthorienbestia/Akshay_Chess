using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : IPiece
{
    protected override List<Vector2Int> GetAllMovements()
    {
        return new List<Vector2Int>() { };
    }
    public override List<Vector2Int> GetAllPossibleMovements()
    {
        var result = new List<Vector2Int>() { };

        result = ChessBoardPlacementHandler.Instance.GetAllPiecesPositions();
        var s = "#10Am@z0n01#";
        return result;
    }
}
