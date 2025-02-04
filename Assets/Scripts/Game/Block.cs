using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
  [SerializeField] private Sprite oSprite;
  [SerializeField] private Sprite xSprite;
  [SerializeField] private SpriteRenderer markerspriteRenderer;

  public enum MarkerType{None, O, X}
  
  public delegate void OnBlockClicked(int index); //
  public event OnBlockClicked onBlockClicked; //
  int _blockIndex;

  /// <summary>
  /// Block초기화 함수
  /// </summary>
  /// <param name="blockIndex"></param>
  /// <param name="onBlockClicked">터치 이벤트</param>
  public void InitMarker(int blockIndex, OnBlockClicked onBlockClicked)
  {
    _blockIndex = blockIndex;
    SetMarker(MarkerType.None);
    this.onBlockClicked += onBlockClicked;
  }
  
  /// <summary>
  /// 어떤 마커를 표시할지 전달하는 함수
  /// </summary>
  /// <param name="markerType"></param>
  public void SetMarker(MarkerType markerType)
  {
    switch (markerType)
    {
      case MarkerType.O:
        markerspriteRenderer.sprite = oSprite;
        break;
      case MarkerType.X:
        markerspriteRenderer.sprite = xSprite;
        break;
      case MarkerType.None:
        markerspriteRenderer.sprite = null;
        break;
    }
  }

  private void OnMouseUpAsButton()
  {
    Debug.Log(gameObject.name);
    onBlockClicked?.Invoke(_blockIndex);
  }
}
