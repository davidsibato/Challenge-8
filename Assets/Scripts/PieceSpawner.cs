using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceSpawner : MonoBehaviour
{
    public PieceType type;
    private Piece _currentPiece;

    public void Spawn()
    {
        int amtObjs = 0;
        switch (type)
        {
            case PieceType.jump:
                amtObjs = LevelManager.Instance.jumps.Count;
                break;
            case PieceType.slide:
                amtObjs = LevelManager.Instance.slides.Count;
                break;
            case PieceType.longblock:
                amtObjs = LevelManager.Instance.longblocks.Count;
                break;
            case PieceType.ramp:
                amtObjs = LevelManager.Instance.ramps.Count;
                break;
        }
        _currentPiece = LevelManager.Instance.GetPiece(type, Random.Range(0, amtObjs));
        _currentPiece.gameObject.SetActive(true);
        _currentPiece.transform.SetParent(transform, false);
    }

    public void DeSpawn()
    {
        //currentPiece = Get a new Piece from the pool;
        _currentPiece.gameObject.SetActive(false);
    }
}