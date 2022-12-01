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
        return new List<Vector2Int>() { };
    }
}
